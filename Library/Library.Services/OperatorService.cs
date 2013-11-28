using Library.Contracts;
using Library.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Library.DataAccess.DBInterop.Queries.Concrete;
using Library.DataContracts.Concrete;
using Library.DataAccess.DBInterop.Executors;
using Library.DataAccess.DBInterop.Queries.Abstract;
using System.Data.Common;

namespace Library.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class OperatorService : AbstractService, IOperator
    {


        public IEnumerable<Reader> GetReaders() {
            return Ninject.Get<GetReadersQuery>().Execute();
        }

        public Reader AddReader(Reader reader) {
            if (GetReaders().Any(r => r.Id == reader.Id)) {
                throw new Exception("Читатель с таким номером паспорта уже существует!");
            }

            var executor = Ninject.Get<Executor>();
            var provider = Factory.Get();
            reader.Card = new Card();
            var insertReader = new InsertReaderQuery(provider) {
                Reader = reader
            };
            var insertCard = new InsertCardQuery(provider) {
                Reader = reader
            };

            executor.ExecuteNonQueries(new NoValueQuery[]{
                insertReader,
                insertCard
            });
            return reader;
        }

        public Reader UpdateReader(Reader reader) {
            var query = Ninject.Get<UpdateReaderQuery>();
            query.Reader = reader;
            query.Execute();
            return reader;
        }

        public Reader DeleteReader(Reader reader) {
            var query = Ninject.Get<DeleteReaderQuery>();
            query.Reader = reader;
            query.Execute();
            return reader;
        }

        public Reader RenewCard(Reader reader) {
            reader = GetReaders().FirstOrDefault(r => r.Id == reader.Id);
            if (reader == null) {
                throw new Exception("Читатель не найден");
            }
            if (reader.Card.ExpiryDate.Date > DateTime.Now.Date) {
                throw new Exception("Срок действия читательского билета еще не истек. Продление невозможно");
            }
            if (reader.Card.ExpiryDate.AddMonths(1).Date < DateTime.Now.Date) {
                throw new Exception("Продление читательского билета возможно только в течении месяца после его срока истечения");
            }

            var query = Ninject.Get<RenewCardQuery>();
            query.Reader = reader;
            query.Execute();
            return reader;
        }

        public IEnumerable<RequestCreator> GetRequestCreators(string search = "") {
            search = (search ?? string.Empty).Trim().ToLower();
            return
                Ninject.Get<GetRequestCreatorsQuery>()
                .Execute()
                .Where(r =>
                    r.FirstName.ToLower().Contains(search) ||
                    r.LastName.ToLower().Contains(search) ||
                    r.MiddleName.ToLower().Contains(search) ||
                    r.Card.Id.ToString().Contains(search));
        }

        public IEnumerable<RequestApproved> GetApprovedRequests(Card card) {
            var query = Ninject.Get<GetApprovedRequestsQuery>();
            query.Card = card;
            return query.Execute().OrderByDescending(r => r.Id.Id.CreateDate);
        }

        public IEnumerable<RequestRejected> GetRejectedRequests(Card card) {
            var query = Ninject.Get<GetRejectedRequestsQuery>();
            query.Card = card;
            return query.Execute().OrderByDescending(r => r.Id.Id.CreateDate);
        }

        public RequestCreator CreateRequest(Reader reader, IEnumerable<Request> requests) {
            if (requests == null || !requests.Any()) {
                throw new Exception("Для создания запроса необходимо выбрать хотя бы одну книгу");
            }

            var card = GetReaders().Select(r => r.Card).FirstOrDefault(c => c.Id == reader.Card.Id);
            if (card == null) {
                throw new Exception("Не удалось обнаружить читательский билет. Возможно, билет не создан");
            }
            if (card.ExpiryDate.Date < DateTime.Now.Date) {
                throw new Exception("Срок действия читательского билета истек. Перед созданием запроса продлите читательский билет");
            }

            var executor = Ninject.Get<Executor>();
            var id = Ninject.Get<GenerateRequestIdQuery>().Execute();
            var provider = Factory.Get();

            foreach (var r in requests) {
                r.Id = new RequestHeader() {
                    Id = id,
                    Reader = reader
                };
            }

            executor.ExecuteNonQueries(from r in requests
                                       select new InsertRequestQuery(provider) {
                                           Request = r
                                       });

            return GetRequestCreators().FirstOrDefault(c => c.Card.Id == reader.Card.Id);
        }

        //public IEnumerable<RequestApproved> GetApprovedRequests(RequestHeader request) {
        //    var query = Ninject.Get<GetApprovedRequestsQuery>();
        //    query.Request = request;
        //    return query.Execute();
        //}

        //public IEnumerable<RequestRejected> GetRejectedRequests(RequestHeader request) {
        //    var query = Ninject.Get<GetRejectedRequestsQuery>();
        //    query.Request = request;
        //    return query.Execute();
        //}

        public RequestApproved RenewRequest(RequestApproved request) {
            request = GetRequestApproved(request);

            if (request.IsReturned) {
                throw new Exception("Книга уже возвращена. Продление невозможно");
            }

            if (DateTime.Now.Date <= request.ReturnDate.Date) {
                throw new Exception("Срок возврата еще не истек. Продление невозможно");
            }

            var command = Ninject.Get<RenewRequestQuery>();
            command.RequestApproved = request;
            try {
                command.Execute();
            } catch (DbException exc) {
                throw new Exception("Достигнут предел числа продлений. Дальнейшее продление невозможно");
            }
            return request;
        }

        public RequestApproved CloseRequest(RequestApproved request) {
            request = GetRequestApproved(request);

            if (request.IsReturned) {
                throw new Exception("Книга уже возвращена");
            }

            var returnBook = Ninject.Get<UpdateBooksQuantityQuery>();
            returnBook.Book = request.Id.Book;
            returnBook.BookQuantity = request.Id.BookQuantity;

            var closeRequest = Ninject.Get<CloseRequestQuery>();
            closeRequest.RequestApproved = request;

            var executor = Ninject.Get<Executor>();
            try {
                executor.ExecuteNonQueries(new NoValueQuery[]{
                    returnBook,
                    closeRequest
                });
                request.IsReturned = true;
            } catch (Exception exc) {
                throw exc;
            }
            return request;
        }

        public IEnumerable<Notification> SendNotifications() {
            var query = Ninject.Get<SendNotificationsQuery>();
            query.Execute();
            var sended = query.Notifications.ToList();
            var result = new List<Notification>();
            if (sended.Count > 0) {
                result.AddRange(
                    from s in sended
                    join n in Ninject.Get<GetNotificationsQuery>().Execute() on new {
                        RequestId = s.RequestId,
                        BookId = s.BookId
                    } equals new {
                        RequestId = n.Id.Id.Id,
                        BookId = n.Id.Book.Id
                    }
                    select n
                );
            }
            return result;
        }

        protected RequestApproved GetRequestApproved(RequestApproved source) {
            return GetApprovedRequests(source.Id.Id.Reader.Card).FirstOrDefault(s => s.Id.Equals(source.Id));
        }

        public IEnumerable<Book> GetBooks() {
            return Ninject.Get<GetBooksQuery>().Execute();
        }

        public IEnumerable<Author> GetBookAuthors(Book book) {
            var query = Ninject.Get<GetBookAuthorsQuery>();
            query.Book = book;
            return query.Execute();
        }
    }
}

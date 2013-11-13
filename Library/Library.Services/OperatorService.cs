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
            var query = Ninject.Get<InsertReaderQuery>();
            query.Reader = reader;
            query.Execute();
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

        public IEnumerable<Card> GetCards() {
            return Ninject.Get<GetCardsQuery>().Execute();
        }

        public IEnumerable<RequestHeader> GetRequestHeaders(Card card = null, string search = "") {
            var query = Ninject.Get<GetRequestHeadersQuery>();
            query.Card = card;
            query.Search = (search ?? string.Empty).Trim();
            return query.Execute();
        }

        public RequestHeader CreateRequest(Card card, IEnumerable<Request> requests) {
            if (requests == null || !requests.Any()) {
                throw new Exception("Для создания запроса необходимо выбрать хотя бы одну книгу");
            }
            var executor = Ninject.Get<Executor>();
            var id = Ninject.Get<GenerateRequestIdQuery>().Execute();
            var provider = Factory.Get();

            foreach (var r in requests) {
                r.Id = new RequestHeader() {
                    Id = id,
                    Card = card
                };
            }

            executor.ExecuteNonQueries(from r in requests
                                       select new InsertRequestQuery(provider) {
                                           Request = r
                                       });

            return new RequestHeader() {
                Id = id,
                Card = card,
                CreateDate = DateTime.Now
            };
        }

        public IEnumerable<RequestApproved> GetApprovedRequests(RequestHeader request) {
            var query = Ninject.Get<GetApprovedRequestsQuery>();
            query.Request = request;
            return query.Execute();
        }

        public IEnumerable<RequestRejected> GetRejectedRequests(RequestHeader request) {
            var query = Ninject.Get<GetRejectedRequestsQuery>();
            query.Request = request;
            return query.Execute();
        }

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
            return GetApprovedRequests(request.Id.Id).FirstOrDefault(r => r.Id.Equals(request.Id));
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

        protected RequestApproved GetRequestApproved(RequestApproved source) {
            return GetApprovedRequests(source.Id.Id).FirstOrDefault(s => s.Id.Equals(source.Id));
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

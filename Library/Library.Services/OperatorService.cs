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

namespace Library.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class OperatorService : AbstractService, IOperator
    {

        public IEnumerable<Reader> GetReaders() {
            return Ninject.Get<GetReadersQuery>().Execute();
        }

        public Reader AddReader(Reader reader) {
            throw new NotImplementedException();
        }

        public Reader UpdateReader(Reader reader) {
            throw new NotImplementedException();
        }

        public Reader DeleteReader(Reader reader) {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> GetCards() {
            return Ninject.Get<GetCardsQuery>().Execute();
        }

        public IEnumerable<RequestHeader> GetRequestHeaders() {
            return Ninject.Get<GetRequestHeadersQuery>().Execute();
        }

        public RequestHeader CreateRequest(Card card, IEnumerable<Request> requests) {
            if (requests == null || !requests.Any()) {
                throw new Exception("Для создания запроса необходимо выбрать хотя бы одну книгу");
            }
            var executor = Ninject.Get<Executor>();
            var id = Ninject.Get<GenerateRequestIdQuery>().Execute();
            var provider = Factory.Get();

            foreach(var r in requests){
                r.Id = new RequestHeader(){
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

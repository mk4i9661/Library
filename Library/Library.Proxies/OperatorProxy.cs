using Library.Contracts;
using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Proxies
{
    public class OperatorProxy : AuthenticableProxy<IOperator>, IOperator
    {
        public OperatorProxy(AuthenticationData data)
            : base(data) {
        }
        public IEnumerable<DataContracts.Concrete.Reader> GetReaders() {
            return ExecuteScoped(() => Channel.GetReaders());
        }

        public DataContracts.Concrete.Reader AddReader(DataContracts.Concrete.Reader reader) {
            return ExecuteScoped(() => Channel.AddReader(reader));
        }

        public DataContracts.Concrete.Reader UpdateReader(DataContracts.Concrete.Reader reader) {
            return ExecuteScoped(() => Channel.UpdateReader(reader));
        }

        public DataContracts.Concrete.Reader DeleteReader(DataContracts.Concrete.Reader reader) {
            return ExecuteScoped(() => Channel.DeleteReader(reader));
        }

        public IEnumerable<Card> GetCards() {
            return ExecuteScoped(() => Channel.GetCards());
        }

        public IEnumerable<RequestHeader> GetRequestHeaders() {
            return ExecuteScoped(() => Channel.GetRequestHeaders());
        }

        public RequestHeader CreateRequest(Card card, IEnumerable<Request> requests) {
            return ExecuteScoped(() => Channel.CreateRequest(card, requests));
        }

        public IEnumerable<RequestApproved> GetApprovedRequests(RequestHeader request) {
            return ExecuteScoped(() => Channel.GetApprovedRequests(request));
        }

        public IEnumerable<RequestRejected> GetRejectedRequests(RequestHeader request) {
            return ExecuteScoped(() => Channel.GetRejectedRequests(request));
        }

        public IEnumerable<Book> GetBooks() {
            return ExecuteScoped(() => Channel.GetBooks());
        }

        public IEnumerable<Author> GetBookAuthors(Book book) {
            return ExecuteScoped(() => Channel.GetBookAuthors(book));
        }
    }
}

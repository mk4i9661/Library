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

        public Reader RenewCard(Reader reader) {
            return ExecuteScoped(() => Channel.RenewCard(reader));
        }

        public IEnumerable<RequestHeader> GetRequestHeaders(Reader reader = null, string search = "") {
            return ExecuteScoped(() => Channel.GetRequestHeaders(reader, search));
        }

        public RequestHeader CreateRequest(Reader reader, IEnumerable<Request> requests) {
            return ExecuteScoped(() => Channel.CreateRequest(reader, requests));
        }

        public IEnumerable<RequestApproved> GetApprovedRequests(RequestHeader request) {
            return ExecuteScoped(() => Channel.GetApprovedRequests(request));
        }

        public IEnumerable<RequestRejected> GetRejectedRequests(RequestHeader request) {
            return ExecuteScoped(() => Channel.GetRejectedRequests(request));
        }

        public RequestApproved RenewRequest(RequestApproved request) {
            return ExecuteScoped(() => Channel.RenewRequest(request));
        }

        public RequestApproved CloseRequest(RequestApproved request) {
            return ExecuteScoped(() => Channel.CloseRequest(request));
        }

        public IEnumerable<Notification> SendNotifications() {
            return ExecuteScoped(() => Channel.SendNotifications());
        }

        public IEnumerable<Book> GetBooks() {
            return ExecuteScoped(() => Channel.GetBooks());
        }

        public IEnumerable<Author> GetBookAuthors(Book book) {
            return ExecuteScoped(() => Channel.GetBookAuthors(book));
        }
    }
}

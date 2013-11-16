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

        //---------
        public IEnumerable<Card> GetCards(){
            return ExecuteScoped(() => Channel.GetCards());
            //return Channel.GetCards();
        }
        public DataContracts.Concrete.Card AddCard(DataContracts.Concrete.Card card)
        {
            return ExecuteScoped(() => Channel.AddCard(card));
        }

        public DataContracts.Concrete.Card UpdateCard(DataContracts.Concrete.Card card)
        {
            return ExecuteScoped(() => Channel.UpdateCard(card));
        }

        public DataContracts.Concrete.Card DeleteCard(DataContracts.Concrete.Card card)
        {
            return ExecuteScoped(() => Channel.DeleteCard(card));
        }
        //---------

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

        

        public IEnumerable<RequestHeader> GetRequestHeaders(Card card = null, string search = "") {
            return ExecuteScoped(() => Channel.GetRequestHeaders(card, search));
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

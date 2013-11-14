using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts
{
    [ServiceContract]
    public interface IOperator
    {
        [OperationContract]
        IEnumerable<Reader> GetReaders();
        [OperationContract]
        Reader AddReader(Reader reader);
        [OperationContract]
        Reader UpdateReader(Reader reader);
        [OperationContract]
        Reader DeleteReader(Reader reader);

        [OperationContract]
        IEnumerable<Card> GetCards();
        [OperationContract]
        Card AddCard(Card card);
        [OperationContract]
        Card UpdateCard(Card card);
        [OperationContract]
        Card DeleteCard(Card card);

        [OperationContract]
        IEnumerable<RequestHeader> GetRequestHeaders(Card card = null, string search = "");
        [OperationContract]
        RequestHeader CreateRequest(Card card, IEnumerable<Request> requests);
        [OperationContract]
        IEnumerable<RequestApproved> GetApprovedRequests(RequestHeader request);
        [OperationContract]
        IEnumerable<RequestRejected> GetRejectedRequests(RequestHeader request);
        [OperationContract]
        //продлить книгу
        RequestApproved RenewRequest(RequestApproved request);
        [OperationContract]
        //вернуть книгу
        RequestApproved CloseRequest(RequestApproved request);
        
        [OperationContract]
        IEnumerable<Book> GetBooks();
        [OperationContract]
        IEnumerable<Author> GetBookAuthors(Book book);
    }
}

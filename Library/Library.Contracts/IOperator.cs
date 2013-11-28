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
        Reader RenewCard(Reader reader);

        [OperationContract]
        IEnumerable<RequestCreator> GetRequestCreators(string search = "");
        [OperationContract]
        IEnumerable<RequestApproved> GetApprovedRequests(Card card);
        [OperationContract]
        IEnumerable<RequestRejected> GetRejectedRequests(Card card);
        [OperationContract]
        RequestCreator CreateRequest(Reader reader, IEnumerable<Request> requests);
        [OperationContract]
        //продлить книгу
        RequestApproved RenewRequest(RequestApproved request);
        [OperationContract]
        //вернуть книгу
        RequestApproved CloseRequest(RequestApproved request);
        [OperationContract]
        IEnumerable<Notification> SendNotifications();
        
        [OperationContract]
        IEnumerable<Book> GetBooks();
        [OperationContract]
        IEnumerable<Author> GetBookAuthors(Book book);
    }
}

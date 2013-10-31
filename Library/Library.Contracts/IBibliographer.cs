using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Library.DataContracts.Concrete;

namespace Library.Contracts
{
    [ServiceContract]
    public interface IBibliographer
    {
        [OperationContract]
        IEnumerable<Publisher> GetPublishers();

        [OperationContract]
        Publisher AddPublisher(Publisher publisher);
        [OperationContract]
        Publisher UpdatePublisher(Publisher publisher);
        [OperationContract]
        Publisher DeletePublisher(Publisher publisher);
    }
}

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
        Request AddRequest(Request request);
    }
}

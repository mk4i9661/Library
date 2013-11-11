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
    public interface IChief
    {
        [OperationContract]
        IEnumerable<ReportBook> GetBooks(Rubric rubric = null, Publisher publisher = null, string search = "");
        [OperationContract]
        IEnumerable<Publisher> GetPublishers();
        [OperationContract]
        IEnumerable<Rubric> GetRubrics();
        [OperationContract]
        IEnumerable<Reader> GetBookHolders(Book book);
        [OperationContract]
        IEnumerable<Reader> GetBookObligators(Book book);
    }
}

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

namespace Library.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class OperatorService : AbstractService, IOperator
    {

        public IEnumerable<DataContracts.Concrete.Reader> GetReaders() {
            return Ninject.Get<GetReadersQuery>().Execute();
        }

        public DataContracts.Concrete.Reader AddReader(DataContracts.Concrete.Reader reader) {
            throw new NotImplementedException();
        }

        public DataContracts.Concrete.Reader UpdateReader(DataContracts.Concrete.Reader reader) {
            throw new NotImplementedException();
        }

        public DataContracts.Concrete.Reader DeleteReader(DataContracts.Concrete.Reader reader) {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> GetCards() {
            return Ninject.Get<GetCardsQuery>().Execute();
        }

        public IEnumerable<Request> GetRequests() {
            return Ninject.Get<GetRequestsQuery>().Execute();
        }

        public Request AddRequest(Request request) {
            throw new NotImplementedException();
        }
    }
}

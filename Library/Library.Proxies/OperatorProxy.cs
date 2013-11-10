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

        public Request AddRequest(Request request) {
            return ExecuteScoped(() => Channel.AddRequest(request));
        }
    }
}

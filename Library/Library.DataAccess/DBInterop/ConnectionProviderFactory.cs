using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.DBInterop
{
    public class ConnectionProviderFactory
    {
        protected string ConnectionString {
            get;
            private set;
        }

        public ConnectionProviderFactory(string connectionString) {
            ConnectionString = connectionString;
        }

        public ConnectionProvider Get() {
            return new ConnectionProvider(ConnectionString);
        }
    }
}

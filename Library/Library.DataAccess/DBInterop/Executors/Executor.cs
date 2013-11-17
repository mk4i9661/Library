using Library.DataAccess.DBInterop.Queries.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.DBInterop.Executors
{
    public class Executor
    {
        public ConnectionProvider ConnectionProvider {
            get;
            private set;
        }

        public Executor(ConnectionProvider provider) {
            ConnectionProvider = provider;
        }

        public void ExecuteNonQueries(IEnumerable<NoValueQuery> queries) {
            ConnectionProvider.ExecuteNonQueries(queries);
        }
    }
}

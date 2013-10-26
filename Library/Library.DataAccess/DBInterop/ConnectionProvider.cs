using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace Library.DataAccess.DBInterop
{
    public class ConnectionProvider
    {
        public string ConnectionString {
            get;
            protected set;
        }

        public ConnectionProvider(string connectionString) {
            ConnectionString = connectionString;
        }

        public OracleConnection CreateConnection() {
            return new OracleConnection(ConnectionString);
        }

        public virtual void ExecuteNonQuery(OracleCommand command) {
            using (var connection = CreateConnection()) {
                connection.Open();
                using (command) {
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
            }
        }

        public virtual DataSet ExecuteTable(OracleCommand command) {
            using (var connection = CreateConnection()) {
                connection.Open();
                using (command) {
                    command.Connection = connection;
                    using (var adapter = new OracleDataAdapter(command)) {
                        var set = new DataSet();
                        adapter.Fill(set);
                        return set;
                    }
                }
            }
        }

        public virtual object ExecuteScalar(OracleCommand command) {
            using (var connection = CreateConnection()) {
                connection.Open();
                using (command) {
                    command.Connection = connection;
                    return command.ExecuteScalar();
                }
            }
        }


    }
}

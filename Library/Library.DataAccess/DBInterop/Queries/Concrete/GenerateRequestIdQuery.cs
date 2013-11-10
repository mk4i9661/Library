using Library.DataAccess.DBInterop.Queries.Abstract;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public class GenerateRequestIdQuery : ScalarQuery<int>
    {
        const string Query = @"select request_sequence.nextval from dual";

        public GenerateRequestIdQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand(Query);
        }

        protected override int Read(object obj) {
            return Convert.ToInt32(obj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.DBInterop.Queries.Abstract;
using Oracle.DataAccess.Client;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public class SendNotificationsQuery : NoValueQuery
    {
        public SendNotificationsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override OracleCommand CreateOracleCommand() {
            return new OracleCommand("SEND_NOTIFICATIONS") {
                CommandType = CommandType.StoredProcedure
            };
        }
    }
}

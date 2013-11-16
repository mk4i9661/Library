using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.DBInterop.Queries.Abstract;
using Oracle.DataAccess.Client;
using Library.DataAccess.OracleCustomTypes;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public class SendNotificationsQuery : NoValueQuery
    {
        public SendNotificationsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override OracleCommand CreateOracleCommand() {
            var command = new OracleCommand("SEND_NOTIFICATIONS") {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.Add(new OracleParameter() {
                ParameterName = "sended",
                UdtTypeName = "SENDED_NOTIFICATIONS",
                OracleDbType = OracleDbType.Object,
                Direction = ParameterDirection.Output
            });
            return command;
        }

        public IEnumerable<Notification> Notifications {
            get;
            private set;
        }

        protected override void ExecuteQuery(OracleCommand command) {
            var parameter = command.Parameters["sended"];
            base.ExecuteQuery(command);
            Notifications = (from n in ((SendedNotifications)parameter.Value).SendedNotifcations
                             select new Notification() {
                                 RequestId = n.RequestId,
                                 BookId = n.BookId
                             }).ToArray();
        }

        public class Notification
        {
            public int RequestId {
                get;
                set;
            }

            public int BookId {
                get;
                set;
            }
        }
    }
}

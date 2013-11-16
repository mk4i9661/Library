using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.OracleCustomTypes
{
    internal class SendedNotifications : IOracleCustomType
    {
        [OracleArrayMapping]
        public NotificationObject[] SendedNotifcations;

        public void FromCustomObject(OracleConnection con, IntPtr pUdt) {
            OracleUdt.SetValue(con, pUdt, 0, SendedNotifcations);
        }

        public void ToCustomObject(OracleConnection con, IntPtr pUdt) {
            SendedNotifcations = (NotificationObject[])OracleUdt.GetValue(con, pUdt, 0);
        }
    }
}

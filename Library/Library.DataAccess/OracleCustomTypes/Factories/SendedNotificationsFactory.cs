using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.OracleCustomTypes.Factories
{
    [OracleCustomTypeMapping("SENDED_NOTIFICATIONS")]
    internal class SendedNotificationsFactory : IOracleCustomTypeFactory, IOracleArrayTypeFactory
    {
        public Array CreateArray(int numElems) {
            return new NotificationObject[numElems];
        }

        public Array CreateStatusArray(int numElems) {
            return null;
        }

        public IOracleCustomType CreateObject() {
            return new SendedNotifications();
        }
    }
}

using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.OracleCustomTypes.Factories
{
    [OracleCustomTypeMapping("NOTIFICATION_OBJECT")]
    internal class NotificationObjectFactory : IOracleCustomTypeFactory
    {
        public IOracleCustomType CreateObject() {
            return new NotificationObject();
        }
    }
}

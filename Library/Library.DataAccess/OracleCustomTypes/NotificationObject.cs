using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.OracleCustomTypes
{
    internal class NotificationObject : IOracleCustomType
    {
        [OracleObjectMapping("REQUEST_ID")]
        public int RequestId {
            get;
            set;
        }

        [OracleObjectMapping("BOOK_ID")]
        public int BookId {
            get;
            set;
        }

        [OracleObjectMapping("TYPE_ID")]
        public int TypeId {
            get;
            set;
        }

        public void FromCustomObject(OracleConnection con, IntPtr pUdt) {
            OracleUdt.SetValue(con, pUdt, "REQUEST_ID", RequestId);
            OracleUdt.SetValue(con, pUdt, "BOOK_ID", BookId);
            OracleUdt.SetValue(con, pUdt, "TYPE_ID", TypeId);
        }

        public void ToCustomObject(OracleConnection con, IntPtr pUdt) {
            RequestId = Convert.ToInt32(OracleUdt.GetValue(con, pUdt, "REQUEST_ID"));
            BookId = Convert.ToInt32(OracleUdt.GetValue(con, pUdt, "BOOK_ID"));
            TypeId = Convert.ToInt32(OracleUdt.GetValue(con, pUdt, "TYPE_ID"));
        }
    }
}

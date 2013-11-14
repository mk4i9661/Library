using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Library.DataContracts.Abstract;

namespace Library.DataContracts.Concrete
{
    [DataContract]
    public class NotificationType : UniqueObjectInt<NotificationType>
    {
        [DataMember]
        public string Text {
            get;
            set;
        }

        public override string ToString() {
            return Text;
        }
    }
}

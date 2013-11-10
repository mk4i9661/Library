using Library.DataContracts.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataContracts.Concrete
{
    [DataContract]
    public class Request : UniqueObjectInt<Request>
    {
        [DataMember]
        public Card Card {
            get;
            set;
        }

        public DateTime CreateDate {
            get;
            set;
        }
    }
}

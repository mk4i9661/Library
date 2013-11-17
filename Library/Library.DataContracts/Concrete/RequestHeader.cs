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
    public class RequestHeader : UniqueObjectInt<RequestHeader>
    {
        [DataMember]
        public Reader Reader {
            get;
            set;
        }

        [DataMember]
        public DateTime CreateDate {
            get;
            set;
        }

        [DataMember]
        public bool HasApprovedRequests {
            get;
            set;
        }

        [DataMember]
        public bool HasRejectedRequests {
            get;
            set;
        }
    }
}

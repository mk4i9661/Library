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
    public class RequestApproved : UniqueObjectRequest<RequestApproved>
    {

        [DataMember]
        public DateTime ReturnDate {
            get;
            set;
        }

        [DataMember]
        public int RenewalCount {
            get;
            set;
        }

        [DataMember]
        public bool IsReturned {
            get;
            set;
        }
    }
}

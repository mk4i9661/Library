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
    public class RequestApproved : UniqueObject<Request, RequestApproved>
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

        public override int CompareTo(RequestApproved other) {
            return Id.CompareTo(other.Id);
        }

        public override bool Equals(RequestApproved other) {
            return Id.Equals(other.Id);
        }

        public override int Compare(RequestApproved x, RequestApproved y) {
            return x.Id.CompareTo(y.Id);
        }
    }
}

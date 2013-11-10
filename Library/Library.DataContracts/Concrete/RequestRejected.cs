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
    public class RequestRejected : UniqueObject<Request, RequestRejected>
    {
        [DataMember]
        public RejectReason Reason {
            get;
            set;
        }

        public override int CompareTo(RequestRejected other) {
            return Id.CompareTo(other.Id);
        }

        public override bool Equals(RequestRejected other) {
            return Id.Equals(other.Id);
        }

        public override int Compare(RequestRejected x, RequestRejected y) {
            return x.Id.CompareTo(y.Id);
        }
    }
}

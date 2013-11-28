using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataContracts.Concrete
{
    [DataContract]
    public class RequestCreator : Reader, IEquatable<RequestCreator>
    {
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

        public bool Equals(RequestCreator other) {
            return ((Reader)this).Equals((Reader)other);
        }
    }
}

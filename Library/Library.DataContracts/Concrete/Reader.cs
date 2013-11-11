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
    public class Reader : UniqueObjectInt<Reader>
    {
        [DataMember]
        public string FirstName {
            get;
            set;
        }

        [DataMember]
        public string LastName {
            get;
            set;
        }

        [DataMember]
        public string MiddleName {
            get;
            set;
        }

        [DataMember]
        public string Address {
            get;
            set;
        }

        [DataMember]
        public string Phone {
            get;
            set;
        }
    }
}

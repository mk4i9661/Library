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
    public class Author : UniqueObjectInt<Author>
    {
        [DataMember]
        public string FirstName {
            get;
            set;
        }

        [DataMember]
        public string MiddleName {
            get;
            set;
        }

        [DataMember]
        public string LastName {
            get;
            set;
        }

        [DataMember]
        public string Biography {
            get;
            set;
        }
    }
}

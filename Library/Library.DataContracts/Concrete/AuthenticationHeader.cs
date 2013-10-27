using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataContracts.Concrete
{
    [DataContract(Name = "AuthenticationHeader", Namespace = "Library.Headers")]
    public class AuthenticationHeader
    {
        [DataMember]
        public AuthenticationData Data {
            get;
            set;
        }
    }
}

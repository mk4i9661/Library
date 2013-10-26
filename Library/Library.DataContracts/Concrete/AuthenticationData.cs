using System;
using System.Runtime.Serialization;
using Library.DataContracts.Abstract;

namespace Library.DataContracts.Concrete
{
    [DataContract]
    public class AuthenticationData : UniqueObjectGuid<AuthenticationData>
    {
        public Employee Employee {
            get;
            set;
        }
    }
}

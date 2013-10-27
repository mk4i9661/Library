using System.Runtime.Serialization;
using Library.DataContracts.Abstract;

namespace Library.DataContracts.Concrete
{
    [DataContract]
    public class Employee : UniqueObjectInt<Employee>
    {
        [DataMember]
        public string Name {
            get;
            set;
        }

        public string Password {
            get;
            set;
        }

        [DataMember]
        public Role Role {
            get;
            set;
        }
    }
}

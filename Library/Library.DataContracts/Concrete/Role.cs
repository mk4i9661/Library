using System.Runtime.Serialization;
using Library.DataContracts.Abstract;

namespace Library.DataContracts.Concrete
{
    [DataContract]
    public class Role : UniqueObjectInt<Role>
    {

        [DataMember]
        public string Name {
            get;
            set;
        }
    }
}

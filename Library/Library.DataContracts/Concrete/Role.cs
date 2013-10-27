using System.Runtime.Serialization;
using Library.DataContracts.Abstract;
using System;

namespace Library.DataContracts.Concrete
{
    [DataContract]
    public class Role : UniqueObject<RoleId, Role>
    {

        [DataMember]
        public string Name {
            get;
            set;
        }

        public override int CompareTo(Role other) {
            return Id - other.Id;
        }

        public override bool Equals(Role other) {
            return Id == other.Id;
        }

        public override int Compare(Role x, Role y) {
            return x.Id - y.Id;
        }
    }

    [Flags]
    public enum RoleId
    {
        Undefined = 0,
        Bibliographer = 1,
        Operator = 2,
        Chief = 4,
        Admin = Bibliographer | Operator | Chief
    }
}

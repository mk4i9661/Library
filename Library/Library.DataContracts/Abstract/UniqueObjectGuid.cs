using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataContracts.Abstract
{
    [DataContract]
    public abstract class UniqueObjectGuid<T> : UniqueObject<Guid, T> where T : UniqueObject<Guid, T>
    {
        public override int CompareTo(T other) {
            return Id.CompareTo(other);
        }

        public override bool Equals(T other) {
            return Id.Equals(other.Id);
        }

        public override int Compare(T x, T y) {
            return x.CompareTo(y);
        }
    }
}

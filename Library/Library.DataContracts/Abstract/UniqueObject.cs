using System.Runtime.Serialization;

namespace Library.DataContracts.Abstract
{
    [DataContract]
    public abstract class UniqueObject<T, V> : IUniqueObject<T, V>
    {
        protected UniqueObject() {

        }

        protected UniqueObject(T id) {
            Id = id;
        }

        [DataMember]
        public T Id {
            get;
            set;
        }

        public abstract int CompareTo(V other);

        public abstract bool Equals(V other);

        public abstract int Compare(V x, V y);
    }
}

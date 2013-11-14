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
    public abstract class UniqueObjectRequest<TObject> : UniqueObject<Request, TObject> where TObject : UniqueObjectRequest<TObject>
    {
        public override int CompareTo(TObject other) {
            return Id.CompareTo(other.Id);
        }

        public override bool Equals(TObject other) {
            return Id.Equals(other.Id);
        }

        public override int Compare(TObject x, TObject y) {
            return x.CompareTo(y);
        }
    }
}

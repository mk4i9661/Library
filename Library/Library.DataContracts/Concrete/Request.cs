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
    public class Request : UniqueObject<RequestHeader, Request>
    {
        [DataMember]
        public Book Book {
            get;
            set;
        }

        [DataMember]
        public int BookQuantity {
            get;
            set;
        }

        public override int CompareTo(Request other) {
            var id = Id.CompareTo(other.Id);
            return id == 0 ? Book.CompareTo(other.Book) : id;
        }

        public override bool Equals(Request other) {
            return Id.Equals(other.Id) && Book.Equals(other.Book);
        }

        public override int Compare(Request x, Request y) {
            return x.CompareTo(y);
        }
    }
}

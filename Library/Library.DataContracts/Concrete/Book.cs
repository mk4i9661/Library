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
    [KnownType(typeof(ReportBook))]
    public class Book : UniqueObjectInt<Book>
    {
        [DataMember]
        public string Name {
            get;
            set;
        }

        [DataMember]
        public DateTime ImprintDate {
            get;
            set;
        }

        [DataMember]
        public int PageQuantity {
            get;
            set;
        }

        [DataMember]
        public string Annotation {
            get;
            set;
        }

        [DataMember]
        public int BookQuantity {
            get;
            set;
        }

        [DataMember]
        public Rubric Rubric {
            get;
            set;
        }

        [DataMember]
        public Publisher Publisher {
            get;
            set;
        }

        [DataMember]
        public bool HasAuthors {
            get;
            set;
        }

        public override string ToString() {
            return Name;
        }
    }
}

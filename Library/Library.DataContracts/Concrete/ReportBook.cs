using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataContracts.Concrete
{
    [DataContract]
    public class ReportBook : Book, IEquatable<ReportBook>
    {
        [DataMember]
        public int DelayedBookQuantity {
            get;
            set;
        }

        [DataMember]
        public int TakenBookQuantity {
            get;
            set;
        }

        public int BookQuantitySummary {
            get {
                return BookQuantity + TakenBookQuantity;
            }
        }

        public bool Equals(ReportBook other) {
            return base.Equals(other);
        }
    }
}

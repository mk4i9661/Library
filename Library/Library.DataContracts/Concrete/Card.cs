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
    public class Card : UniqueObjectInt<Card>
    {
        [DataMember]
        public Reader Reader {
            get;
            set;
        }

        [DataMember]
        public DateTime IssueDate {
            get;
            set;
        }

        [DataMember]
        public DateTime ExpiryDate {
            get;
            set;
        }

        public override string ToString() {
            return Id.ToString();
        }
    }
}

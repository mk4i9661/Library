using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Library.DataContracts.Abstract;

namespace Library.DataContracts.Concrete
{
    [DataContract]
    public class Publisher : UniqueObjectInt<Publisher>
    {
        [DataMember]
        public string Name {
            get;
            set;
        }

        [DataMember]
        public string Location {
            get;
            set;
        }

        [DataMember]
        public string Description {
            get;
            set;
        }
    }
}

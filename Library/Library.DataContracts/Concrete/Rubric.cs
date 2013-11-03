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
    public class Rubric : UniqueObjectInt<Rubric>
    {
        [DataMember]
        public Rubric Parent {
            get;
            set;
        }

        [DataMember]
        public string Name {
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

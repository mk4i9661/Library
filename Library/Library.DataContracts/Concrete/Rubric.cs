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

        [DataMember]
        public List<Rubric> Childs {
            get;
            set;
        }

        static IEnumerable<Rubric> FormTree(Rubric root, IEnumerable<Rubric> rubrics) {
            var childs = rubrics.Where(r => r.Parent.Id == root.Id).ToArray();

            foreach (var child in childs) {
                child.Parent = root;
                child.Childs = FormTree(child, rubrics).ToList();
            }

            return childs;
        }

        public static IEnumerable<Rubric> FormTree(IEnumerable<Rubric> source) {
            var roots = source.Where(s => s.Parent == null);
            var childs = source.Where(s => s.Parent != null).ToArray();

            foreach (var root in roots) {
                root.Childs = FormTree(root, childs).ToList();
            }
            return roots;
        }

        public override string ToString() {
            return Name;
        }

        public static bool IsChildOf(IEnumerable<Rubric> source, Rubric target, Rubric level) {
            if (target.Parent == null) {
                return false;
            }
            if (target.Id == target.Parent.Id) {
                return true;
            }
            if (level != null && target.Parent.Id == level.Id) {
                return true;
            }

            var childs = source.Where(r => r.Parent != null && r.Parent.Id == level.Id).ToArray();
            if (childs.Length == 0) {
                return false;
            }
            return (from c in childs
                    where IsChildOf(source, target, c)
                    select c).Count() != 0;
        }
    }
}

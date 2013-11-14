using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataContracts.Abstract;
using Library.DataContracts.Concrete;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    class UniqueObjectRequest<TObject> : UniqueObject<Request, TObject>
    {
        public override int CompareTo(TObject other) {
            throw new NotImplementedException();
        }

        public override bool Equals(TObject other) {
            throw new NotImplementedException();
        }

        public override int Compare(TObject x, TObject y) {
            throw new NotImplementedException();
        }
    }
}

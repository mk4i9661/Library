using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.DBInterop.Accessors.Abstract
{
    public abstract class AbstractAccessor
    {

        public ConnectionProvider ConnectionProvider {
            get;
            protected set;
        }

        protected AbstractAccessor(ConnectionProvider provider) {
            ConnectionProvider = provider;
        }


    }

    public abstract class AbstractAccessor<T> : AbstractAccessor
    {
        protected AbstractAccessor(ConnectionProvider provider)
            : base(provider) {

        }

        public abstract void Insert(T data);

        public abstract void Update(T data);

        public abstract void Delete(T data);
    }
}

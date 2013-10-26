using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Library.Proxies
{
    public abstract class DisposableProxy<T> : ClientBase<T>, IDisposable
        where T : class
    {

        protected DisposableProxy() {

        }

        public virtual void Dispose() {
            if (State == CommunicationState.Faulted) {
                Abort();
            } else {
                Close();
            }
        }
    }
}

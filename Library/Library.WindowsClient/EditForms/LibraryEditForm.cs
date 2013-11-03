using Library.UI.DevExpressControls.Forms;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.WindowsClient.EditForms
{
    class LibraryEditForm<TContract, T> : TypedEditForm<T> where T : class
    {
        [Inject]
        public IKernel Ninject {
            get;
            set;
        }

        protected TContract GetProxy() {
            return Ninject.Get<TContract>();
        }
    }
}

using Library.Contracts;
using Library.UI.DevExpressControls.Forms;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.WindowsClient
{
    class LibraryForm : BaseForm
    {
        [Inject]
        public IKernel Ninject {
            get;
            set;
        }

        [Inject]
        public IAuthentication AuthenticationProxy {
            get;
            set;
        }

        protected IAuthentication GetAuthenticationProxy() {
            return AuthenticationProxy;
        }
    }
}

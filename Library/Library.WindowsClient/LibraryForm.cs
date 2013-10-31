using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Contracts;
using Library.UI.DevExpressControls.Forms;
using Ninject;

namespace Library.WindowsClient
{
    public partial class LibraryForm : BaseForm
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

        public LibraryForm() {
            InitializeComponent();
        }

        protected IAuthentication GetAuthenticationProxy() {
            return AuthenticationProxy;
        }
    }
}

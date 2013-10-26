using Library.UI.DevExpressControls.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Library.DataContracts.Concrete;

namespace Library.WindowsClient
{
<<<<<<< HEAD
    class MainForm : LibraryForm
    {
        public MainForm() {

=======
    partial class MainForm : LibraryForm
    {
        public MainForm() {
            InitializeComponent();
>>>>>>> origin/developer
        }

        protected override void InitHandlers() {
            base.InitHandlers();
            FormClosing += MainForm_FormClosing;
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.Cancel = !DialogMessages.Question("Вы уверены, что хотите покинуть систему?")) {
                GetAuthenticationProxy().LogOut(Ninject.Get<AuthenticationData>());
            }
        }
<<<<<<< HEAD
=======

        
>>>>>>> origin/developer
    }
}

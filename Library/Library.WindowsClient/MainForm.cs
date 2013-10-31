using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using Library.DataContracts.Concrete;
using Library.UI.DevExpressControls.Forms;
using Library.WindowsClient.Pages.Abstract;
using Library.WindowsClient.Pages.Concrete;
using Ninject;

namespace Library.WindowsClient
{
    partial class MainForm : LibraryForm
    {
        public MainForm() {
            Pages = new List<Page>();
            InitializeComponent();
        }

        List<Page> Pages {
            get;
            set;
        }

        Role Role {
            get {
                return Ninject.Get<AuthenticationData>().Employee.Role;
            }
        }

        bool IsBibliographer {
            get {
                return (Role.Id & RoleId.Bibliographer) != 0;
            }
        }

        bool IsOperator {
            get {
                return (Role.Id & RoleId.Operator) != 0;
            }
        }

        bool IsChief {
            get {
                return (Role.Id & RoleId.Chief) != 0;
            }
        }

        void InitPages() {
            Role role = Role;

            if (IsBibliographer) {
                Pages.AddRange(new Page[] {
                    new PublishersPage(new PageParameters {
                        RibbonPage = rpPublishers,
                        TabPage = xtpPublishers
                    })
                });
            }

            xtcPages.ShowTabHeader = DefaultBoolean.False;
            xtcPages.TabPages.Clear();
            rcPages.Pages.Clear();

            foreach (var page in Pages) {
                rcPages.Pages.Add(page.RibbonPage);
                xtcPages.TabPages.Add(page.TabPage);
            }
        }

        protected override void OnLoad(EventArgs e) {
            InitPages();
        }

        protected override void InitHandlers() {
            base.InitHandlers();
            FormClosing += MainForm_FormClosing;
            rcPages.SelectedPageChanged += rcPages_SelectedPageChanged;
            rcPages.SelectedPageChanging += rcPages_SelectedPageChanging;
        }

        void rcPages_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e) {
            var page = rcPages.SelectedPage.Tag as Page;
        }

        void rcPages_SelectedPageChanged(object sender, EventArgs e) {
            //var page = rcPages.SelectedPage.Tag as Page;
            //page.Activate();
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (!(e.Cancel = !DialogMessages.Question("Вы уверены, что хотите покинуть систему?"))) {
                GetAuthenticationProxy().LogOut(Ninject.Get<AuthenticationData>());
            }
        }

        protected Task<T> AsyncLoadData<T>(Func<T> loader) {
            return Task.Factory.StartNew(loader);
        }

        public async void LoadData<T>(Func<T> loader) {
            OnBeginDataLoad();
            //var result = await AsyncLoadData(loader).Result;
            OnEndDataLoad();
        }

        protected void OnBeginDataLoad() {
        }

        protected void OnEndDataLoad() {
        }
    }
}
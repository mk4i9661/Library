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
using System.Linq;
using System.Monads;
using Ninject.Parameters;

namespace Library.WindowsClient
{
    partial class MainForm : LibraryForm
    {
        public MainForm(IKernel ninject) {
            Ninject = ninject;
            Pages = new List<IPage>();
            InitializeComponent();
            InitHandlers();
            InitPages();
        }

        List<IPage> Pages {
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

        public IPage SelectedPage {
            get;
            private set;
        }

        void InitPages() {
            if (IsBibliographer) {
                Ninject.Bind<PublishersPage>().ToMethod(method => new PublishersPage(new PageParameters() {
                    RibbonPage = rpPublishers,
                    TabPage = xtpPublishers,
                    GridControl = gcPublishers
                }));
                Ninject.Bind<RubricsPage>().ToMethod(method => new RubricsPage(new PageParameters() {
                    RibbonPage = rpRubrics,
                    TabPage = xtpRubrics,
                    GridControl = gcRubrics
                }));
                Ninject.Bind<BookPage>().ToMethod(method => new BookPage(new BookPage.BookPageParameters() {
                    RibbonPage = rpBooks,
                    TabPage = xtpBooks,
                    GridControl = gcBooks,
                    RubricItem = beiRubric,
                    PublisherItem = beiPublisher,
                    SearchItem = beiSearch,
                    AuthorsButton = bbiAuthors
                }));

                Ninject.Bind<AuthorPage>().ToMethod(method => new AuthorPage(new PageParameters()
                {
                    RibbonPage = rpAuthors,
                    TabPage = xtpAuthors,
                    GridControl = gcAuthors,
                }));

                Pages.AddRange(new IPage[] {
                    Ninject.Get<PublishersPage>(),
                    Ninject.Get<RubricsPage>(),
                    Ninject.Get<BookPage>(),
                    Ninject.Get<AuthorPage>(),
                });
            }
            if (IsOperator) {
                Ninject.Bind<RequestPage>().ToMethod(method => new RequestPage(new RequestPage.RequestPageParameters() {
                    RibbonPage = rpRequests,
                    TabPage = xtpRequests,
                    GridControl = gcRequests,
                    RenewItem = bbiRenewal,
                    ReturnItem = bbiReturn,
                    SendNotificationsItem = bbiSendNotifications,
                    GridViewApprovedRequests = gvApprovedRequests,
                    GridViewRejectedRequests = gvRejectedRequests,
                    CardItem = beiCard,
                    SearchItem = beiSearch
                }));

                Ninject.Bind<ReaderPage>().ToMethod(method => new ReaderPage(new PageParameters()
                {
                    RibbonPage = rpReaders,
                    TabPage = xtpReaders,
                    GridControl = gcReaders,
                }));

                Ninject.Bind<CardPage>().ToMethod(method => new CardPage(new PageParameters()
                {
                    RibbonPage = rpCards,
                    TabPage = xtpCards,
                    GridControl = gcCards,
                }));


                Pages.AddRange(new IPage[] {
                    Ninject.Get<RequestPage>(),
                    Ninject.Get<ReaderPage>(),
                    Ninject.Get<CardPage>()
                });
            }
            if (IsChief) {
                Ninject.Bind<ReportBookPage>().ToMethod(method => new ReportBookPage(new ReportBookPage.ReportBookPageParameters() {
                    RibbonPage = rpReportBooks,
                    TabPage = xtpReportBooks,
                    GridControl = gcReportBooks,
                    PublisherItem = beiPublisher,
                    RubricItem = beiRubric,
                    SearchItem = beiSearch,
                    ObligatorsItem = bciObligors
                }));

                Pages.AddRange(new IPage[] {
                    Ninject.Get<ReportBookPage>()
                });
            }

            xtcPages.ShowTabHeader = DefaultBoolean.False;
            xtcPages.TabPages.Clear();
            rcPages.Pages.Clear();

            foreach (var page in Pages) {
                xtcPages.TabPages.Add(page.TabPage);
                rcPages.Pages.Add(page.RibbonPage);
            }

            SelectedPage = Pages.FirstOrDefault().Do(a => a.Activate());
        }

        void InitHandlers() {
            FormClosing += MainForm_FormClosing;
            rcPages.SelectedPageChanging += rcPages_SelectedPageChanging;
            bbiAdd.ItemClick += bbiAdd_ItemClick;
            bbiEdit.ItemClick += bbiEdit_ItemClick;
            bbiDelete.ItemClick += bbiDelete_ItemClick;
            bbiReload.ItemClick += bbiReload_ItemClick;
        }

        void bbiReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            SelectedPage.Do(page => page.ReloadClick());
        }

        void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            SelectedPage.Do(page => page.DeleteClick());
        }

        void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            SelectedPage.Do(page => page.EditClick());
        }

        void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            SelectedPage.Do(page => page.AddClick());
        }

        void rcPages_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e) {
            var page = e.Page.With(p => p.Tag as IPage);
            xtcPages.SelectedTabPage = page.With(p => p.TabPage);

            SelectedPage.Do(p => p.Deactivate());
            SelectedPage = page.Do(p => p.Activate());
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (!(e.Cancel = !DialogMessages.Question("Вы уверены, что хотите покинуть систему?"))) {
                GetAuthenticationProxy().LogOut(Ninject.Get<AuthenticationData>());
            }
        }

        private void rcPages_Click(object sender, EventArgs e)
        {

        }
    }
}
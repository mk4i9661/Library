using DevExpress.XtraBars;
using Library.Contracts;
using Library.DataContracts.Concrete;
using Library.UI.DevExpressControls.Controls;
using Library.WindowsClient.Pages.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Monads;
using Library.UI.DevExpressControls.Forms;

namespace Library.WindowsClient.Pages.Concrete
{
    class ReportBookPage : Page<IChief, ReportBookPage.LoadNecessaryData, ReportBook>
    {
        IEnumerable<Publisher> Publishers {
            get;
            set;
        }

        IEnumerable<Rubric> Rubrics {
            get;
            set;
        }

        LibraryRibbonTextEdit SearchItem {
            get;
            set;
        }

        LibraryRibbonComboBox PublisherItem {
            get;
            set;
        }

        LibraryRibbonComboBox RubricItem {
            get;
            set;
        }

        BarCheckItem ObligatorsItem {
            get;
            set;
        }

        public ReportBookPage(ReportBookPageParameters parameters)
            : base(parameters) {
            Publishers = new List<Publisher>();
            Rubrics = new List<Rubric>();
            SearchItem = new LibraryRibbonTextEdit(parameters.SearchItem);
            PublisherItem = new LibraryRibbonComboBox(parameters.PublisherItem);
            RubricItem = new LibraryRibbonComboBox(parameters.RubricItem);
            ObligatorsItem = parameters.ObligatorsItem;

            GridControl.GridView.OptionsDetail.AllowExpandEmptyDetails = true;

            InitHandlers();
        }

        void InitHandlers() {
            SearchItem.KeyDown += SearchItem_KeyDown;
            PublisherItem.EditValueChanged += PublisherItem_EditValueChanged;
            RubricItem.EditValueChanged += RubricItem_EditValueChanged;
            ObligatorsItem.ItemClick += ObligatorsItem_ItemClick;
            GridControl.GridView.MasterRowGetRelationCount += GridView_MasterRowGetRelationCount;
            GridControl.GridView.MasterRowGetChildList += GridView_MasterRowGetChildList;
            GridControl.GridView.MasterRowGetRelationName += GridView_MasterRowGetRelationName;
            GridControl.GridView.MasterRowEmpty += GridView_MasterRowEmpty;
            GridControl.GridView.MasterRowExpanding += GridView_MasterRowExpanding;
        }

        void ObligatorsItem_ItemClick(object sender, ItemClickEventArgs e) {
            GridControl.GridView.BeginDataUpdate();
            GridControl.GridView.CollapseAllDetails();
            GridControl.GridView.EndDataUpdate();
        }

        async void GridView_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            var book = GetRow(e.RowHandle);
            if (book != null) {
                try {
                    var readers = new List<Reader>();
                    e.ChildList = readers;
                    readers.AddRange(IncludeObligators ? await GetBookObligators(book) : await GetBookHolders(book));
                    var view = GridControl.GridView.GetDetailView(e.RowHandle, 0);
                    view.BeginDataUpdate();
                    view.EndDataUpdate();
                } catch (Exception exc) {
                    DialogMessages.Error(exc.Message);
                }
            }
        }

        Task<IEnumerable<Reader>> GetBookHolders(Book book) {
            return Task.Factory.StartNew(() => GetProxy().GetBookHolders(book));
        }

        Task<IEnumerable<Reader>> GetBookObligators(Book book) {
            return Task.Factory.StartNew(() => GetProxy().GetBookObligators(book));
        }

        void GridView_MasterRowExpanding(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs e) {
            var row = GetRow(e.RowHandle);
            if (row != null) {
                if (IncludeObligators) {
                    e.Allow = row.DelayedBookQuantity != 0;
                } else {
                    e.Allow = row.TakenBookQuantity != 0;
                }
            } else {
                e.Allow = false;
            }
        }

        void GridView_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 1;
        }

        void GridView_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            e.RelationName = "Readers";
        }

        void GridView_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e) {
            var row = GetRow(e.RowHandle);
            e.IsEmpty = row == null || row.TakenBookQuantity == 0 || IncludeObligators && (row.DelayedBookQuantity == 0);
        }

        void SearchItem_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                OnLoadData();
            }
        }

        void RubricItem_EditValueChanged(object sender, EventArgs e) {
            OnLoadData();
        }

        void PublisherItem_EditValueChanged(object sender, EventArgs e) {
            OnLoadData();
        }

        protected override ReportBookPage.LoadNecessaryData LoadNecessaryDataOperation() {
            var proxy = GetProxy();
            var publishers = Task.Factory.StartNew(() => proxy.GetPublishers());
            var rubrics = Task.Factory.StartNew(() => proxy.GetRubrics());
            Task.WaitAll(publishers, rubrics);
            return new LoadNecessaryData() {
                Publishers = publishers.Result,
                Rubrics = rubrics.Result
            };
        }

        protected override void OnEndLoadNecessaryData(ReportBookPage.LoadNecessaryData result) {
            base.OnEndLoadNecessaryData(result);

            Rubrics = result.Rubrics;
            Publishers = result.Publishers;

            var rubrics = result.Rubrics.ToList();
            rubrics.Insert(0, new Rubric() {
                Id = -1,
                Name = "Все"
            });
            var publishers = result.Publishers.ToList();
            publishers.Insert(0, new Publisher() {
                Id = -1,
                Name = "Все"
            });

            RubricItem.Bind(rubrics, r => r.Name, Rubric);
            PublisherItem.Bind(publishers, p => p.Name, Publisher);
        }

        protected override IEnumerable<ReportBook> LoadDataOperation() {
            return GetProxy().GetBooks(Rubric, Publisher, Search);
        }

        Rubric Rubric {
            get {
                return RubricItem.GetSelectedElement<Rubric>().IfNot(r => r.Id == -1);
            }
        }

        Publisher Publisher {
            get {
                return PublisherItem.GetSelectedElement<Publisher>().IfNot(p => p.Id == -1);
            }
        }

        string Search {
            get {
                return SearchItem.Text.Trim().ToLower();
            }
        }

        bool IncludeObligators {
            get {
                return ObligatorsItem.Checked;
            }
        }

        internal class LoadNecessaryData
        {
            public IEnumerable<Publisher> Publishers {
                get;
                set;
            }

            public IEnumerable<Rubric> Rubrics {
                get;
                set;
            }
        }

        internal class ReportBookPageParameters : PageParameters
        {
            public BarEditItem SearchItem {
                get;
                set;
            }

            public BarEditItem PublisherItem {
                get;
                set;
            }

            public BarEditItem RubricItem {
                get;
                set;
            }

            public BarCheckItem ObligatorsItem {
                get;
                set;
            }
        }
    }
}

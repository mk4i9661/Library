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

        public ReportBookPage(ReportBookPageParameters parameters)
            : base(parameters) {
            Publishers = new List<Publisher>();
            Rubrics = new List<Rubric>();
            SearchItem = new LibraryRibbonTextEdit(parameters.SearchItem);
            PublisherItem = new LibraryRibbonComboBox(parameters.PublisherItem);
            RubricItem = new LibraryRibbonComboBox(parameters.RubricItem);

            SearchItem.KeyDown += SearchItem_KeyDown;
            PublisherItem.EditValueChanged += PublisherItem_EditValueChanged;
            RubricItem.EditValueChanged += RubricItem_EditValueChanged;
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
        }
    }
}

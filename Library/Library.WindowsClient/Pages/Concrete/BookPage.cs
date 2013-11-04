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
using System.Monads;
using Library.UI.DevExpressControls.Forms;
using Library.WindowsClient.EditForms;
using Ninject;

namespace Library.WindowsClient.Pages.Concrete
{
    class BookPage : Page<IBibliographer, BookPage.LoadNecessaryData, Book>
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

        public BookPage(BookPageParameters parameters)
            : base(parameters) {
            Publishers = new List<Publisher>();
            Rubrics = new List<Rubric>();
            SearchItem = new LibraryRibbonTextEdit(parameters.SearchItem);
            PublisherItem = new LibraryRibbonComboBox(parameters.PublisherItem);
            RubricItem = new LibraryRibbonComboBox(parameters.RubricItem);
        }

        protected override BookPage.LoadNecessaryData LoadNecessaryDataOperation() {
            var proxy = GetProxy();
            return new LoadNecessaryData() {
                Publishers = proxy.GetPublishers(),
                Rubrics = proxy.GetRubrics()
            };
        }

        public override void Activate() {
            base.Activate();
            Ninject.Rebind<BookEditForm>().ToMethod(method => new BookEditForm(Rubrics, Publishers));
        }

        protected override void OnEndLoadNecessaryData(BookPage.LoadNecessaryData result) {
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

        protected override IEnumerable<Book> LoadDataOperation() {
            return GetProxy().GetBooks(Rubric, Publisher, Search);
        }

        protected override Book CreateDefaultRow() {
            return new Book() {
                Publisher = Publisher,
                Rubric = Rubric
            };
        }

        protected override TypedEditForm<Book> CreateEditForm() {
            return Ninject.Get<BookEditForm>();
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

        internal class BookPageParameters : PageParameters
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

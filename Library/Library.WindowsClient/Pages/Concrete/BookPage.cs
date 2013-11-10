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
using System.Windows.Forms;

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

            SearchItem.KeyDown += SearchItem_KeyDown;
            PublisherItem.EditValueChanged += PublisherItem_EditValueChanged;
            RubricItem.EditValueChanged += RubricItem_EditValueChanged;
            parameters.AuthorsButton.ItemClick += AuthorsButton_ItemClick;
        }

        void AuthorsButton_ItemClick(object sender, ItemClickEventArgs e) {
            GetSelectedRow().Do(LoadAuthors);
        }

        void OnEndLoadAuthors(Book book, IEnumerable<Author> bookAuthors, IEnumerable<Author> authors) {
            Ninject.Rebind<BookAuthorEditForm>().ToMethod(method => {
                return new BookAuthorEditForm(book, authors) {
                    Data = bookAuthors,
                    Operation = EditFormOperation.Insert
                };
            });
            using (var form = Ninject.Get<BookAuthorEditForm>()) {
                form.ShowDialog();
            }
        }

        Task<IEnumerable<Author>> GetAuthors(Book book) {
            return Task.Factory.StartNew(() => GetProxy().GetBookAuthors(book));
        }

        Task<IEnumerable<Author>> GetAuthors() {
            return Task.Factory.StartNew(() => GetProxy().GetAuthors());
        }

        void LoadAuthors(Book book) {
            var bookAuthors = GetAuthors(book);
            var authors = GetAuthors();
            Task.WaitAll(bookAuthors, authors);
            OnEndLoadAuthors(book, bookAuthors.Result, authors.Result);
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
                Rubric = Rubric,
                PageQuantity = 1,
                ImprintDate = DateTime.Now
            };
        }

        protected override TypedEditForm<Book> CreateEditForm() {
            return Ninject.Get<BookEditForm>();
        }

        protected override Book DeleteOperation(Book data) {
            return GetProxy().DeleteBook(data);
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

            public BarButtonItem AuthorsButton {
                get;
                set;
            }
        }
    }
}

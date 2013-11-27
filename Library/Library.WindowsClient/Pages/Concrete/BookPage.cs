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

        IEnumerable<Author> Authors
        {
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

        LibraryRibbonComboBox AuthorItem
        {
            get;
            set;
        }

        public BookPage(BookPageParameters parameters)
            : base(parameters) {
            Publishers = new List<Publisher>();
            Rubrics = new List<Rubric>();
            Authors = new List<Author>();
            SearchItem = new LibraryRibbonTextEdit(parameters.SearchItem);
            PublisherItem = new LibraryRibbonComboBox(parameters.PublisherItem);
            RubricItem = new LibraryRibbonComboBox(parameters.RubricItem);
            AuthorItem = new LibraryRibbonComboBox(parameters.AuthorItem);

            SearchItem.KeyDown += SearchItem_KeyDown;
            PublisherItem.EditValueChanged += PublisherItem_EditValueChanged;
            RubricItem.EditValueChanged += RubricItem_EditValueChanged;
            AuthorItem.EditValueChanged += AuthorItem_EditValueChanged;
            parameters.AuthorsButton.ItemClick += AuthorsButton_ItemClick;
            GridControl.GridView.MasterRowGetRelationCount += GridView_MasterRowGetRelationCount;
            GridControl.GridView.MasterRowGetRelationName += GridView_MasterRowGetRelationName;
            GridControl.GridView.MasterRowEmpty += GridView_MasterRowEmpty;
            GridControl.GridView.MasterRowExpanding += GridView_MasterRowExpanding;
            GridControl.GridView.MasterRowGetChildList += GridView_MasterRowGetChildList;
            GridControl.GridView.OptionsDetail.AllowExpandEmptyDetails = true;
        }

        async void GridView_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            var book = GetRow(e.RowHandle);
            if (book != null)
            {
                try
                {
                    var authors = new List<Author>();
                    e.ChildList = authors;
                    authors.AddRange(await GetBookAuthors(book));
                    var view = GridControl.GridView.GetDetailView(e.RowHandle, 0);
                    view.BeginDataUpdate();
                    view.EndDataUpdate();
                }
                catch (Exception exc)
                {
                    DialogMessages.Error(exc.Message);
                }
            }
        }

        Task<IEnumerable<Author>> GetBookAuthors(Book book)
        {
            return Task.Factory.StartNew(() => GetProxy().GetBookAuthors(book));
        }

        void GridView_MasterRowExpanding(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs e)
        {
            var book = GetRow(e.RowHandle);
            e.Allow = book != null && book.HasAuthors;
        }

        void GridView_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            var book = GetRow(e.RowHandle);
            e.IsEmpty = book == null || !book.HasAuthors;
        }

        void GridView_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Authors";
        }

        void GridView_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        void AuthorItem_EditValueChanged(object sender, EventArgs e)
        {
            OnLoadData();
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
            var publishers = Task.Factory.StartNew(() => proxy.GetPublishers());
            var rubrics = Task.Factory.StartNew(() => proxy.GetRubrics());
            var authors = Task.Factory.StartNew(() => proxy.GetAuthors());
            Task.WaitAll(publishers, rubrics, authors);
            return new LoadNecessaryData() {
                Publishers = publishers.Result,
                Rubrics = rubrics.Result,
                Authors = authors.Result
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
            Authors = result.Authors;

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

            var authors = result.Authors.ToList();
            authors.Insert(0, new Author()
            {
                Id = -1,
                FirstName = "Все",
                LastName = "",
                MiddleName = ""
            });

            RubricItem.Bind(rubrics, r => r.Name, Rubric);
            PublisherItem.Bind(publishers, p => p.Name, Publisher);
            AuthorItem.Bind(authors, a => string.Format("{0} {1} {2}", a.LastName, a.FirstName, a.MiddleName), Author);
        }

        protected override IEnumerable<Book> LoadDataOperation() {
            return GetProxy().GetBooks(Rubric, Publisher, Author, Search);
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

        Author Author {
            get
            {
                return AuthorItem.GetSelectedElement<Author>().IfNot(p => p.Id == -1);
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

            public IEnumerable<Author> Authors
            {
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

            public BarEditItem AuthorItem
            {
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

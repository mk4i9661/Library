using Library.Contracts;
using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Monads;
using Ninject;
using Library.UI.DevExpressControls.Controls;
using Library.UI.DevExpressControls.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace Library.WindowsClient.EditForms
{
    partial class RequestEditForm : RequestEditFormMock
    {
        IEnumerable<Reader> Readers {
            get;
            set;
        }

        List<Book> AllBooks {
            get;
            set;
        }

        List<Request> Requests {
            get;
            set;
        }

        public RequestEditForm(IEnumerable<Reader> readers, IEnumerable<Book> books) {
            Readers = readers;
            AllBooks = books.ToList();
            Requests = new List<Request>();

            InitializeComponent();
            InitHandlers();
            gvBooks.OptionsDetail.AllowExpandEmptyDetails = true;
        }

        void InitHandlers() {
            bAdd.Click += bAdd_Click;
            bRemove.Click += bRemove_Click;
            teFilter.TextChanged += teFilter_TextChanged;
            gvBooks.MasterRowGetRelationCount += gvBooks_MasterRowGetRelationCount;
            gvBooks.MasterRowGetChildList += gvBooks_MasterRowGetChildList;
            gvBooks.MasterRowGetRelationName += gvBooks_MasterRowGetRelationName;
            gvBooks.MasterRowEmpty += gvBooks_MasterRowEmpty;
            gvBooks.MasterRowExpanding += gvBooks_MasterRowExpanding;
        }

        void gvBooks_MasterRowExpanding(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs e) {
            var row = GetBook(e.RowHandle);
            e.Allow = row != null && row.HasAuthors;
        }

        void gvBooks_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e) {
            var row = GetBook(e.RowHandle);
            e.IsEmpty = row == null || !row.HasAuthors;
        }

        void gvBooks_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            e.RelationName = "Authors";
        }

        async void gvBooks_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            var book = GetBook(e.RowHandle);
            if (book != null) {
                try {
                    var authors = new List<Author>();
                    e.ChildList = authors;
                    authors.AddRange(await GetBookAuthors(book));
                    var view = gvBooks.GetDetailView(e.RowHandle, 0);
                    view.BeginDataUpdate();
                    view.EndDataUpdate();
                } catch (Exception exc) {
                    DialogMessages.Error(exc.Message);
                }
            }
        }

        void gvBooks_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 1;
        }

        protected override void OnInitFormFields(RequestHeader data) {
            cbReader.Bind(Readers, r => string.Format("{0} {1} {2} ({3})", r.LastName, r.FirstName, r.MiddleName, r.Card.Id), data.Reader);
            FilterBooks();
        }

        void teFilter_TextChanged(object sender, EventArgs e) {
            FilterBooks();
        }

        void FilterBooks() {
            gcBooks.Bind(GetFilteredBooks(FilterText));
        }

        IEnumerable<Book> GetFilteredBooks(string filter) {
            return string.IsNullOrEmpty(filter) ? AllBooks : AllBooks.Where(b => b.Name.ToLower().Contains(filter));
        }

        Task<IEnumerable<Author>> GetBookAuthors(Book book) {
            return Task.Factory.StartNew(() => GetProxy().GetBookAuthors(book));
        }

        void bRemove_Click(object sender, EventArgs e) {
            var request = gvResult.GetSelectedRow<Request>();
            request.Do(r => {
                AllBooks.Add(r.Book);
                AllBooks = AllBooks.OrderBy(b => b.Name).ToList();
                gcBooks.Bind(AllBooks);
                RemoveRequest(r);
            });
        }

        void bAdd_Click(object sender, EventArgs e) {
            var book = GetSelectedBook();
            book.Do(b => {
                AllBooks.Remove(b);
                AddRequest(b);
            });
            AllBooks = AllBooks.OrderBy(b => b.Name).ToList();
            gcBooks.Bind(AllBooks);
        }

        Book GetSelectedBook() {
            return gvBooks.GetSelectedRow<Book>();
        }

        Book GetBook(int handle) {
            return gvBooks.GetRow<Book>(handle);
        }

        void AddRequest(Book book) {
            var quantity = 1;
            using (var form = Ninject.Get<BookQuantityInputDialog>()) {
                if (form.ShowDialog() != DialogResult.OK) {
                    return;
                }
                quantity = form.BookQuantity;
            }

            if (!Requests.Any(r => r.Book.Id == book.Id)) {
                Requests.Add(new Request() {
                    Id = new RequestHeader() {
                        Id = -1
                    },
                    Book = book,
                    BookQuantity = quantity
                });
                Requests = Requests.OrderBy(r => r.Book.Name).ToList();
                gcResult.Bind(Requests);
            }
        }

        void RemoveRequest(Request request) {
            Requests.Remove(request);
            Requests = Requests.OrderBy(r => r.Book.Name).ToList();
            gcResult.Bind(Requests);
        }

        protected override RequestHeader InsertOperation(RequestHeader data) {
            return GetProxy().CreateRequest(Reader, Requests);
        }

        protected override void OnValidateFormFields() {
            ValidateControl(cbReader, Reader == null, "Читатель должен быть выбран");
        }

        string FilterText {
            get {
                return teFilter.Text.Trim().ToLower();
            }
        }

        Reader Reader {
            get {
                return cbReader.GetSelectedElement<Reader>();
            }
        }
    }

    class RequestEditFormMock : LibraryEditForm<IOperator, RequestHeader>
    {

    }
}

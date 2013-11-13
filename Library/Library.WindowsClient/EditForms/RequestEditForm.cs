﻿using Library.Contracts;
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
        IEnumerable<Card> Cards {
            get;
            set;
        }

        IEnumerable<BookWrap> Books {
            get;
            set;
        }

        List<Request> Requests {
            get;
            set;
        }

        public RequestEditForm(IEnumerable<Card> cards, IEnumerable<Book> books) {
            Cards = cards;
            Books = (from b in books
                     select new BookWrap(b)).ToList();
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
            e.Allow = row != null && row.Book.HasAuthors;
        }

        void gvBooks_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e) {
            var row = GetBook(e.RowHandle);
            e.IsEmpty = row == null || !row.Book.HasAuthors;
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
                    authors.AddRange(await GetBookAuthors(book.Book));
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
            cbCard.Bind(Cards, c => string.Format("{0} ({1} {2} {3})", c.Id, c.Reader.LastName, c.Reader.FirstName, c.Reader.MiddleName), data.Card);
            FilterBooks();
        }

        void teFilter_TextChanged(object sender, EventArgs e) {
            FilterBooks();
        }

        void FilterBooks() {
            gcBooks.Bind(GetFilteredBooks(FilterText));
        }

        IEnumerable<BookWrap> GetFilteredBooks(string filter) {
            return string.IsNullOrEmpty(filter) ? Books : Books.Where(b => b.Name.ToLower().Contains(filter));
        }

        Task<IEnumerable<Author>> GetBookAuthors(Book book) {
            return Task.Factory.StartNew(() => GetProxy().GetBookAuthors(book));
        }

        void bRemove_Click(object sender, EventArgs e) {
            var request = gvResult.GetSelectedRow<Request>();
            request.Do(r => {
                RemoveRequest(r);
            });
        }

        void bAdd_Click(object sender, EventArgs e) {
            var book = GetSelectedBook();
            gvBooks.BeginDataUpdate();
            book.Do(b => {
                b.Selected = true;
                AddRequest(b.Book);
            });
            gvBooks.EndDataUpdate();
        }

        BookWrap GetSelectedBook() {
            return gvBooks.GetSelectedRow<BookWrap>();
        }

        BookWrap GetBook(int handle) {
            return gvBooks.GetRow<BookWrap>(handle);
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
            gvBooks.BeginDataUpdate();
            Books.FirstOrDefault(w => w.Book.Id == request.Book.Id).Do(w => w.Selected = false);
            gvBooks.EndDataUpdate();
        }

        protected override RequestHeader InsertOperation(RequestHeader data) {
            return GetProxy().CreateRequest(Card, Requests);
        }

        protected override void OnValidateFormFields() {
            ValidateControl(cbCard, Card == null, "Читательский билет должен быть выбран");
        }

        string FilterText {
            get {
                return teFilter.Text.Trim().ToLower();
            }
        }

        Card Card {
            get {
                return cbCard.GetSelectedElement<Card>();
            }
        }

        class BookWrap : IEquatable<BookWrap>
        {
            public Book Book {
                get;
                private set;
            }

            public BookWrap(Book book) {
                Book = book;
            }

            public bool Selected {
                get;
                set;
            }

            public string Name {
                get {
                    return Book.Name;
                }
            }

            public bool Equals(BookWrap other) {
                return Book.Equals(other.Book);
            }
        }
    }

    class RequestEditFormMock : LibraryEditForm<IOperator, RequestHeader>
    {

    }
}
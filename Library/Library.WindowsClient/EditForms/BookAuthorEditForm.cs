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

namespace Library.WindowsClient.EditForms
{
    partial class BookAuthorEditForm : BookAuthorEditFormMock
    {
        Book Book {
            get;
            set;
        }

        IEnumerable<AuthorWrap> Authors {
            get;
            set;
        }

        public BookAuthorEditForm(Book book, IEnumerable<Author> authors) {
            Book = book;
            Authors = (from a in authors
                       select new AuthorWrap(a)).ToList();

            InitializeComponent();
            InitHandlers();

            gvAuthors.OptionsBehavior.Editable = true;
            gvAuthors.OptionsBehavior.ReadOnly = false;
        }

        void InitHandlers() {
            Load += BookAuthorEditForm_Load;
            teFilter.TextChanged += teFilter_TextChanged;
        }

        void teFilter_TextChanged(object sender, EventArgs e) {
            FilterAuthors();
        }

        void BookAuthorEditForm_Load(object sender, EventArgs e) {
            (from d in Data
             join a in Authors on d.Id equals a.Author.Id
             select a).ToList().ForEach(a => a.Selected = true);
            FilterAuthors();
        }

        protected override IEnumerable<Author> InsertOperation(IEnumerable<Author> data) {
            return GetProxy().SetBookAuthors(Book, SelectedAuthors);
        }

        void FilterAuthors() {
            gcAuthors.GridView.BeginDataUpdate();
            gcAuthors.DataSource = GetFilteredData(FilterText);
            gcAuthors.GridView.EndDataUpdate();
        }

        IEnumerable<AuthorWrap> GetFilteredData(string filter) {
            return (string.IsNullOrEmpty(filter) ? Authors : Authors.Where(a => a.Name.ToLower().Contains(filter))).ToArray();
        }

        IEnumerable<Author> SelectedAuthors {
            get {
                return Authors.Where(a => a.Selected).Select(a => a.Author);
            }
        }

        string FilterText {
            get {
                return teFilter.Text.Trim().ToLower();
            }
        }

        class AuthorWrap
        {
            public bool Selected {
                get;
                set;
            }

            public Author Author {
                get;
                private set;
            }

            public AuthorWrap(Author author) {
                Author = author;
            }

            public string Name {
                get {
                    return string.Format("{0} {1} {2}", Author.LastName, Author.FirstName, Author.MiddleName);
                }
            }
        }
    }

    class BookAuthorEditFormMock : LibraryEditForm<IBibliographer, IEnumerable<Author>>
    {

    }
}

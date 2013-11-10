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
    partial class BookEditForm : BookEditFormMock
    {
        IEnumerable<Rubric> Rubrics {
            get;
            set;
        }

        IEnumerable<Publisher> Publishers {
            get;
            set;
        }

        public BookEditForm(IEnumerable<Rubric> rubrics, IEnumerable<Publisher> publishers) {
            Rubrics = rubrics;
            Publishers = publishers;
            InitializeComponent();
        }

        protected override void OnInitFormFields(Book data) {
            cbRubric.Bind(Rubrics, r => r.Name, data.Rubric);
            cbPublisher.Bind(Publishers, p => p.Name, data.Publisher);
            BookName = data.Name;
            ImprintDate = data.ImprintDate;
            PageQuantity = data.PageQuantity;
            BookQuantity = data.BookQuantity;
            Annotation = data.Annotation;
        }

        protected override void OnInitDataFields(Book data) {
            data.Rubric = Rubric;
            data.Publisher = Publisher;
            data.Name = BookName;
            data.ImprintDate = ImprintDate;
            data.PageQuantity = PageQuantity;
            data.BookQuantity = BookQuantity;
            data.Annotation = Annotation;
        }

        protected override void OnValidateFormFields() {
            ValidateControl(cbRubric, Rubric == null, "Рубрика должна быть задана");
            ValidateControl(cbPublisher, Publisher == null, "Издатель должен быть задан");
            ValidateControl(teName, string.IsNullOrEmpty(BookName), "Название книги должно быть задано");
        }

        protected override Book InsertOperation(Book data) {
            return GetProxy().AddBook(data);
        }

        protected override Book UpdateOperation(Book data) {
            return GetProxy().UpdateBook(data);
        }

        Rubric Rubric {
            get {
                return cbRubric.GetSelectedElement<Rubric>();
            }
        }

        Publisher Publisher {
            get {
                return cbPublisher.GetSelectedElement<Publisher>();
            }
        }

        string BookName {
            get {
                return teName.Text.Trim();
            }
            set {
                teName.Text = value;
            }
        }

        DateTime ImprintDate {
            get {
                return new DateTime(Convert.ToInt32(seImprint.Value), 1, 1);
            }
            set {
                seImprint.Value = value.Year;
            }
        }

        int PageQuantity {
            get {
                return Convert.ToInt32(sePageQuantity.Value);
            }
            set {
                sePageQuantity.Value = value;
            }
        }

        int BookQuantity {
            get {
                return Convert.ToInt32(seBookQuantity.Value);
            }
            set {
                seBookQuantity.Value = value;
            }
        }

        string Annotation {
            get {
                return meAnnotation.Text.Trim();
            }
            set {
                meAnnotation.Text = value;
            }
        }
    }

    class BookEditFormMock : LibraryEditForm<IBibliographer, Book>
    {

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Contracts;
using Library.DataContracts.Concrete;

namespace Library.WindowsClient.EditForms
{
    partial class AuthorEditForm : AuthorEditFormMock
    {
        public AuthorEditForm() {
            InitializeComponent();
        }

        protected override void OnInitDataFields(Author data) {
            data.FirstName = FirstName;
            data.LastName = LastName;
            data.MiddleName = MiddleName;
            data.Biography = Biography;
        }

        protected override void OnInitFormFields(Author data) {
            FirstName = data.FirstName;
            MiddleName = data.MiddleName;
            LastName = data.LastName;
            Biography = data.Biography;
        }

        protected override void OnValidateFormFields() {
            ValidateControl(teName, string.IsNullOrEmpty(FirstName), "Имя автора должно быть задано");
            ValidateControl(teMiddleName, string.IsNullOrEmpty(MiddleName), "Отчество автора должно быть задано");
            ValidateControl(teLastName, string.IsNullOrEmpty(LastName), "Фамилия автора должна быть задана");
        }

        protected override Author InsertOperation(Author data) {
            return GetProxy().AddAuthor(data);
        }

        protected override Author UpdateOperation(Author data) {
            return GetProxy().UpdateAuthor(data);
        }

        string FirstName {
            get {
                return teName.Text.Trim();
            }
            set {
                teName.Text = value;
            }
        }

        string MiddleName {
            get {
                return teMiddleName.Text.Trim();
            }
            set {
                teMiddleName.Text = value;
            }
        }

        string LastName {
            get {
                return teLastName.Text.Trim();
            }
            set {
                teLastName.Text = value;
            }
        }

        string Biography {
            get {
                return meBiography.Text.Trim();
            }
            set {
                meBiography.Text = value;
            }
        }
    }

    class AuthorEditFormMock : LibraryEditForm<IBibliographer, Author>
    {
    }
}

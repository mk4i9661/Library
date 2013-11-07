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

        string AuthorName {
            get {
                return teName.Text.Trim();
            }
        }
    }

    class AuthorEditFormMock : LibraryEditForm<IBibliographer, Author>
    {
    }
}

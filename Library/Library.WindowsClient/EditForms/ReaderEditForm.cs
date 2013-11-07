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
    partial class ReaderEditForm : ReaderEditFormMock
    {
        public ReaderEditForm()
        {
            InitializeComponent();
        }
    }

    class ReaderEditFormMock : LibraryEditForm<IOperator, Reader> { 

    }
}

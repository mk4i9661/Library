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
    partial class BookQuantityInputDialog : LibraryForm
    {
        public BookQuantityInputDialog() {
            InitializeComponent();
            bOk.Click += bOk_Click;
            bCancel.Click += bCancel_Click;
        }

        void bCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        void bOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        public int BookQuantity {
            get {
                return Convert.ToInt32(seQuantity.Value);
            }
        }
    }
}

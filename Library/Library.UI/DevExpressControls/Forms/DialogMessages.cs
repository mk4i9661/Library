using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UI.DevExpressControls.Forms
{
    public class DialogMessages
    {
        const string Caption = "Система \"Библиотека\"";

        public static DialogResult Error(string text) {
            return XtraMessageBox.Show(text, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Question(string text) {
            return XtraMessageBox.Show(text, Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UI.DevExpressControls.Controls
{
    public class LibraryMemoEdit : MemoEdit
    {
        public LibraryMemoEdit() {
            Properties.MaxLength = 255;
            Font = new System.Drawing.Font("Tahoma", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
    }
}

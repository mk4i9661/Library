using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace Library.UI.DevExpressControls.Controls
{
    public class LibraryTextEdit : TextEdit
    {
        public LibraryTextEdit() {
            Properties.MaxLength = 255;
            Font = new System.Drawing.Font("Tahoma", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
    }
}

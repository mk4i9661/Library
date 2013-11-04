using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UI.DevExpressControls.Controls
{
    public class LibrarySpinEdit : SpinEdit
    {
        public LibrarySpinEdit() {
            Properties.EditMask = "F0";
            Properties.MinValue = 0;
            Value = 0;
            Properties.MaxValue = 2000000000;
            Font = new System.Drawing.Font("Tahoma", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Properties.IsFloatValue = false;
        }
    }
}

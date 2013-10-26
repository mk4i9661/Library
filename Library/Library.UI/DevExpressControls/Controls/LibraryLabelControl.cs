﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UI.DevExpressControls.Controls
{
    public class LibraryLabelControl : LabelControl
    {
        public LibraryLabelControl() {
            Font = new Font("Tahoma", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
    }
}

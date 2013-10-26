using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.DBInterop.Accessors.Abstract;

namespace Library.UI.DevExpressControls.Forms
{
    public class TypedEditForm<T> : EditForm
    {
        public T Data {
            get;
            set;
        }

        public TypedEditForm() {

        }

        public virtual void SetData(T data) {
            Data = data;
        }
    }
}

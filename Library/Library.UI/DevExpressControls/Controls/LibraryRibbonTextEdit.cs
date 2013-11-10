using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UI.DevExpressControls.Controls
{
    /// <summary>
    /// Обертка для текстового редактора ленточного интерфейса
    /// </summary>
    public class LibraryRibbonTextEdit
    {
        /// <summary>
        /// Сам элемент интерфейса
        /// </summary>
        BarEditItem beiItem;
        /// <summary>
        /// Редактор
        /// </summary>
        RepositoryItemTextEdit riteItem;

        /// <summary>
        /// Текст элемента был изменен
        /// </summary>
        public event EventHandler TextChanged;

        public event KeyEventHandler KeyDown;

        public LibraryRibbonTextEdit(BarEditItem beiItem) {
            this.beiItem = beiItem;
            riteItem = (RepositoryItemTextEdit)beiItem.Edit;
            riteItem.EditValueChanged += new EventHandler(Edit_EditValueChanged);
            riteItem.KeyDown += OnKeyDown;
            Text = string.Empty;
        }

        void OnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if (KeyDown != null) {
                KeyDown(this, e);
            }
        }

        void Edit_EditValueChanged(object sender, EventArgs e) {
            var edit = sender as TextEdit;
            Text = edit.Text;
            OnTextChanged(sender, e);
        }

        protected virtual void OnTextChanged(object sender, EventArgs args) {
            if (TextChanged != null)
                TextChanged(this, args);
        }

        /// <summary>
        /// Набранный текст
        /// </summary>
        public string Text {
            get;
            protected set;
        }

        /// <summary>
        /// Удалить текст из элемента
        /// </summary>
        public void Clear() {
            Text = string.Empty;
            beiItem.EditValue = string.Empty;
        }
    }
}

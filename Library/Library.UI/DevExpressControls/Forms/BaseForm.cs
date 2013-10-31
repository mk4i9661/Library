using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Library.UI.DevExpressControls.Forms
{
    public partial class BaseForm : XtraForm
    {
        public BaseForm() {
            InitializeComponent();
            Load += OnLoad;
        }

        protected void OnLoad(object sender, System.EventArgs e) {
            InitHandlers();
        }

        protected virtual void InitHandlers() {
            KeyDown += BaseForm_KeyDown;
        }

        void BaseForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                CloseCancel();
            }
        }

        protected virtual void CloseCancel() {
            DialogResult = DialogResult.Cancel;
        }
    }
}

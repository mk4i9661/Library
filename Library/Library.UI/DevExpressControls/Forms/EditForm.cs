using System.Windows.Forms;
namespace Library.UI.DevExpressControls.Forms
{
    public partial class EditForm : BaseForm
    {
        public EditForm() {
            InitializeComponent();
            InitHandlers();
        }

        protected virtual void InitHandlers() {
            bSave.Click += bSave_Click;
            bCancel.Click += bCancel_Click;
        }

        void bCancel_Click(object sender, System.EventArgs e) {
            OnCancelClick();
        }

        void bSave_Click(object sender, System.EventArgs e) {
            OnSaveClick();
        }

        protected virtual void OnValidateFormFields() {

        }

        protected bool IsValid() {
            return !errorProvider.HasErrors;
        }

        protected void ValidateControl(Control control, bool isNotValid, string message) {
            errorProvider.SetError(control, !isNotValid ? string.Empty : message);
        }

        protected virtual void OnSaveClick() {

        }

        protected virtual void OnCancelClick() {
            DialogResult = DialogResult.Cancel;
        }

    }
}

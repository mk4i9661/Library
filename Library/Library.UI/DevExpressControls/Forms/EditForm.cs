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

        protected virtual void OnSaveClick() {

        }

        protected virtual void OnCancelClick() {

        }

    }
}

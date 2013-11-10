namespace Library.WindowsClient.EditForms
{
    partial class BookQuantityInputDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.seQuantity = new Library.UI.DevExpressControls.Controls.LibrarySpinEdit();
            this.bOk = new Library.UI.DevExpressControls.Controls.LibraryButton();
            this.bCancel = new Library.UI.DevExpressControls.Controls.LibraryButton();
            ((System.ComponentModel.ISupportInitialize)(this.seQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // seQuantity
            // 
            this.seQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seQuantity.Location = new System.Drawing.Point(12, 12);
            this.seQuantity.Name = "seQuantity";
            this.seQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.seQuantity.Properties.Appearance.Options.UseFont = true;
            this.seQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seQuantity.Properties.IsFloatValue = false;
            this.seQuantity.Properties.Mask.EditMask = "F0";
            this.seQuantity.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seQuantity.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seQuantity.Size = new System.Drawing.Size(428, 24);
            this.seQuantity.TabIndex = 0;
            // 
            // bOk
            // 
            this.bOk.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOk.Appearance.Options.UseFont = true;
            this.bOk.Location = new System.Drawing.Point(173, 42);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(132, 23);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "ОК";
            // 
            // bCancel
            // 
            this.bCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.bCancel.Appearance.Options.UseFont = true;
            this.bCancel.Location = new System.Drawing.Point(308, 42);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(132, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Отмена";
            // 
            // BookQuantityInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(452, 74);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.seQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookQuantityInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Число книг";
            ((System.ComponentModel.ISupportInitialize)(this.seQuantity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.DevExpressControls.Controls.LibrarySpinEdit seQuantity;
        private UI.DevExpressControls.Controls.LibraryButton bOk;
        private UI.DevExpressControls.Controls.LibraryButton bCancel;
    }
}
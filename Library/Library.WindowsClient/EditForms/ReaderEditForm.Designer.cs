namespace Library.WindowsClient.EditForms
{
    partial class ReaderEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teName = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teLastName = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teMiddleName = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teAddress = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tePhone = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.seId = new Library.UI.DevExpressControls.Controls.LibrarySpinEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.seId);
            this.layoutControl1.Controls.Add(this.tePhone);
            this.layoutControl1.Controls.Add(this.teAddress);
            this.layoutControl1.Controls.Add(this.teMiddleName);
            this.layoutControl1.Controls.Add(this.teLastName);
            this.layoutControl1.Controls.Add(this.teName);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(314, 174, 362, 350);
            this.layoutControl1.Size = new System.Drawing.Size(432, 188);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Location = new System.Drawing.Point(0, 188);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(432, 188);
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(106, 68);
            this.teName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teName.Name = "teName";
            this.teName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teName.Properties.Appearance.Options.UseFont = true;
            this.teName.Properties.MaxLength = 255;
            this.teName.Size = new System.Drawing.Size(314, 24);
            this.teName.StyleController = this.layoutControl1;
            this.teName.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teName;
            this.layoutControlItem1.CustomizationFormText = "Имя:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem1.Text = "Имя:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(90, 18);
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(106, 40);
            this.teLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teLastName.Properties.Appearance.Options.UseFont = true;
            this.teLastName.Properties.MaxLength = 255;
            this.teLastName.Size = new System.Drawing.Size(314, 24);
            this.teLastName.StyleController = this.layoutControl1;
            this.teLastName.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.teLastName;
            this.layoutControlItem2.CustomizationFormText = "Фамилия:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem2.Text = "Фамилия:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(90, 18);
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(106, 96);
            this.teMiddleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teMiddleName.Properties.Appearance.Options.UseFont = true;
            this.teMiddleName.Properties.MaxLength = 255;
            this.teMiddleName.Size = new System.Drawing.Size(314, 24);
            this.teMiddleName.StyleController = this.layoutControl1;
            this.teMiddleName.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teMiddleName;
            this.layoutControlItem3.CustomizationFormText = "Отчество:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem3.Text = "Отчество:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(90, 18);
            // 
            // teAddress
            // 
            this.teAddress.Location = new System.Drawing.Point(106, 124);
            this.teAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teAddress.Name = "teAddress";
            this.teAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teAddress.Properties.Appearance.Options.UseFont = true;
            this.teAddress.Properties.MaxLength = 255;
            this.teAddress.Size = new System.Drawing.Size(314, 24);
            this.teAddress.StyleController = this.layoutControl1;
            this.teAddress.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.teAddress;
            this.layoutControlItem4.CustomizationFormText = "Адрес:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem4.Text = "Адрес:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(90, 18);
            // 
            // tePhone
            // 
            this.tePhone.Location = new System.Drawing.Point(106, 152);
            this.tePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tePhone.Name = "tePhone";
            this.tePhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tePhone.Properties.Appearance.Options.UseFont = true;
            this.tePhone.Properties.MaxLength = 255;
            this.tePhone.Size = new System.Drawing.Size(314, 24);
            this.tePhone.StyleController = this.layoutControl1;
            this.tePhone.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tePhone;
            this.layoutControlItem5.CustomizationFormText = "Телефон:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem5.Text = "Телефон:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(90, 18);
            // 
            // seId
            // 
            this.seId.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seId.Location = new System.Drawing.Point(106, 12);
            this.seId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seId.Name = "seId";
            this.seId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.seId.Properties.Appearance.Options.UseFont = true;
            this.seId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seId.Properties.IsFloatValue = false;
            this.seId.Properties.Mask.EditMask = "F0";
            this.seId.Properties.MaxValue = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.seId.Size = new System.Drawing.Size(314, 24);
            this.seId.StyleController = this.layoutControl1;
            this.seId.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.seId;
            this.layoutControlItem6.CustomizationFormText = "№ паспорта:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem6.Text = "№ паспорта:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(90, 18);
            // 
            // ReaderEditForm
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 256);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReaderEditForm";
            this.Text = "Читатель";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.DevExpressControls.Controls.LibraryTextEdit teName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private UI.DevExpressControls.Controls.LibraryTextEdit tePhone;
        private UI.DevExpressControls.Controls.LibraryTextEdit teAddress;
        private UI.DevExpressControls.Controls.LibraryTextEdit teMiddleName;
        private UI.DevExpressControls.Controls.LibraryTextEdit teLastName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private UI.DevExpressControls.Controls.LibrarySpinEdit seId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
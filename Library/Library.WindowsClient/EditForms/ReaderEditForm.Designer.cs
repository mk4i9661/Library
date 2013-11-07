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
            this.teAdress = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tePhone = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.teAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tePhone);
            this.layoutControl1.Controls.Add(this.teAdress);
            this.layoutControl1.Controls.Add(this.teMiddleName);
            this.layoutControl1.Controls.Add(this.teLastName);
            this.layoutControl1.Controls.Add(this.teName);
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(314, 174, 362, 350);
            this.layoutControl1.Size = new System.Drawing.Size(378, 141);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Location = new System.Drawing.Point(0, 141);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Size = new System.Drawing.Size(378, 141);
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(74, 12);
            this.teName.Name = "teName";
            this.teName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teName.Properties.Appearance.Options.UseFont = true;
            this.teName.Properties.MaxLength = 255;
            this.teName.Size = new System.Drawing.Size(292, 20);
            this.teName.StyleController = this.layoutControl1;
            this.teName.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teName;
            this.layoutControlItem1.CustomizationFormText = "Имя:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(358, 24);
            this.layoutControlItem1.Text = "Имя:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(58, 14);
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(74, 36);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teLastName.Properties.Appearance.Options.UseFont = true;
            this.teLastName.Properties.MaxLength = 255;
            this.teLastName.Size = new System.Drawing.Size(292, 20);
            this.teLastName.StyleController = this.layoutControl1;
            this.teLastName.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.teLastName;
            this.layoutControlItem2.CustomizationFormText = "Фамилия:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(358, 24);
            this.layoutControlItem2.Text = "Фамилия:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(58, 14);
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(74, 60);
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teMiddleName.Properties.Appearance.Options.UseFont = true;
            this.teMiddleName.Properties.MaxLength = 255;
            this.teMiddleName.Size = new System.Drawing.Size(292, 20);
            this.teMiddleName.StyleController = this.layoutControl1;
            this.teMiddleName.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teMiddleName;
            this.layoutControlItem3.CustomizationFormText = "Отчество:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(358, 24);
            this.layoutControlItem3.Text = "Отчество:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(58, 14);
            // 
            // teAdress
            // 
            this.teAdress.Location = new System.Drawing.Point(74, 84);
            this.teAdress.Name = "teAdress";
            this.teAdress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teAdress.Properties.Appearance.Options.UseFont = true;
            this.teAdress.Properties.MaxLength = 255;
            this.teAdress.Size = new System.Drawing.Size(292, 20);
            this.teAdress.StyleController = this.layoutControl1;
            this.teAdress.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.teAdress;
            this.layoutControlItem4.CustomizationFormText = "Адрес:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(358, 24);
            this.layoutControlItem4.Text = "Адрес:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(58, 14);
            // 
            // tePhone
            // 
            this.tePhone.Location = new System.Drawing.Point(74, 108);
            this.tePhone.Name = "tePhone";
            this.tePhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tePhone.Properties.Appearance.Options.UseFont = true;
            this.tePhone.Properties.MaxLength = 255;
            this.tePhone.Size = new System.Drawing.Size(292, 20);
            this.tePhone.StyleController = this.layoutControl1;
            this.tePhone.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tePhone;
            this.layoutControlItem5.CustomizationFormText = "Телефон:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(358, 25);
            this.layoutControlItem5.Text = "Телефон:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(58, 14);
            // 
            // ReaderEditForm
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 194);
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
            ((System.ComponentModel.ISupportInitialize)(this.teAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.DevExpressControls.Controls.LibraryTextEdit teName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private UI.DevExpressControls.Controls.LibraryTextEdit tePhone;
        private UI.DevExpressControls.Controls.LibraryTextEdit teAdress;
        private UI.DevExpressControls.Controls.LibraryTextEdit teMiddleName;
        private UI.DevExpressControls.Controls.LibraryTextEdit teLastName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
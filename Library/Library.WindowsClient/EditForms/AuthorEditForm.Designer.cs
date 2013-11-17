namespace Library.WindowsClient.EditForms
{
    partial class AuthorEditForm
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
            this.teName = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teLastName = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teMiddleName = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.meBiography = new Library.UI.DevExpressControls.Controls.LibraryMemoEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.meBiography.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.meBiography);
            this.layoutControl1.Controls.Add(this.teMiddleName);
            this.layoutControl1.Controls.Add(this.teLastName);
            this.layoutControl1.Controls.Add(this.teName);
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(314, 174, 362, 350);
            this.layoutControl1.Size = new System.Drawing.Size(432, 331);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Location = new System.Drawing.Point(0, 331);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(432, 331);
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(96, 40);
            this.teName.Name = "teName";
            this.teName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teName.Properties.Appearance.Options.UseFont = true;
            this.teName.Properties.MaxLength = 255;
            this.teName.Size = new System.Drawing.Size(324, 24);
            this.teName.StyleController = this.layoutControl1;
            this.teName.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teName;
            this.layoutControlItem1.CustomizationFormText = "Имя:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem1.Text = "Имя:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 18);
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(96, 12);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teLastName.Properties.Appearance.Options.UseFont = true;
            this.teLastName.Properties.MaxLength = 255;
            this.teLastName.Size = new System.Drawing.Size(324, 24);
            this.teLastName.StyleController = this.layoutControl1;
            this.teLastName.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.teLastName;
            this.layoutControlItem2.CustomizationFormText = "Отчество:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem2.Text = "Фамилия:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 18);
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(96, 68);
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teMiddleName.Properties.Appearance.Options.UseFont = true;
            this.teMiddleName.Properties.MaxLength = 255;
            this.teMiddleName.Size = new System.Drawing.Size(324, 24);
            this.teMiddleName.StyleController = this.layoutControl1;
            this.teMiddleName.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teMiddleName;
            this.layoutControlItem3.CustomizationFormText = "Отчество:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem3.Text = "Отчество:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 18);
            // 
            // meBiography
            // 
            this.meBiography.Location = new System.Drawing.Point(96, 96);
            this.meBiography.Name = "meBiography";
            this.meBiography.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.meBiography.Properties.Appearance.Options.UseFont = true;
            this.meBiography.Properties.MaxLength = 1000;
            this.meBiography.Size = new System.Drawing.Size(324, 223);
            this.meBiography.StyleController = this.layoutControl1;
            this.meBiography.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.meBiography;
            this.layoutControlItem4.CustomizationFormText = "Биография:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(412, 227);
            this.layoutControlItem4.Text = "Биография:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(80, 18);
            // 
            // AuthorEditForm
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 399);
            this.Name = "AuthorEditForm";
            this.Text = "Автор";
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
            ((System.ComponentModel.ISupportInitialize)(this.meBiography.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.DevExpressControls.Controls.LibraryTextEdit teName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private UI.DevExpressControls.Controls.LibraryTextEdit teMiddleName;
        private UI.DevExpressControls.Controls.LibraryTextEdit teLastName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private UI.DevExpressControls.Controls.LibraryMemoEdit meBiography;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
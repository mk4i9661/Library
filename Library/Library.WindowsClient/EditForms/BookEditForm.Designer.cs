namespace Library.WindowsClient.EditForms
{
    partial class BookEditForm
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
            this.seImprint = new Library.UI.DevExpressControls.Controls.LibrarySpinEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sePageQuantity = new Library.UI.DevExpressControls.Controls.LibrarySpinEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.seBookQuantity = new Library.UI.DevExpressControls.Controls.LibrarySpinEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.meAnnotation = new Library.UI.DevExpressControls.Controls.LibraryMemoEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbRubric = new Library.UI.DevExpressControls.Controls.LibraryComboBox();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbPublisher = new Library.UI.DevExpressControls.Controls.LibraryComboBox();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seImprint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePageQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seBookQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meAnnotation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRubric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPublisher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbPublisher);
            this.layoutControl1.Controls.Add(this.cbRubric);
            this.layoutControl1.Controls.Add(this.meAnnotation);
            this.layoutControl1.Controls.Add(this.seBookQuantity);
            this.layoutControl1.Controls.Add(this.sePageQuantity);
            this.layoutControl1.Controls.Add(this.seImprint);
            this.layoutControl1.Controls.Add(this.teName);
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(314, 174, 362, 350);
            this.layoutControl1.Size = new System.Drawing.Size(432, 378);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Location = new System.Drawing.Point(0, 378);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Size = new System.Drawing.Size(432, 378);
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(123, 68);
            this.teName.Name = "teName";
            this.teName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teName.Properties.Appearance.Options.UseFont = true;
            this.teName.Properties.MaxLength = 255;
            this.teName.Size = new System.Drawing.Size(297, 24);
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
            this.layoutControlItem1.TextSize = new System.Drawing.Size(107, 18);
            // 
            // seImprint
            // 
            this.seImprint.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seImprint.Location = new System.Drawing.Point(123, 96);
            this.seImprint.Name = "seImprint";
            this.seImprint.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.seImprint.Properties.Appearance.Options.UseFont = true;
            this.seImprint.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seImprint.Properties.IsFloatValue = false;
            this.seImprint.Properties.Mask.EditMask = "F0";
            this.seImprint.Properties.MaxValue = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.seImprint.Size = new System.Drawing.Size(297, 24);
            this.seImprint.StyleController = this.layoutControl1;
            this.seImprint.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.seImprint;
            this.layoutControlItem2.CustomizationFormText = "Год издания:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem2.Text = "Год издания:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(107, 18);
            // 
            // sePageQuantity
            // 
            this.sePageQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sePageQuantity.Location = new System.Drawing.Point(123, 124);
            this.sePageQuantity.Name = "sePageQuantity";
            this.sePageQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.sePageQuantity.Properties.Appearance.Options.UseFont = true;
            this.sePageQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.sePageQuantity.Properties.IsFloatValue = false;
            this.sePageQuantity.Properties.Mask.EditMask = "F0";
            this.sePageQuantity.Properties.MaxValue = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.sePageQuantity.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sePageQuantity.Size = new System.Drawing.Size(297, 24);
            this.sePageQuantity.StyleController = this.layoutControl1;
            this.sePageQuantity.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sePageQuantity;
            this.layoutControlItem3.CustomizationFormText = "Число страниц:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem3.Text = "Число страниц:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(107, 18);
            // 
            // seBookQuantity
            // 
            this.seBookQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seBookQuantity.Location = new System.Drawing.Point(123, 152);
            this.seBookQuantity.Name = "seBookQuantity";
            this.seBookQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.seBookQuantity.Properties.Appearance.Options.UseFont = true;
            this.seBookQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seBookQuantity.Properties.IsFloatValue = false;
            this.seBookQuantity.Properties.Mask.EditMask = "F0";
            this.seBookQuantity.Properties.MaxValue = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.seBookQuantity.Size = new System.Drawing.Size(297, 24);
            this.seBookQuantity.StyleController = this.layoutControl1;
            this.seBookQuantity.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.seBookQuantity;
            this.layoutControlItem4.CustomizationFormText = "Число книг:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem4.Text = "Число книг:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(107, 18);
            // 
            // meAnnotation
            // 
            this.meAnnotation.Location = new System.Drawing.Point(123, 180);
            this.meAnnotation.Name = "meAnnotation";
            this.meAnnotation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.meAnnotation.Properties.Appearance.Options.UseFont = true;
            this.meAnnotation.Properties.MaxLength = 1000;
            this.meAnnotation.Size = new System.Drawing.Size(297, 186);
            this.meAnnotation.StyleController = this.layoutControl1;
            this.meAnnotation.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.meAnnotation;
            this.layoutControlItem5.CustomizationFormText = "Аннотация:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(412, 190);
            this.layoutControlItem5.Text = "Аннотация:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(107, 18);
            // 
            // cbRubric
            // 
            this.cbRubric.Location = new System.Drawing.Point(123, 12);
            this.cbRubric.Name = "cbRubric";
            this.cbRubric.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbRubric.Properties.Appearance.Options.UseFont = true;
            this.cbRubric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRubric.Properties.DropDownRows = 15;
            this.cbRubric.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbRubric.Size = new System.Drawing.Size(297, 24);
            this.cbRubric.StyleController = this.layoutControl1;
            this.cbRubric.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbRubric;
            this.layoutControlItem6.CustomizationFormText = "Рубрика:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem6.Text = "Рубрика:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(107, 18);
            // 
            // cbPublisher
            // 
            this.cbPublisher.Location = new System.Drawing.Point(123, 40);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbPublisher.Properties.Appearance.Options.UseFont = true;
            this.cbPublisher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPublisher.Properties.DropDownRows = 15;
            this.cbPublisher.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPublisher.Size = new System.Drawing.Size(297, 24);
            this.cbPublisher.StyleController = this.layoutControl1;
            this.cbPublisher.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbPublisher;
            this.layoutControlItem7.CustomizationFormText = "Издательство:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem7.Text = "Издательство:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(107, 18);
            // 
            // BookEditForm
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 446);
            this.Name = "BookEditForm";
            this.Text = "Книга";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seImprint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePageQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seBookQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meAnnotation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRubric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPublisher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.DevExpressControls.Controls.LibraryTextEdit teName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private UI.DevExpressControls.Controls.LibraryComboBox cbPublisher;
        private UI.DevExpressControls.Controls.LibraryComboBox cbRubric;
        private UI.DevExpressControls.Controls.LibraryMemoEdit meAnnotation;
        private UI.DevExpressControls.Controls.LibrarySpinEdit seBookQuantity;
        private UI.DevExpressControls.Controls.LibrarySpinEdit sePageQuantity;
        private UI.DevExpressControls.Controls.LibrarySpinEdit seImprint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}
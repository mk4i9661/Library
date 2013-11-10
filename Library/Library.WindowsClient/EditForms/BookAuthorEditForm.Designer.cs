namespace Library.WindowsClient.EditForms
{
    partial class BookAuthorEditForm
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
            this.teFilter = new Library.UI.DevExpressControls.Controls.LibraryTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcAuthors = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.gvAuthors = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcAuthors);
            this.layoutControl1.Controls.Add(this.teFilter);
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(314, 174, 362, 350);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            // 
            // teFilter
            // 
            this.teFilter.Location = new System.Drawing.Point(75, 12);
            this.teFilter.Name = "teFilter";
            this.teFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.teFilter.Properties.Appearance.Options.UseFont = true;
            this.teFilter.Properties.MaxLength = 255;
            this.teFilter.Size = new System.Drawing.Size(345, 24);
            this.teFilter.StyleController = this.layoutControl1;
            this.teFilter.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teFilter;
            this.layoutControlItem1.CustomizationFormText = "Фильтр:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(412, 28);
            this.layoutControlItem1.Text = "Фильтр:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 18);
            // 
            // gcAuthors
            // 
            this.gcAuthors.Location = new System.Drawing.Point(12, 61);
            this.gcAuthors.MainView = this.gvAuthors;
            this.gcAuthors.Name = "gcAuthors";
            this.gcAuthors.Size = new System.Drawing.Size(408, 407);
            this.gcAuthors.TabIndex = 5;
            this.gcAuthors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAuthors});
            // 
            // gvAuthors
            // 
            this.gvAuthors.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gvAuthors.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAuthors.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvAuthors.Appearance.Row.Options.UseFont = true;
            this.gvAuthors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvAuthors.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvAuthors.GridControl = this.gcAuthors;
            this.gvAuthors.Name = "gvAuthors";
            this.gvAuthors.OptionsCustomization.AllowFilter = false;
            this.gvAuthors.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvAuthors.OptionsDetail.AllowZoomDetail = false;
            this.gvAuthors.OptionsDetail.ShowDetailTabs = false;
            this.gvAuthors.OptionsMenu.EnableColumnMenu = false;
            this.gvAuthors.OptionsMenu.EnableFooterMenu = false;
            this.gvAuthors.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvAuthors.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvAuthors.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Выбрать";
            this.gridColumn1.FieldName = "Selected";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 79;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ФИО";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 311;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.gcAuthors;
            this.layoutControlItem2.CustomizationFormText = "Авторы";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(412, 432);
            this.layoutControlItem2.Text = "Авторы";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 18);
            // 
            // BookAuthorEditForm
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 548);
            this.Name = "BookAuthorEditForm";
            this.Text = "BookAuthorEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.DevExpressControls.Controls.LibraryTextEdit teFilter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private UI.DevExpressControls.Controls.LibraryGridControl gcAuthors;
        private UI.DevExpressControls.Controls.LibraryGridView gvAuthors;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
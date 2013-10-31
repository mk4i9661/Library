using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.WindowsClient
{
    partial class MainForm
    {
        private void InitializeComponent() {
            this.rpBooks = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpCards = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpReaders = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rcPages = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rpPublishers = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtcPages = new DevExpress.XtraTab.XtraTabControl();
            this.xtpReaders = new DevExpress.XtraTab.XtraTabPage();
            this.xtpCards = new DevExpress.XtraTab.XtraTabPage();
            this.xtpBooks = new DevExpress.XtraTab.XtraTabPage();
            this.xtpPublishers = new DevExpress.XtraTab.XtraTabPage();
            this.libraryGridControl1 = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.libraryGridView1 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rcPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).BeginInit();
            this.xtcPages.SuspendLayout();
            this.xtpPublishers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rpBooks
            // 
            this.rpBooks.Name = "rpBooks";
            this.rpBooks.Text = "Книги";
            // 
            // rpCards
            // 
            this.rpCards.Name = "rpCards";
            this.rpCards.Text = "Читательские карты";
            // 
            // rpReaders
            // 
            this.rpReaders.Name = "rpReaders";
            this.rpReaders.Text = "Читатели";
            // 
            // rcPages
            // 
            this.rcPages.AllowMinimizeRibbon = false;
            this.rcPages.ExpandCollapseItem.Id = 0;
            this.rcPages.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcPages.ExpandCollapseItem});
            this.rcPages.Location = new System.Drawing.Point(0, 0);
            this.rcPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcPages.MaxItemId = 1;
            this.rcPages.Name = "rcPages";
            this.rcPages.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpReaders,
            this.rpCards,
            this.rpBooks,
            this.rpPublishers});
            this.rcPages.ShowToolbarCustomizeItem = false;
            this.rcPages.Size = new System.Drawing.Size(1200, 153);
            this.rcPages.Toolbar.ShowCustomizeItem = false;
            // 
            // rpPublishers
            // 
            this.rpPublishers.Name = "rpPublishers";
            this.rpPublishers.Text = "Издатели";
            // 
            // xtcPages
            // 
            this.xtcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcPages.Location = new System.Drawing.Point(0, 153);
            this.xtcPages.Name = "xtcPages";
            this.xtcPages.SelectedTabPage = this.xtpReaders;
            this.xtcPages.Size = new System.Drawing.Size(1200, 444);
            this.xtcPages.TabIndex = 1;
            this.xtcPages.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpReaders,
            this.xtpCards,
            this.xtpBooks,
            this.xtpPublishers});
            // 
            // xtpReaders
            // 
            this.xtpReaders.Name = "xtpReaders";
            this.xtpReaders.Size = new System.Drawing.Size(1194, 413);
            this.xtpReaders.Text = "Читатели";
            // 
            // xtpCards
            // 
            this.xtpCards.Name = "xtpCards";
            this.xtpCards.Size = new System.Drawing.Size(1194, 413);
            this.xtpCards.Text = "Читательские карты";
            // 
            // xtpBooks
            // 
            this.xtpBooks.Name = "xtpBooks";
            this.xtpBooks.Size = new System.Drawing.Size(1194, 413);
            this.xtpBooks.Text = "Книги";
            // 
            // xtpPublishers
            // 
            this.xtpPublishers.Controls.Add(this.libraryGridControl1);
            this.xtpPublishers.Name = "xtpPublishers";
            this.xtpPublishers.Size = new System.Drawing.Size(1194, 413);
            this.xtpPublishers.Text = "Издатели";
            // 
            // libraryGridControl1
            // 
            this.libraryGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryGridControl1.Location = new System.Drawing.Point(0, 0);
            this.libraryGridControl1.MainView = this.libraryGridView1;
            this.libraryGridControl1.MenuManager = this.rcPages;
            this.libraryGridControl1.Name = "libraryGridControl1";
            this.libraryGridControl1.Size = new System.Drawing.Size(1194, 413);
            this.libraryGridControl1.TabIndex = 0;
            this.libraryGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.libraryGridView1});
            // 
            // libraryGridView1
            // 
            this.libraryGridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.libraryGridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.libraryGridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.libraryGridView1.Appearance.Row.Options.UseFont = true;
            this.libraryGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.libraryGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.libraryGridView1.GridControl = this.libraryGridControl1;
            this.libraryGridView1.Name = "libraryGridView1";
            this.libraryGridView1.OptionsBehavior.Editable = false;
            this.libraryGridView1.OptionsBehavior.ReadOnly = true;
            this.libraryGridView1.OptionsCustomization.AllowFilter = false;
            this.libraryGridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.libraryGridView1.OptionsDetail.AllowZoomDetail = false;
            this.libraryGridView1.OptionsDetail.ShowDetailTabs = false;
            this.libraryGridView1.OptionsMenu.EnableColumnMenu = false;
            this.libraryGridView1.OptionsMenu.EnableFooterMenu = false;
            this.libraryGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.libraryGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.libraryGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Имя";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Адрес";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1200, 597);
            this.Controls.Add(this.xtcPages);
            this.Controls.Add(this.rcPages);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Система \"Библиотека\"";
            ((System.ComponentModel.ISupportInitialize)(this.rcPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).EndInit();
            this.xtcPages.ResumeLayout(false);
            this.xtpPublishers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraBars.Ribbon.RibbonPage rpBooks;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCards;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReaders;
        private DevExpress.XtraBars.Ribbon.RibbonControl rcPages;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpPublishers;
        private DevExpress.XtraTab.XtraTabControl xtcPages;
        private DevExpress.XtraTab.XtraTabPage xtpReaders;
        private DevExpress.XtraTab.XtraTabPage xtpCards;
        private DevExpress.XtraTab.XtraTabPage xtpBooks;
        private DevExpress.XtraTab.XtraTabPage xtpPublishers;
        private UI.DevExpressControls.Controls.LibraryGridControl libraryGridControl1;
        private UI.DevExpressControls.Controls.LibraryGridView libraryGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}

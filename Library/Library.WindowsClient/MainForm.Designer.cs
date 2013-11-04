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
            this.rcPages = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.rpReaders = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpCards = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpBooks = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpPublishers = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpRubrics = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtcPages = new DevExpress.XtraTab.XtraTabControl();
            this.xtpReaders = new DevExpress.XtraTab.XtraTabPage();
            this.xtpCards = new DevExpress.XtraTab.XtraTabPage();
            this.xtpBooks = new DevExpress.XtraTab.XtraTabPage();
            this.xtpPublishers = new DevExpress.XtraTab.XtraTabPage();
            this.gcPublishers = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.libraryGridView1 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtpRubrics = new DevExpress.XtraTab.XtraTabPage();
            this.gcRubrics = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.libraryGridView2 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rcPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).BeginInit();
            this.xtcPages.SuspendLayout();
            this.xtpPublishers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPublishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView1)).BeginInit();
            this.xtpRubrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRubrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // rcPages
            // 
            this.rcPages.AllowMinimizeRibbon = false;
            this.rcPages.AutoSizeItems = true;
            this.rcPages.ExpandCollapseItem.Id = 0;
            this.rcPages.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcPages.ExpandCollapseItem,
            this.bbiAdd,
            this.bbiEdit,
            this.bbiDelete});
            this.rcPages.Location = new System.Drawing.Point(0, 0);
            this.rcPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcPages.MaxItemId = 4;
            this.rcPages.Name = "rcPages";
            this.rcPages.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpReaders,
            this.rpCards,
            this.rpBooks,
            this.rpPublishers,
            this.rpRubrics});
            this.rcPages.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.rcPages.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.rcPages.ShowToolbarCustomizeItem = false;
            this.rcPages.Size = new System.Drawing.Size(1200, 128);
            this.rcPages.Toolbar.ShowCustomizeItem = false;
            this.rcPages.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Добавить";
            this.bbiAdd.Id = 1;
            this.bbiAdd.LargeGlyph = global::Library.WindowsClient.Properties.Resources.ADD;
            this.bbiAdd.Name = "bbiAdd";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Изменить";
            this.bbiEdit.Id = 2;
            this.bbiEdit.LargeGlyph = global::Library.WindowsClient.Properties.Resources.EDIT;
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Удалить";
            this.bbiDelete.Id = 3;
            this.bbiDelete.LargeGlyph = global::Library.WindowsClient.Properties.Resources.DELETE;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // rpReaders
            // 
            this.rpReaders.Name = "rpReaders";
            this.rpReaders.Text = "Читатели";
            // 
            // rpCards
            // 
            this.rpCards.Name = "rpCards";
            this.rpCards.Text = "Читательские карты";
            // 
            // rpBooks
            // 
            this.rpBooks.Name = "rpBooks";
            this.rpBooks.Text = "Книги";
            // 
            // rpPublishers
            // 
            this.rpPublishers.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpPublishers.Name = "rpPublishers";
            this.rpPublishers.Text = "Издатели";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Редактирование";
            // 
            // rpRubrics
            // 
            this.rpRubrics.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rpRubrics.Name = "rpRubrics";
            this.rpRubrics.Text = "Рубрики";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiAdd);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Редактирование";
            // 
            // xtcPages
            // 
            this.xtcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcPages.Location = new System.Drawing.Point(0, 128);
            this.xtcPages.Name = "xtcPages";
            this.xtcPages.SelectedTabPage = this.xtpReaders;
            this.xtcPages.Size = new System.Drawing.Size(1200, 469);
            this.xtcPages.TabIndex = 1;
            this.xtcPages.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpReaders,
            this.xtpCards,
            this.xtpBooks,
            this.xtpPublishers,
            this.xtpRubrics});
            // 
            // xtpReaders
            // 
            this.xtpReaders.Name = "xtpReaders";
            this.xtpReaders.Size = new System.Drawing.Size(1194, 438);
            this.xtpReaders.Text = "Читатели";
            // 
            // xtpCards
            // 
            this.xtpCards.Name = "xtpCards";
            this.xtpCards.Size = new System.Drawing.Size(1194, 438);
            this.xtpCards.Text = "Читательские карты";
            // 
            // xtpBooks
            // 
            this.xtpBooks.Name = "xtpBooks";
            this.xtpBooks.Size = new System.Drawing.Size(1194, 438);
            this.xtpBooks.Text = "Книги";
            // 
            // xtpPublishers
            // 
            this.xtpPublishers.Controls.Add(this.gcPublishers);
            this.xtpPublishers.Name = "xtpPublishers";
            this.xtpPublishers.Size = new System.Drawing.Size(1194, 438);
            this.xtpPublishers.Text = "Издатели";
            // 
            // gcPublishers
            // 
            this.gcPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPublishers.Location = new System.Drawing.Point(0, 0);
            this.gcPublishers.MainView = this.libraryGridView1;
            this.gcPublishers.MenuManager = this.rcPages;
            this.gcPublishers.Name = "gcPublishers";
            this.gcPublishers.Size = new System.Drawing.Size(1194, 438);
            this.gcPublishers.TabIndex = 0;
            this.gcPublishers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.libraryGridView1.GridControl = this.gcPublishers;
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
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Адрес";
            this.gridColumn2.FieldName = "Location";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // xtpRubrics
            // 
            this.xtpRubrics.Controls.Add(this.gcRubrics);
            this.xtpRubrics.Name = "xtpRubrics";
            this.xtpRubrics.Size = new System.Drawing.Size(1194, 438);
            this.xtpRubrics.Text = "Рубрики";
            // 
            // gcRubrics
            // 
            this.gcRubrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRubrics.Location = new System.Drawing.Point(0, 0);
            this.gcRubrics.MainView = this.libraryGridView2;
            this.gcRubrics.MenuManager = this.rcPages;
            this.gcRubrics.Name = "gcRubrics";
            this.gcRubrics.Size = new System.Drawing.Size(1194, 438);
            this.gcRubrics.TabIndex = 0;
            this.gcRubrics.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.libraryGridView2});
            // 
            // libraryGridView2
            // 
            this.libraryGridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.libraryGridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.libraryGridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.libraryGridView2.Appearance.Row.Options.UseFont = true;
            this.libraryGridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.libraryGridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.libraryGridView2.GridControl = this.gcRubrics;
            this.libraryGridView2.Name = "libraryGridView2";
            this.libraryGridView2.OptionsBehavior.Editable = false;
            this.libraryGridView2.OptionsBehavior.ReadOnly = true;
            this.libraryGridView2.OptionsCustomization.AllowFilter = false;
            this.libraryGridView2.OptionsCustomization.AllowQuickHideColumns = false;
            this.libraryGridView2.OptionsDetail.AllowZoomDetail = false;
            this.libraryGridView2.OptionsDetail.ShowDetailTabs = false;
            this.libraryGridView2.OptionsMenu.EnableColumnMenu = false;
            this.libraryGridView2.OptionsMenu.EnableFooterMenu = false;
            this.libraryGridView2.OptionsMenu.EnableGroupPanelMenu = false;
            this.libraryGridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.libraryGridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Название";
            this.gridColumn3.FieldName = "Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.gcPublishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView1)).EndInit();
            this.xtpRubrics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRubrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView2)).EndInit();
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
        private UI.DevExpressControls.Controls.LibraryGridControl gcPublishers;
        private UI.DevExpressControls.Controls.LibraryGridView libraryGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpRubrics;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTab.XtraTabPage xtpRubrics;
        private UI.DevExpressControls.Controls.LibraryGridControl gcRubrics;
        private UI.DevExpressControls.Controls.LibraryGridView libraryGridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}

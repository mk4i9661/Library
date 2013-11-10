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
            this.beiSearch = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.beiRubric = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.beiPublisher = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.bbiReload = new DevExpress.XtraBars.BarButtonItem();
            this.rpReaders = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpCards = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpBooks = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpPublishers = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpRubrics = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtcPages = new DevExpress.XtraTab.XtraTabControl();
            this.xtpReaders = new DevExpress.XtraTab.XtraTabPage();
            this.xtpCards = new DevExpress.XtraTab.XtraTabPage();
            this.xtpBooks = new DevExpress.XtraTab.XtraTabPage();
            this.gcBooks = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.libraryGridView3 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtpPublishers = new DevExpress.XtraTab.XtraTabPage();
            this.gcPublishers = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.libraryGridView1 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtpRubrics = new DevExpress.XtraTab.XtraTabPage();
            this.gcRubrics = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.libraryGridView2 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bbiAuthors = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.rcPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).BeginInit();
            this.xtcPages.SuspendLayout();
            this.xtpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView3)).BeginInit();
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
            this.bbiDelete,
            this.beiSearch,
            this.beiRubric,
            this.beiPublisher,
            this.bbiReload,
            this.bbiAuthors});
            this.rcPages.Location = new System.Drawing.Point(0, 0);
            this.rcPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcPages.MaxItemId = 10;
            this.rcPages.Name = "rcPages";
            this.rcPages.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpReaders,
            this.rpCards,
            this.rpBooks,
            this.rpPublishers,
            this.rpRubrics});
            this.rcPages.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemTextEdit1});
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
            // beiSearch
            // 
            this.beiSearch.Caption = "Поиск";
            this.beiSearch.Edit = this.repositoryItemTextEdit1;
            this.beiSearch.Id = 4;
            this.beiSearch.Name = "beiSearch";
            this.beiSearch.Width = 150;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // beiRubric
            // 
            this.beiRubric.Caption = "Рубрика";
            this.beiRubric.Edit = this.repositoryItemComboBox1;
            this.beiRubric.Id = 5;
            this.beiRubric.Name = "beiRubric";
            this.beiRubric.Width = 150;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // beiPublisher
            // 
            this.beiPublisher.Caption = "Издатель";
            this.beiPublisher.Edit = this.repositoryItemComboBox2;
            this.beiPublisher.Id = 6;
            this.beiPublisher.Name = "beiPublisher";
            this.beiPublisher.Width = 150;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // bbiReload
            // 
            this.bbiReload.Caption = "Обновить";
            this.bbiReload.Id = 8;
            this.bbiReload.LargeGlyph = global::Library.WindowsClient.Properties.Resources.refresh;
            this.bbiReload.Name = "bbiReload";
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
            this.rpBooks.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.rpBooks.Name = "rpBooks";
            this.rpBooks.Text = "Книги";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.bbiReload);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Данные";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiAdd);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiAuthors);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Редактирование";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.beiRubric);
            this.ribbonPageGroup4.ItemLinks.Add(this.beiPublisher);
            this.ribbonPageGroup4.ItemLinks.Add(this.beiSearch);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Фильтрация";
            // 
            // rpPublishers
            // 
            this.rpPublishers.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup1});
            this.rpPublishers.Name = "rpPublishers";
            this.rpPublishers.Text = "Издатели";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bbiReload);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Данные";
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
            this.ribbonPageGroup7,
            this.ribbonPageGroup2});
            this.rpRubrics.Name = "rpRubrics";
            this.rpRubrics.Text = "Рубрики";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.bbiReload);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            this.ribbonPageGroup7.Text = "Данные";
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
            this.xtpBooks.Controls.Add(this.gcBooks);
            this.xtpBooks.Name = "xtpBooks";
            this.xtpBooks.Size = new System.Drawing.Size(1194, 438);
            this.xtpBooks.Text = "Книги";
            // 
            // gcBooks
            // 
            this.gcBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBooks.Location = new System.Drawing.Point(0, 0);
            this.gcBooks.MainView = this.libraryGridView3;
            this.gcBooks.MenuManager = this.rcPages;
            this.gcBooks.Name = "gcBooks";
            this.gcBooks.Size = new System.Drawing.Size(1194, 438);
            this.gcBooks.TabIndex = 0;
            this.gcBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.libraryGridView3});
            // 
            // libraryGridView3
            // 
            this.libraryGridView3.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.libraryGridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.libraryGridView3.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.libraryGridView3.Appearance.Row.Options.UseFont = true;
            this.libraryGridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.libraryGridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.libraryGridView3.GridControl = this.gcBooks;
            this.libraryGridView3.Name = "libraryGridView3";
            this.libraryGridView3.OptionsBehavior.Editable = false;
            this.libraryGridView3.OptionsBehavior.ReadOnly = true;
            this.libraryGridView3.OptionsCustomization.AllowFilter = false;
            this.libraryGridView3.OptionsCustomization.AllowQuickHideColumns = false;
            this.libraryGridView3.OptionsDetail.AllowZoomDetail = false;
            this.libraryGridView3.OptionsDetail.ShowDetailTabs = false;
            this.libraryGridView3.OptionsMenu.EnableColumnMenu = false;
            this.libraryGridView3.OptionsMenu.EnableFooterMenu = false;
            this.libraryGridView3.OptionsMenu.EnableGroupPanelMenu = false;
            this.libraryGridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.libraryGridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Рубрика";
            this.gridColumn4.FieldName = "Rubric";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Издательство";
            this.gridColumn5.FieldName = "Publisher";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Название";
            this.gridColumn6.FieldName = "Name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Год издания";
            this.gridColumn7.DisplayFormat.FormatString = "yyyy";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn7.FieldName = "ImprintDate";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Число страниц";
            this.gridColumn8.FieldName = "PageQuantity";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Число книг";
            this.gridColumn9.FieldName = "BookQuantity";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
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
            // bbiAuthors
            // 
            this.bbiAuthors.Caption = "Авторы";
            this.bbiAuthors.Id = 9;
            this.bbiAuthors.Name = "bbiAuthors";
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).EndInit();
            this.xtcPages.ResumeLayout(false);
            this.xtpBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView3)).EndInit();
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
        private DevExpress.XtraBars.BarEditItem beiSearch;
        private DevExpress.XtraBars.BarEditItem beiRubric;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem beiPublisher;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private UI.DevExpressControls.Controls.LibraryGridControl gcBooks;
        private UI.DevExpressControls.Controls.LibraryGridView libraryGridView3;
        private DevExpress.XtraBars.BarButtonItem bbiReload;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraBars.BarButtonItem bbiAuthors;
    }
}

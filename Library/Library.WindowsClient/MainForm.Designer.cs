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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvApprovedRequests = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRequests = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.gvRejectedRequests = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.libraryGridView4 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.bbiAuthors = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRenewal = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReturn = new DevExpress.XtraBars.BarButtonItem();
            this.bciObligators = new DevExpress.XtraBars.BarCheckItem();
            this.beiCard = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.bbiSendNotifications = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRenewCard = new DevExpress.XtraBars.BarButtonItem();
            this.beiAuthor = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.rpReaders = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup15 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.rpRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup20 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpReportBooks = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpAuthors = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup18 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup19 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.libraryGridView6 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcReportBooks = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.libraryGridView5 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.libraryGridView8 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcReaders = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.libraryGridView7 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtcPages = new DevExpress.XtraTab.XtraTabControl();
            this.xtpReaders = new DevExpress.XtraTab.XtraTabPage();
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
            this.xtpRequests = new DevExpress.XtraTab.XtraTabPage();
            this.xtpReportBooks = new DevExpress.XtraTab.XtraTabPage();
            this.xtpAuthors = new DevExpress.XtraTab.XtraTabPage();
            this.gcAuthors = new Library.UI.DevExpressControls.Controls.LibraryGridControl();
            this.libraryGridView9 = new Library.UI.DevExpressControls.Controls.LibraryGridView();
            this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvApprovedRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRejectedRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReportBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).BeginInit();
            this.xtcPages.SuspendLayout();
            this.xtpReaders.SuspendLayout();
            this.xtpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView3)).BeginInit();
            this.xtpPublishers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPublishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView1)).BeginInit();
            this.xtpRubrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRubrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView2)).BeginInit();
            this.xtpRequests.SuspendLayout();
            this.xtpReportBooks.SuspendLayout();
            this.xtpAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView9)).BeginInit();
            this.SuspendLayout();
            // 
            // gvApprovedRequests
            // 
            this.gvApprovedRequests.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gvApprovedRequests.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvApprovedRequests.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvApprovedRequests.Appearance.Row.Options.UseFont = true;
            this.gvApprovedRequests.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.gvApprovedRequests.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvApprovedRequests.GridControl = this.gcRequests;
            this.gvApprovedRequests.Name = "gvApprovedRequests";
            this.gvApprovedRequests.OptionsBehavior.Editable = false;
            this.gvApprovedRequests.OptionsBehavior.ReadOnly = true;
            this.gvApprovedRequests.OptionsCustomization.AllowFilter = false;
            this.gvApprovedRequests.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvApprovedRequests.OptionsMenu.EnableColumnMenu = false;
            this.gvApprovedRequests.OptionsMenu.EnableFooterMenu = false;
            this.gvApprovedRequests.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvApprovedRequests.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvApprovedRequests.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Дата возврата";
            this.gridColumn12.FieldName = "ReturnDate";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Продлений";
            this.gridColumn13.FieldName = "RenewalCount";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Возвращено";
            this.gridColumn14.FieldName = "IsReturned";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 4;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Книга";
            this.gridColumn15.FieldName = "Name";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 0;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Книг запрошено";
            this.gridColumn16.FieldName = "BookQuantity";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 1;
            // 
            // gcRequests
            // 
            this.gcRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRequests.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.LevelTemplate = this.gvApprovedRequests;
            gridLevelNode1.RelationName = "RequestApproved";
            gridLevelNode2.LevelTemplate = this.gvRejectedRequests;
            gridLevelNode2.RelationName = "RequestRejected";
            this.gcRequests.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gcRequests.Location = new System.Drawing.Point(0, 0);
            this.gcRequests.MainView = this.libraryGridView4;
            this.gcRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcRequests.MenuManager = this.rcPages;
            this.gcRequests.Name = "gcRequests";
            this.gcRequests.Size = new System.Drawing.Size(1023, 340);
            this.gcRequests.TabIndex = 0;
            this.gcRequests.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRejectedRequests,
            this.libraryGridView4,
            this.gvApprovedRequests});
            // 
            // gvRejectedRequests
            // 
            this.gvRejectedRequests.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gvRejectedRequests.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvRejectedRequests.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvRejectedRequests.Appearance.Row.Options.UseFont = true;
            this.gvRejectedRequests.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19});
            this.gvRejectedRequests.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvRejectedRequests.GridControl = this.gcRequests;
            this.gvRejectedRequests.Name = "gvRejectedRequests";
            this.gvRejectedRequests.OptionsBehavior.Editable = false;
            this.gvRejectedRequests.OptionsBehavior.ReadOnly = true;
            this.gvRejectedRequests.OptionsCustomization.AllowFilter = false;
            this.gvRejectedRequests.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvRejectedRequests.OptionsMenu.EnableColumnMenu = false;
            this.gvRejectedRequests.OptionsMenu.EnableFooterMenu = false;
            this.gvRejectedRequests.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvRejectedRequests.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvRejectedRequests.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Книга";
            this.gridColumn17.FieldName = "Name";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Книг запрошено";
            this.gridColumn18.FieldName = "BookQuantity";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 1;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Причина отказа";
            this.gridColumn19.FieldName = "Reason";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 2;
            // 
            // libraryGridView4
            // 
            this.libraryGridView4.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.libraryGridView4.Appearance.HeaderPanel.Options.UseFont = true;
            this.libraryGridView4.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.libraryGridView4.Appearance.Row.Options.UseFont = true;
            this.libraryGridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11});
            this.libraryGridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.libraryGridView4.GridControl = this.gcRequests;
            this.libraryGridView4.Name = "libraryGridView4";
            this.libraryGridView4.OptionsBehavior.Editable = false;
            this.libraryGridView4.OptionsBehavior.ReadOnly = true;
            this.libraryGridView4.OptionsCustomization.AllowFilter = false;
            this.libraryGridView4.OptionsCustomization.AllowQuickHideColumns = false;
            this.libraryGridView4.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.libraryGridView4.OptionsDetail.AllowZoomDetail = false;
            this.libraryGridView4.OptionsMenu.EnableColumnMenu = false;
            this.libraryGridView4.OptionsMenu.EnableFooterMenu = false;
            this.libraryGridView4.OptionsMenu.EnableGroupPanelMenu = false;
            this.libraryGridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.libraryGridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Читатель";
            this.gridColumn10.FieldName = "ReaderUnbound";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Время создания";
            this.gridColumn11.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn11.FieldName = "CreateDate";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
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
            this.bbiAuthors,
            this.bbiRenewal,
            this.bbiReturn,
            this.bciObligators,
            this.beiCard,
            this.bbiSendNotifications,
            this.bbiRenewCard,
            this.beiAuthor});
            this.rcPages.Location = new System.Drawing.Point(0, 0);
            this.rcPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcPages.MaxItemId = 18;
            this.rcPages.Name = "rcPages";
            this.rcPages.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpReaders,
            this.rpBooks,
            this.rpPublishers,
            this.rpRubrics,
            this.rpRequests,
            this.rpReportBooks,
            this.rpAuthors});
            this.rcPages.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemTextEdit1,
            this.repositoryItemComboBox3,
            this.repositoryItemTextEdit2,
            this.repositoryItemComboBox4});
            this.rcPages.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.rcPages.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.rcPages.ShowToolbarCustomizeItem = false;
            this.rcPages.Size = new System.Drawing.Size(1029, 117);
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
            // bbiAuthors
            // 
            this.bbiAuthors.Caption = "Авторы";
            this.bbiAuthors.Id = 9;
            this.bbiAuthors.LargeGlyph = global::Library.WindowsClient.Properties.Resources.group;
            this.bbiAuthors.Name = "bbiAuthors";
            // 
            // bbiRenewal
            // 
            this.bbiRenewal.Caption = "Продлить";
            this.bbiRenewal.Id = 10;
            this.bbiRenewal.LargeGlyph = global::Library.WindowsClient.Properties.Resources.book_go;
            this.bbiRenewal.Name = "bbiRenewal";
            // 
            // bbiReturn
            // 
            this.bbiReturn.Caption = "Вернуть";
            this.bbiReturn.Id = 11;
            this.bbiReturn.LargeGlyph = global::Library.WindowsClient.Properties.Resources.book_previous;
            this.bbiReturn.Name = "bbiReturn";
            // 
            // bciObligators
            // 
            this.bciObligators.Caption = "Должники";
            this.bciObligators.Id = 12;
            this.bciObligators.LargeGlyph = global::Library.WindowsClient.Properties.Resources.user_astronaut;
            this.bciObligators.Name = "bciObligators";
            // 
            // beiCard
            // 
            this.beiCard.Caption = "Билет";
            this.beiCard.Edit = this.repositoryItemComboBox3;
            this.beiCard.Id = 13;
            this.beiCard.Name = "beiCard";
            this.beiCard.Width = 150;
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // bbiSendNotifications
            // 
            this.bbiSendNotifications.Caption = "Уведомить";
            this.bbiSendNotifications.Id = 15;
            this.bbiSendNotifications.LargeGlyph = global::Library.WindowsClient.Properties.Resources.sound;
            this.bbiSendNotifications.Name = "bbiSendNotifications";
            // 
            // bbiRenewCard
            // 
            this.bbiRenewCard.Caption = "Продлить билет";
            this.bbiRenewCard.Id = 16;
            this.bbiRenewCard.LargeGlyph = global::Library.WindowsClient.Properties.Resources.book_go;
            this.bbiRenewCard.Name = "bbiRenewCard";
            // 
            // beiAuthor
            // 
            this.beiAuthor.Caption = "Автор";
            this.beiAuthor.Edit = this.repositoryItemComboBox4;
            this.beiAuthor.Id = 17;
            this.beiAuthor.Name = "beiAuthor";
            this.beiAuthor.Width = 150;
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // rpReaders
            // 
            this.rpReaders.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup14,
            this.ribbonPageGroup15});
            this.rpReaders.Name = "rpReaders";
            this.rpReaders.Text = "Читатели";
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.ItemLinks.Add(this.bbiReload);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            this.ribbonPageGroup14.ShowCaptionButton = false;
            this.ribbonPageGroup14.Text = "Данные";
            // 
            // ribbonPageGroup15
            // 
            this.ribbonPageGroup15.ItemLinks.Add(this.bbiAdd);
            this.ribbonPageGroup15.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup15.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup15.ItemLinks.Add(this.bbiRenewCard);
            this.ribbonPageGroup15.Name = "ribbonPageGroup15";
            this.ribbonPageGroup15.ShowCaptionButton = false;
            this.ribbonPageGroup15.Text = "Редактирование";
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
            this.ribbonPageGroup4.ItemLinks.Add(this.beiAuthor, true);
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
            // rpRequests
            // 
            this.rpRequests.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup10,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup20,
            this.ribbonPageGroup13});
            this.rpRequests.Name = "rpRequests";
            this.rpRequests.Text = "Работа с читателями";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.bbiReload);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.ShowCaptionButton = false;
            this.ribbonPageGroup10.Text = "Данные";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.bbiAdd);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.ShowCaptionButton = false;
            this.ribbonPageGroup8.Text = "Запросы";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.bbiRenewal);
            this.ribbonPageGroup9.ItemLinks.Add(this.bbiReturn);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.ShowCaptionButton = false;
            this.ribbonPageGroup9.Text = "Книги";
            // 
            // ribbonPageGroup20
            // 
            this.ribbonPageGroup20.ItemLinks.Add(this.bbiSendNotifications);
            this.ribbonPageGroup20.Name = "ribbonPageGroup20";
            this.ribbonPageGroup20.ShowCaptionButton = false;
            this.ribbonPageGroup20.Text = "Читатели";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.beiCard);
            this.ribbonPageGroup13.ItemLinks.Add(this.beiSearch);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            this.ribbonPageGroup13.ShowCaptionButton = false;
            this.ribbonPageGroup13.Text = "Фильтрация";
            // 
            // rpReportBooks
            // 
            this.rpReportBooks.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup11,
            this.ribbonPageGroup12});
            this.rpReportBooks.Name = "rpReportBooks";
            this.rpReportBooks.Text = "Сводка по книгам";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.bbiReload);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.ShowCaptionButton = false;
            this.ribbonPageGroup11.Text = "Данные";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.beiRubric);
            this.ribbonPageGroup12.ItemLinks.Add(this.beiPublisher);
            this.ribbonPageGroup12.ItemLinks.Add(this.beiSearch);
            this.ribbonPageGroup12.ItemLinks.Add(this.bciObligators);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.ShowCaptionButton = false;
            this.ribbonPageGroup12.Text = "Фильтрация";
            // 
            // rpAuthors
            // 
            this.rpAuthors.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup18,
            this.ribbonPageGroup19});
            this.rpAuthors.Name = "rpAuthors";
            this.rpAuthors.Text = "Авторы";
            // 
            // ribbonPageGroup18
            // 
            this.ribbonPageGroup18.ItemLinks.Add(this.bbiReload);
            this.ribbonPageGroup18.Name = "ribbonPageGroup18";
            this.ribbonPageGroup18.ShowCaptionButton = false;
            this.ribbonPageGroup18.Text = "Данные";
            // 
            // ribbonPageGroup19
            // 
            this.ribbonPageGroup19.ItemLinks.Add(this.bbiAdd);
            this.ribbonPageGroup19.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup19.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup19.Name = "ribbonPageGroup19";
            this.ribbonPageGroup19.ShowCaptionButton = false;
            this.ribbonPageGroup19.Text = "Редактирование";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // libraryGridView6
            // 
            this.libraryGridView6.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.libraryGridView6.Appearance.HeaderPanel.Options.UseFont = true;
            this.libraryGridView6.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.libraryGridView6.Appearance.Row.Options.UseFont = true;
            this.libraryGridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30,
            this.gridColumn31,
            this.gridColumn32});
            this.libraryGridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.libraryGridView6.GridControl = this.gcReportBooks;
            this.libraryGridView6.Name = "libraryGridView6";
            this.libraryGridView6.OptionsBehavior.Editable = false;
            this.libraryGridView6.OptionsBehavior.ReadOnly = true;
            this.libraryGridView6.OptionsCustomization.AllowFilter = false;
            this.libraryGridView6.OptionsCustomization.AllowQuickHideColumns = false;
            this.libraryGridView6.OptionsDetail.AllowZoomDetail = false;
            this.libraryGridView6.OptionsDetail.ShowDetailTabs = false;
            this.libraryGridView6.OptionsMenu.EnableColumnMenu = false;
            this.libraryGridView6.OptionsMenu.EnableFooterMenu = false;
            this.libraryGridView6.OptionsMenu.EnableGroupPanelMenu = false;
            this.libraryGridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.libraryGridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "Фамилия";
            this.gridColumn28.FieldName = "LastName";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 0;
            // 
            // gridColumn29
            // 
            this.gridColumn29.Caption = "Имя";
            this.gridColumn29.FieldName = "FirstName";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 1;
            // 
            // gridColumn30
            // 
            this.gridColumn30.Caption = "Отчество";
            this.gridColumn30.FieldName = "MiddleName";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 2;
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "Телефон";
            this.gridColumn31.FieldName = "Phone";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 3;
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "Адрес";
            this.gridColumn32.FieldName = "Address";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 4;
            // 
            // gcReportBooks
            // 
            this.gcReportBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcReportBooks.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode3.LevelTemplate = this.libraryGridView6;
            gridLevelNode3.RelationName = "Readers";
            this.gcReportBooks.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            this.gcReportBooks.Location = new System.Drawing.Point(0, 0);
            this.gcReportBooks.MainView = this.libraryGridView5;
            this.gcReportBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcReportBooks.MenuManager = this.rcPages;
            this.gcReportBooks.Name = "gcReportBooks";
            this.gcReportBooks.Size = new System.Drawing.Size(1023, 340);
            this.gcReportBooks.TabIndex = 1;
            this.gcReportBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.libraryGridView5,
            this.libraryGridView6});
            // 
            // libraryGridView5
            // 
            this.libraryGridView5.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.libraryGridView5.Appearance.HeaderPanel.Options.UseFont = true;
            this.libraryGridView5.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.libraryGridView5.Appearance.Row.Options.UseFont = true;
            this.libraryGridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn24});
            this.libraryGridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.libraryGridView5.GridControl = this.gcReportBooks;
            this.libraryGridView5.Name = "libraryGridView5";
            this.libraryGridView5.OptionsBehavior.Editable = false;
            this.libraryGridView5.OptionsBehavior.ReadOnly = true;
            this.libraryGridView5.OptionsCustomization.AllowFilter = false;
            this.libraryGridView5.OptionsCustomization.AllowQuickHideColumns = false;
            this.libraryGridView5.OptionsDetail.AllowZoomDetail = false;
            this.libraryGridView5.OptionsDetail.ShowDetailTabs = false;
            this.libraryGridView5.OptionsMenu.EnableColumnMenu = false;
            this.libraryGridView5.OptionsMenu.EnableFooterMenu = false;
            this.libraryGridView5.OptionsMenu.EnableGroupPanelMenu = false;
            this.libraryGridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.libraryGridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Рубрика";
            this.gridColumn20.FieldName = "Rubric";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 0;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Издательство";
            this.gridColumn21.FieldName = "Publisher";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 1;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Название";
            this.gridColumn22.FieldName = "Name";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 2;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Год издания";
            this.gridColumn23.DisplayFormat.FormatString = "yyyy";
            this.gridColumn23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn23.FieldName = "ImprintDate";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 3;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "Книг на складе";
            this.gridColumn25.FieldName = "BookQuantity";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 4;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "Книг на руках";
            this.gridColumn26.FieldName = "TakenBookQuantity";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 5;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Книг задержано";
            this.gridColumn27.FieldName = "DelayedBookQuantity";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 6;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Всего книг";
            this.gridColumn24.FieldName = "BookQuantitySummary";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 7;
            // 
            // libraryGridView8
            // 
            this.libraryGridView8.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.libraryGridView8.Appearance.HeaderPanel.Options.UseFont = true;
            this.libraryGridView8.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.libraryGridView8.Appearance.Row.Options.UseFont = true;
            this.libraryGridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn40,
            this.gridColumn41});
            this.libraryGridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.libraryGridView8.GridControl = this.gcReaders;
            this.libraryGridView8.Name = "libraryGridView8";
            this.libraryGridView8.OptionsBehavior.Editable = false;
            this.libraryGridView8.OptionsBehavior.ReadOnly = true;
            this.libraryGridView8.OptionsCustomization.AllowFilter = false;
            this.libraryGridView8.OptionsCustomization.AllowQuickHideColumns = false;
            this.libraryGridView8.OptionsDetail.AllowZoomDetail = false;
            this.libraryGridView8.OptionsDetail.ShowDetailTabs = false;
            this.libraryGridView8.OptionsMenu.EnableColumnMenu = false;
            this.libraryGridView8.OptionsMenu.EnableFooterMenu = false;
            this.libraryGridView8.OptionsMenu.EnableGroupPanelMenu = false;
            this.libraryGridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.libraryGridView8.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn40
            // 
            this.gridColumn40.Caption = "Дата выдачи";
            this.gridColumn40.FieldName = "IssueDate";
            this.gridColumn40.Name = "gridColumn40";
            this.gridColumn40.Visible = true;
            this.gridColumn40.VisibleIndex = 0;
            // 
            // gridColumn41
            // 
            this.gridColumn41.Caption = "Действителен до";
            this.gridColumn41.FieldName = "ExpiryDate";
            this.gridColumn41.Name = "gridColumn41";
            this.gridColumn41.Visible = true;
            this.gridColumn41.VisibleIndex = 1;
            // 
            // gcReaders
            // 
            this.gcReaders.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode4.LevelTemplate = this.libraryGridView8;
            gridLevelNode4.RelationName = "Cards";
            this.gcReaders.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4});
            this.gcReaders.Location = new System.Drawing.Point(0, 0);
            this.gcReaders.MainView = this.libraryGridView7;
            this.gcReaders.MenuManager = this.rcPages;
            this.gcReaders.Name = "gcReaders";
            this.gcReaders.Size = new System.Drawing.Size(1023, 340);
            this.gcReaders.TabIndex = 0;
            this.gcReaders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.libraryGridView7,
            this.libraryGridView8});
            // 
            // libraryGridView7
            // 
            this.libraryGridView7.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.libraryGridView7.Appearance.HeaderPanel.Options.UseFont = true;
            this.libraryGridView7.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.libraryGridView7.Appearance.Row.Options.UseFont = true;
            this.libraryGridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn39,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn38});
            this.libraryGridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.libraryGridView7.GridControl = this.gcReaders;
            this.libraryGridView7.Name = "libraryGridView7";
            this.libraryGridView7.OptionsBehavior.Editable = false;
            this.libraryGridView7.OptionsBehavior.ReadOnly = true;
            this.libraryGridView7.OptionsCustomization.AllowFilter = false;
            this.libraryGridView7.OptionsCustomization.AllowQuickHideColumns = false;
            this.libraryGridView7.OptionsDetail.AllowZoomDetail = false;
            this.libraryGridView7.OptionsDetail.ShowDetailTabs = false;
            this.libraryGridView7.OptionsMenu.EnableColumnMenu = false;
            this.libraryGridView7.OptionsMenu.EnableFooterMenu = false;
            this.libraryGridView7.OptionsMenu.EnableGroupPanelMenu = false;
            this.libraryGridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.libraryGridView7.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn39
            // 
            this.gridColumn39.Caption = "№ билета";
            this.gridColumn39.FieldName = "CardId";
            this.gridColumn39.Name = "gridColumn39";
            this.gridColumn39.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn39.Visible = true;
            this.gridColumn39.VisibleIndex = 0;
            // 
            // gridColumn33
            // 
            this.gridColumn33.Caption = "№ паспорта";
            this.gridColumn33.FieldName = "PassportNumber";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 1;
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "Фамилия";
            this.gridColumn34.FieldName = "LastName";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.Visible = true;
            this.gridColumn34.VisibleIndex = 2;
            // 
            // gridColumn35
            // 
            this.gridColumn35.Caption = "Имя";
            this.gridColumn35.FieldName = "FirstName";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 3;
            // 
            // gridColumn36
            // 
            this.gridColumn36.Caption = "Отчество";
            this.gridColumn36.FieldName = "MiddleName";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 4;
            // 
            // gridColumn37
            // 
            this.gridColumn37.Caption = "Адрес";
            this.gridColumn37.FieldName = "Address";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.Visible = true;
            this.gridColumn37.VisibleIndex = 5;
            // 
            // gridColumn38
            // 
            this.gridColumn38.Caption = "Телефон";
            this.gridColumn38.FieldName = "Phone";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 6;
            // 
            // xtcPages
            // 
            this.xtcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcPages.Location = new System.Drawing.Point(0, 117);
            this.xtcPages.Margin = new System.Windows.Forms.Padding(0);
            this.xtcPages.Name = "xtcPages";
            this.xtcPages.SelectedTabPage = this.xtpReaders;
            this.xtcPages.Size = new System.Drawing.Size(1029, 368);
            this.xtcPages.TabIndex = 1;
            this.xtcPages.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpReaders,
            this.xtpBooks,
            this.xtpPublishers,
            this.xtpRubrics,
            this.xtpRequests,
            this.xtpReportBooks,
            this.xtpAuthors});
            // 
            // xtpReaders
            // 
            this.xtpReaders.Controls.Add(this.gcReaders);
            this.xtpReaders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtpReaders.Name = "xtpReaders";
            this.xtpReaders.Size = new System.Drawing.Size(1023, 340);
            this.xtpReaders.Text = "Читатели";
            // 
            // xtpBooks
            // 
            this.xtpBooks.Controls.Add(this.gcBooks);
            this.xtpBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtpBooks.Name = "xtpBooks";
            this.xtpBooks.Size = new System.Drawing.Size(1023, 340);
            this.xtpBooks.Text = "Книги";
            // 
            // gcBooks
            // 
            this.gcBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBooks.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBooks.Location = new System.Drawing.Point(0, 0);
            this.gcBooks.MainView = this.libraryGridView3;
            this.gcBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcBooks.MenuManager = this.rcPages;
            this.gcBooks.Name = "gcBooks";
            this.gcBooks.Size = new System.Drawing.Size(1023, 340);
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
            this.xtpPublishers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtpPublishers.Name = "xtpPublishers";
            this.xtpPublishers.Size = new System.Drawing.Size(1023, 340);
            this.xtpPublishers.Text = "Издатели";
            // 
            // gcPublishers
            // 
            this.gcPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPublishers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcPublishers.Location = new System.Drawing.Point(0, 0);
            this.gcPublishers.MainView = this.libraryGridView1;
            this.gcPublishers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcPublishers.MenuManager = this.rcPages;
            this.gcPublishers.Name = "gcPublishers";
            this.gcPublishers.Size = new System.Drawing.Size(1023, 340);
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
            this.xtpRubrics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtpRubrics.Name = "xtpRubrics";
            this.xtpRubrics.Size = new System.Drawing.Size(1023, 340);
            this.xtpRubrics.Text = "Рубрики";
            // 
            // gcRubrics
            // 
            this.gcRubrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRubrics.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcRubrics.Location = new System.Drawing.Point(0, 0);
            this.gcRubrics.MainView = this.libraryGridView2;
            this.gcRubrics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcRubrics.MenuManager = this.rcPages;
            this.gcRubrics.Name = "gcRubrics";
            this.gcRubrics.Size = new System.Drawing.Size(1023, 340);
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
            // xtpRequests
            // 
            this.xtpRequests.Controls.Add(this.gcRequests);
            this.xtpRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtpRequests.Name = "xtpRequests";
            this.xtpRequests.Size = new System.Drawing.Size(1023, 340);
            this.xtpRequests.Text = "Работа с читателями";
            // 
            // xtpReportBooks
            // 
            this.xtpReportBooks.Controls.Add(this.gcReportBooks);
            this.xtpReportBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtpReportBooks.Name = "xtpReportBooks";
            this.xtpReportBooks.Size = new System.Drawing.Size(1023, 340);
            this.xtpReportBooks.Text = "Сводка по книгам";
            // 
            // xtpAuthors
            // 
            this.xtpAuthors.Controls.Add(this.gcAuthors);
            this.xtpAuthors.Name = "xtpAuthors";
            this.xtpAuthors.Size = new System.Drawing.Size(1023, 340);
            this.xtpAuthors.Text = "Авторы";
            // 
            // gcAuthors
            // 
            this.gcAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAuthors.Location = new System.Drawing.Point(0, 0);
            this.gcAuthors.MainView = this.libraryGridView9;
            this.gcAuthors.MenuManager = this.rcPages;
            this.gcAuthors.Name = "gcAuthors";
            this.gcAuthors.Size = new System.Drawing.Size(1023, 340);
            this.gcAuthors.TabIndex = 0;
            this.gcAuthors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.libraryGridView9});
            // 
            // libraryGridView9
            // 
            this.libraryGridView9.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.libraryGridView9.Appearance.HeaderPanel.Options.UseFont = true;
            this.libraryGridView9.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.libraryGridView9.Appearance.Row.Options.UseFont = true;
            this.libraryGridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn43,
            this.gridColumn44,
            this.gridColumn45});
            this.libraryGridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.libraryGridView9.GridControl = this.gcAuthors;
            this.libraryGridView9.Name = "libraryGridView9";
            this.libraryGridView9.OptionsBehavior.Editable = false;
            this.libraryGridView9.OptionsBehavior.ReadOnly = true;
            this.libraryGridView9.OptionsCustomization.AllowFilter = false;
            this.libraryGridView9.OptionsCustomization.AllowQuickHideColumns = false;
            this.libraryGridView9.OptionsDetail.AllowZoomDetail = false;
            this.libraryGridView9.OptionsDetail.ShowDetailTabs = false;
            this.libraryGridView9.OptionsMenu.EnableColumnMenu = false;
            this.libraryGridView9.OptionsMenu.EnableFooterMenu = false;
            this.libraryGridView9.OptionsMenu.EnableGroupPanelMenu = false;
            this.libraryGridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.libraryGridView9.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn43
            // 
            this.gridColumn43.Caption = "Фамилия";
            this.gridColumn43.FieldName = "LastName";
            this.gridColumn43.Name = "gridColumn43";
            this.gridColumn43.Visible = true;
            this.gridColumn43.VisibleIndex = 0;
            // 
            // gridColumn44
            // 
            this.gridColumn44.Caption = "Имя";
            this.gridColumn44.FieldName = "FirstName";
            this.gridColumn44.Name = "gridColumn44";
            this.gridColumn44.Visible = true;
            this.gridColumn44.VisibleIndex = 1;
            // 
            // gridColumn45
            // 
            this.gridColumn45.Caption = "Отчество";
            this.gridColumn45.FieldName = "MiddleName";
            this.gridColumn45.Name = "gridColumn45";
            this.gridColumn45.Visible = true;
            this.gridColumn45.VisibleIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1029, 485);
            this.Controls.Add(this.xtcPages);
            this.Controls.Add(this.rcPages);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "MainForm";
            this.Text = "Система \"Библиотека\"";
            ((System.ComponentModel.ISupportInitialize)(this.gvApprovedRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRejectedRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReportBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).EndInit();
            this.xtcPages.ResumeLayout(false);
            this.xtpReaders.ResumeLayout(false);
            this.xtpBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView3)).EndInit();
            this.xtpPublishers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPublishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView1)).EndInit();
            this.xtpRubrics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRubrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView2)).EndInit();
            this.xtpRequests.ResumeLayout(false);
            this.xtpReportBooks.ResumeLayout(false);
            this.xtpAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryGridView9)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraBars.Ribbon.RibbonPage rpBooks;
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
        private DevExpress.XtraBars.Ribbon.RibbonPage rpRequests;
        private DevExpress.XtraTab.XtraTabPage xtpRequests;
        private UI.DevExpressControls.Controls.LibraryGridControl gcRequests;
        private UI.DevExpressControls.Controls.LibraryGridView gvApprovedRequests;
        private UI.DevExpressControls.Controls.LibraryGridView gvRejectedRequests;
        private UI.DevExpressControls.Controls.LibraryGridView libraryGridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraBars.BarButtonItem bbiRenewal;
        private DevExpress.XtraBars.BarButtonItem bbiReturn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReportBooks;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraTab.XtraTabPage xtpReportBooks;
        private UI.DevExpressControls.Controls.LibraryGridControl gcReportBooks;
        private UI.DevExpressControls.Controls.LibraryGridView libraryGridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraBars.BarCheckItem bciObligators;
        private UI.DevExpressControls.Controls.LibraryGridView libraryGridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraBars.BarEditItem beiCard;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup15;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAuthors;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup18;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup19;
        private UI.DevExpressControls.Controls.LibraryGridControl gcReaders;
        private UI.DevExpressControls.Controls.LibraryGridView libraryGridView7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraTab.XtraTabPage xtpAuthors;
        private UI.DevExpressControls.Controls.LibraryGridControl gcAuthors;
        private UI.DevExpressControls.Controls.LibraryGridView libraryGridView9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraBars.BarButtonItem bbiSendNotifications;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private UI.DevExpressControls.Controls.LibraryGridView libraryGridView8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraBars.BarButtonItem bbiRenewCard;
        private DevExpress.XtraBars.BarEditItem beiAuthor;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
    }
}

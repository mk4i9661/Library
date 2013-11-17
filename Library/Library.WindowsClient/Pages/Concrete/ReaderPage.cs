using Library.Contracts;
using Library.DataContracts.Concrete;
using Library.UI.DevExpressControls.Forms;
using Library.WindowsClient.EditForms;
using Library.WindowsClient.Pages.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using DevExpress.XtraBars;
using System.Monads;

namespace Library.WindowsClient.Pages.Concrete
{
    class ReaderPage : Page<IOperator, ReaderPage.LoadNecessaryDataWrap, Reader>
    {
        BarButtonItem RenewCardItem {
            get;
            set;
        }

        public ReaderPage(ReaderPageParameters parameters)
            : base(parameters) {
            RenewCardItem = parameters.RenewCardItem;
            InitHandlers();
        }

        void InitHandlers() {
            GridControl.GridView.MasterRowGetRelationCount += GridView_MasterRowGetRelationCount;
            GridControl.GridView.MasterRowGetChildList += GridView_MasterRowGetChildList;
            GridControl.GridView.MasterRowGetRelationName += GridView_MasterRowGetRelationName;
            GridControl.GridView.CustomUnboundColumnData += GridView_CustomUnboundColumnData;
            RenewCardItem.ItemClick += RenewCardItem_ItemClick;
        }

        async void RenewCardItem_ItemClick(object sender, ItemClickEventArgs e) {
            var reader = GetSelectedRow();
            if (reader != null) {
                try {
                    await RenewCard(reader);
                    OnLoadData();
                    DialogMessages.Inform("Читательский билет успешно продлен");
                } catch (Exception exc) {
                    DialogMessages.Error(exc.Message);
                }
            }
        }

        Task<Reader> RenewCard(Reader reader) {
            return Task.Factory.StartNew(() => GetProxy().RenewCard(reader));
        }

        void GridView_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e) {
            e.IsEmpty = false;
        }

        void GridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if (e.Column.FieldName == "CardId") {
                var row = e.Row as Reader;
                e.Value = row.Card.Id;
            }
        }

        void GridView_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            e.RelationName = "Cards";
        }

        void GridView_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            var reader = GetRow(e.RowHandle);
            if (reader != null) {
                e.ChildList = new List<Card>() {
                    reader.Card
                };
            }
        }

        void GridView_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 1;
        }

        protected override IEnumerable<Reader> LoadDataOperation() {
            return GetProxy().GetReaders();
        }

        protected override Reader CreateDefaultRow() {
            return new Reader();
        }

        protected override Reader DeleteOperation(Reader data) {
            return GetProxy().DeleteReader(data);
        }

        protected override TypedEditForm<Reader> CreateEditForm() {
            return Ninject.Get<ReaderEditForm>();
        }

        internal class LoadNecessaryDataWrap
        {
        }

        internal class ReaderPageParameters : PageParameters
        {
            public BarButtonItem RenewCardItem {
                get;
                set;
            }
        }
    }
}

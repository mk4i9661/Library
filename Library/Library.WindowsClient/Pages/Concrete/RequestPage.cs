using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
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

namespace Library.WindowsClient.Pages.Concrete
{
    class RequestPage : Page<IOperator, RequestPage.LoadNecessaryDataWrap, RequestHeader>
    {
        IEnumerable<Book> Books {
            get;
            set;
        }

        IEnumerable<Card> Cards {
            get;
            set;
        }

        public RequestPage(RequestPageParameters parameters)
            : base(parameters) {
            Books = new List<Book>();
            Cards = new List<Card>();

            parameters.ReturnItem.ItemClick += ReturnItem_ItemClick;
            parameters.RenewalItem.ItemClick += RenewalItem_ItemClick;
            GridControl.GridView.MasterRowGetRelationCount += GridView_MasterRowGetRelationCount;
            GridControl.GridView.MasterRowGetChildList += GridView_MasterRowGetChildList;
            GridControl.GridView.MasterRowGetRelationName += GridView_MasterRowGetRelationName;
            GridControl.GridView.MasterRowGetRelationDisplayCaption += GridView_MasterRowGetRelationDisplayCaption;
            GridControl.GridView.MasterRowEmpty += GridView_MasterRowEmpty;
            GridControl.GridView.OptionsDetail.AllowExpandEmptyDetails = true;
            GridControl.GridView.OptionsDetail.ShowDetailTabs = true;
        }

        void GridView_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e) {
            var row = GetRow(e.RowHandle);
            e.IsEmpty = row == null || !row.HasApprovedRequests && !row.HasRejectedRequests;
        }

        public override void Activate() {
            base.Activate();
            Ninject.Rebind<RequestEditForm>().ToMethod(method => new RequestEditForm(Cards, Books));
        }

        void RenewalItem_ItemClick(object sender, ItemClickEventArgs e) {

        }

        void ReturnItem_ItemClick(object sender, ItemClickEventArgs e) {

        }

        void GridView_MasterRowGetRelationDisplayCaption(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            switch (GetRelationName(GetRow(e.RowHandle), e.RelationIndex)) {
                case "RequestApproved":
                    e.RelationName = "Одобрено";
                    break;
                case "RequestRejected":
                    e.RelationName = "Отказы";
                    break;
                default:
                    break;
            }
        }

        void GridView_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            e.RelationName = GetRelationName(GetRow(e.RowHandle), e.RelationIndex);
        }

        string GetRelationName(RequestHeader request, int relation) {
            if (request == null)
                return string.Empty;
            if (relation == 0) {
                return request.HasApprovedRequests ? "RequestApproved" : string.Empty;
            }
            if (relation == 1) {
                return request.HasRejectedRequests ? "RequestRejected" : string.Empty;
            }
            return string.Empty;
        }

        void GridView_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            var request = GetRow(e.RowHandle);
            if (request != null) {
                try {
                    switch (GetRelationName(request, e.RelationIndex)) {
                        case "RequestApproved":
                            var approved = GetApprovedRequests(request);
                            Task.WaitAll(approved);
                            e.ChildList = approved.Result.Select(r => new RequestApprovedWrap(r)).ToList();
                            break;
                        case "RequestRejected":
                            var rejected = GetRejectedRequests(request);
                            Task.WaitAll(rejected);
                            e.ChildList = rejected.Result.Select(r => new RequestRejectedWrap(r)).ToList();
                            break;
                        default:
                            break;
                    }
                } catch (Exception exc) {
                    DialogMessages.Error(exc.Message);
                }
            }
        }

        Task<IEnumerable<RequestApproved>> GetApprovedRequests(RequestHeader request) {
            return Task.Factory.StartNew(() => GetProxy().GetApprovedRequests(request));
        }

        Task<IEnumerable<RequestRejected>> GetRejectedRequests(RequestHeader request) {
            return Task.Factory.StartNew(() => GetProxy().GetRejectedRequests(request));
        }

        void GridView_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            var request = GetRow(e.RowHandle);
            if (request != null) {
                e.RelationCount = (request.HasApprovedRequests ? 1 : 0) + (request.HasRejectedRequests ? 1 : 0);
            } else {
                e.RelationCount = 2;
            }
        }

        protected override void AfterModifyDataOperation(RequestHeader data) {
            base.AfterModifyDataOperation(data);
            GridControl.GridView.ExpandMasterRow(GridControl.GridView.FocusedRowHandle);
        }

        protected override IEnumerable<RequestHeader> LoadDataOperation() {
            return GetProxy().GetRequestHeaders();
        }

        protected override RequestPage.LoadNecessaryDataWrap LoadNecessaryDataOperation() {
            return new LoadNecessaryDataWrap() {
                Books = GetProxy().GetBooks(),
                Cards = GetProxy().GetCards()
            };
        }

        protected override void OnEndLoadNecessaryData(RequestPage.LoadNecessaryDataWrap result) {
            base.OnEndLoadNecessaryData(result);
            Cards = result.Cards;
            Books = result.Books;
        }

        protected override RequestHeader CreateDefaultRow() {
            return new RequestHeader();
        }

        protected override TypedEditForm<RequestHeader> CreateEditForm() {
            return Ninject.Get<RequestEditForm>();
        }

        internal class LoadNecessaryDataWrap
        {
            public IEnumerable<Book> Books {
                get;
                set;
            }

            public IEnumerable<Card> Cards {
                get;
                set;
            }
        }

        class RequestApprovedWrap
        {
            RequestApproved Request {
                get;
                set;
            }

            public RequestApprovedWrap(RequestApproved request) {
                Request = request;
            }

            public string Name {
                get {
                    return Request.Id.Book.Name;
                }
            }

            public int BookQuantity {
                get {
                    return Request.Id.BookQuantity;
                }
            }

            public DateTime ReturnDate {
                get {
                    return Request.ReturnDate;
                }
            }

            public int RenewalCount {
                get {
                    return Request.RenewalCount;
                }
            }

            public bool IsReturned {
                get {
                    return Request.IsReturned;
                }
            }
        }

        class RequestRejectedWrap
        {
            public RequestRejected Request {
                get;
                set;
            }

            public RequestRejectedWrap(RequestRejected request) {
                Request = request;
            }

            public string Name {
                get {
                    return Request.Id.Book.Name;
                }
            }

            public int BookQuantity {
                get {
                    return Request.Id.BookQuantity;
                }
            }

            public string Reason {
                get {
                    return Request.Reason.Name;
                }
            }
        }

        internal class RequestPageParameters : PageParameters
        {
            public BarButtonItem ReturnItem {
                get;
                set;
            }

            public BarButtonItem RenewalItem {
                get;
                set;
            }
        }
    }
}

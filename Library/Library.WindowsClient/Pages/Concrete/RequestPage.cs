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
using Library.UI.DevExpressControls.Controls;
using System.Drawing;

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

        LibraryGridView GridViewRejectedRequests {
            get;
            set;
        }

        LibraryGridView GridViewApprovedRequests {
            get;
            set;
        }

        public RequestPage(RequestPageParameters parameters)
            : base(parameters) {
            Books = new List<Book>();
            Cards = new List<Card>();

            GridViewApprovedRequests = parameters.GridViewApprovedRequests;
            GridViewRejectedRequests = parameters.GridViewRejectedRequests;

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

        async void RenewalItem_ItemClick(object sender, ItemClickEventArgs e) {
            var view = GetFocusedChildView();
            if (view != null) {
                var request = view.GetSelectedRow<RequestApprovedWrap>();
                if (request != null && DialogMessages.Question("Продлить книгу?")) {
                    var result = await RenewalRequest(request.Request);
                    view.BeginDataUpdate();
                    request.Request.RenewalCount = result.RenewalCount;
                    request.Request.ReturnDate = result.ReturnDate;
                    view.EndDataUpdate();
                }
            }
        }

        async void ReturnItem_ItemClick(object sender, ItemClickEventArgs e) {
            var view = GetFocusedChildView();
            if (view != null) {
                var request = view.GetSelectedRow<RequestApprovedWrap>();
                if (request != null && DialogMessages.Question("Вернуть книгу?")) {
                    var result = await CloseRequest(request.Request);
                    view.BeginDataUpdate();
                    request.Request.IsReturned = result.IsReturned;
                    view.EndDataUpdate();
                }
            }
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

        async void GridView_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            var request = GetRow(e.RowHandle);
            if (request != null) {
                var view = (LibraryGridView)null;
                try {
                    switch (GetRelationName(request, e.RelationIndex)) {
                        case "RequestApproved":
                            var approved = new List<RequestApprovedWrap>();
                            e.ChildList = approved;
                            approved.AddRange((await GetApprovedRequests(request)).Select(r => new RequestApprovedWrap(r)));
                            view = GetChildView(e.RowHandle, e.RelationIndex);
                            view.BeginDataUpdate();
                            break;
                        case "RequestRejected":
                            var rejected = new List<RequestRejectedWrap>();
                            e.ChildList = rejected;
                            rejected.AddRange((await GetRejectedRequests(request)).Select(r => new RequestRejectedWrap(r)));
                            view = GetChildView(e.RowHandle, e.RelationIndex);
                            view.BeginDataUpdate();
                            break;
                        default:
                            break;
                    }
                } catch (Exception exc) {
                    DialogMessages.Error(exc.Message);
                } finally {
                    if (view != null) {
                        view.EndDataUpdate();
                    }
                }
            }
        }

        LibraryGridView GetChildView(int handle, int relation) {
            return GridControl.GridView.GetDetailView(handle, relation) as LibraryGridView;
        }

        LibraryGridView GetFocusedChildView() {
            var view = GridControl.FocusedView;
            if (view.IsDetailView) {
                return view as LibraryGridView;
            }
            return null;
        }

        Task<IEnumerable<RequestApproved>> GetApprovedRequests(RequestHeader request) {
            return Task.Factory.StartNew(() => GetProxy().GetApprovedRequests(request));
        }

        Task<IEnumerable<RequestRejected>> GetRejectedRequests(RequestHeader request) {
            return Task.Factory.StartNew(() => GetProxy().GetRejectedRequests(request));
        }

        Task<RequestApproved> RenewalRequest(RequestApproved request) {
            return Task.Factory.StartNew(() => GetProxy().RenewRequest(request));
        }

        Task<RequestApproved> CloseRequest(RequestApproved request) {
            return Task.Factory.StartNew(() => GetProxy().CloseRequest(request));
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

        public override void EditClick() {

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
            public RequestApproved Request {
                get;
                private set;
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

            public LibraryGridView GridViewRejectedRequests {
                get;
                set;
            }

            public LibraryGridView GridViewApprovedRequests {
                get;
                set;
            }
        }
    }
}

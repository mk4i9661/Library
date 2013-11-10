using Library.Contracts;
using Library.DataContracts.Concrete;
using Library.WindowsClient.Pages.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.WindowsClient.Pages.Concrete
{
    class RequestPage : Page<IOperator, RequestPage.LoadNecessaryDataWrap, Request>
    {
        public RequestPage(PageParameters parameters)
            : base(parameters) {
            GridControl.GridView.MasterRowGetRelationCount += GridView_MasterRowGetRelationCount;
            GridControl.GridView.MasterRowGetChildList += GridView_MasterRowGetChildList;
        }

        void GridView_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            
        }

        void GridView_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 2;
        }

        protected override IEnumerable<Request> LoadDataOperation() {
            return GetProxy().GetRequests();
        }

        internal class LoadNecessaryDataWrap
        {
        }
    }
}

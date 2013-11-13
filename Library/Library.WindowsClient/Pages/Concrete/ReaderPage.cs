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
    class ReaderPage : Page<IOperator, ReaderPage.LoadNecessaryDataWrap, Reader>
    {
        public ReaderPage(PageParameters parameters)
            : base(parameters) { 
        }

        protected override IEnumerable<Reader> LoadDataOperation()
        {
            return GetProxy().GetReaders();
        }

        protected override Reader CreateDefaultRow()
        {
            return new Reader();
        }

        protected override Reader DeleteOperation(Reader data)
        {
            return GetProxy().DeleteReader(data);
        }

        protected override TypedEditForm<Reader> CreateEditForm()
        {
            return Ninject.Get<ReaderEditForm>();
        }

        internal class LoadNecessaryDataWrap{
        }
    }
}

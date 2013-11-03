using Library.DataContracts.Concrete;
using Library.WindowsClient.Pages.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Library.Contracts;
using Library.UI.DevExpressControls.Forms;
using Library.WindowsClient.EditForms;

namespace Library.WindowsClient.Pages.Concrete
{
    class PublishersPage : Page<IBibliographer, PublishersPage.LoadNecessaryDataWrap, Publisher>
    {
        public PublishersPage(PageParameters parameters)
            : base(parameters) {

        }

        protected override IEnumerable<Publisher> LoadDataOperation() {
            return GetProxy().GetPublishers();
        }

        protected override Publisher CreateDefaultRow() {
            return new Publisher();
        }

        protected override TypedEditForm<Publisher> CreateEditForm() {
            return Ninject.Get<PublisherEditForm>();
        }

        protected override Publisher DeleteOperation(Publisher data) {
            return GetProxy().DeletePublisher(data);
        }

        internal class LoadNecessaryDataWrap
        {

        }
    }

}

using Library.Contracts;
using Library.DataContracts.Concrete;
using Library.UI.DevExpressControls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WindowsClient.EditForms
{
    partial class PublisherEditForm : PublisherEditFormMock
    {
        public PublisherEditForm() {
            InitializeComponent();
        }

        protected override void OnInitFormFields(Publisher data) {
            PublisherName = data.Name;
            Address = data.Location;
            Description = data.Description;
        }

        protected override void OnInitDataFields(Publisher data) {
            data.Name = PublisherName;
            data.Location = Address;
            data.Description = Description;
        }

        protected override void OnValidateFormFields() {
            ValidateControl(teName, string.IsNullOrEmpty(PublisherName), "Название должно быть задано");
            ValidateControl(teAddress, string.IsNullOrEmpty(Address), "Расположение издателя должно быть задано");
        }

        protected override Publisher InsertOperation(Publisher data) {
            return GetProxy().AddPublisher(data);
        }

        protected override Publisher UpdateOperation(Publisher data) {
            return GetProxy().UpdatePublisher(data);
        }

        string PublisherName {
            get {
                return teName.Text.Trim();
            }
            set {
                teName.Text = value;
            }
        }

        string Address {
            get {
                return teAddress.Text.Trim();
            }
            set {
                teAddress.Text = value;
            }
        }

        string Description {
            get {
                return meDescription.Text.Trim();
            }
            set {
                meDescription.Text = value;
            }
        }
    }

    class PublisherEditFormMock : LibraryEditForm<IBibliographer, Publisher>
    {

    }
}

using Library.Contracts;
using Library.DataContracts.Concrete;
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
    partial class ReaderEditForm : ReaderEditFormMock
    {
        public ReaderEditForm() {
            InitializeComponent();
        }

        protected override void OnInitFormFields(Reader data) {
            PassportNumber = data.PassportNumber;
            FirstName = data.FirstName;
            LastName = data.LastName;
            MiddleName = data.MiddleName;
            Address = data.Address;
            Phone = data.Phone;
        }

        protected override void OnInitDataFields(Reader data) {
            data.PassportNumber = PassportNumber;
            data.FirstName = FirstName;
            data.LastName = LastName;
            data.MiddleName = MiddleName;
            data.Address = Address;
            data.Phone = Phone;
        }

        protected override void OnValidateFormFields() {
            ValidateControl(seId, PassportNumber == 0, "Поле должно быть заполено");
            ValidateControl(teName, string.IsNullOrEmpty(FirstName), "Поле должно быть заполено");
            ValidateControl(teLastName, string.IsNullOrEmpty(LastName), "Поле должно быть заполено");
            ValidateControl(teMiddleName, string.IsNullOrEmpty(MiddleName), "Поле должно быть заполено");
            ValidateControl(teAddress, string.IsNullOrEmpty(Address), "Поле должно быть заполено");
            ValidateControl(tePhone, string.IsNullOrEmpty(Phone), "Поле должно быть заполено");
        }

        protected override Reader InsertOperation(Reader data) {
            return GetProxy().AddReader(data);
        }

        protected override Reader UpdateOperation(Reader data) {
            return GetProxy().UpdateReader(data);
        }

        int PassportNumber {
            get {
                return Convert.ToInt32(seId.Value);
            }
            set {
                seId.Value = value;
            }
        }

        string FirstName {
            get {
                return teName.Text.Trim();
            }
            set {
                teName.Text = value;
            }
        }

        string MiddleName {
            get {
                return teMiddleName.Text.Trim();
            }
            set {
                teMiddleName.Text = value;
            }
        }

        string LastName {
            get {
                return teLastName.Text.Trim();
            }
            set {
                teLastName.Text = value;
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

        string Phone {
            get {
                return tePhone.Text.Trim();
            }
            set {
                tePhone.Text = value;
            }
        }

    }

    class ReaderEditFormMock : LibraryEditForm<IOperator, Reader>
    {

    }
}

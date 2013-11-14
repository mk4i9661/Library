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
    partial class CardEditForm : CardEditFormMock
    {
        public CardEditForm(IEnumerable<Reader> readers)
        {
            Readers = readers;
            InitializeComponent();
        }

        IEnumerable<Reader> Readers
        {
            get;
            set;
        }

        protected override void OnInitFormFields(Card data)
        {
            cbReader.Bind(Readers, r => string.Format("{0} {1} {2}", r.LastName, r.FirstName, r.MiddleName), data.Reader);
        }

        protected override void OnInitDataFields(Card data)
        {
            data.Reader = Reader;
        }

        protected override void OnValidateFormFields()
        {
            ValidateControl(cbReader, Reader != null, "Поле должно быть заполнено.");
        }

        protected override Card InsertOperation(Card data)
        {
            return GetProxy().AddCard(data);
        }

        protected override Card UpdateOperation(Card data)
        {
            return GetProxy().UpdateCard(data);
        }

        Reader Reader
        {
            get
            {
                return cbReader.GetSelectedElement<Reader>();
            }
        }

    }

    class CardEditFormMock : LibraryEditForm<IOperator, Card> { 

    }
}

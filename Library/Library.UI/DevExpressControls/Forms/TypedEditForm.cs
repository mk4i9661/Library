using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UI.DevExpressControls.Forms
{
    public class TypedEditForm<T> : EditForm
        where T : class
    {
        public T Data {
            get;
            set;
        }

        public EditFormOperation Operation {
            get;
            set;
        }

        public TypedEditForm() {

        }

        public virtual void SetData(T data) {
            Data = data;
            OnInitFormFields(data);
        }

        protected virtual void OnInitFormFields(T data) {

        }

        protected virtual void OnInitDataFields(T data) {

        }

        protected virtual Task<T> SaveData(T data) {
            switch (Operation) {
                case EditFormOperation.Insert:
                    return InsertData(data);
                case EditFormOperation.Update:
                    return UpdateData(data);
                default:
                    return Task.Factory.StartNew(() => data);
            }
        }

        protected virtual Task<T> InsertData(T data) {
            return Task.Factory.StartNew(() => InsertOperation(data));
        }

        protected virtual Task<T> UpdateData(T data) {
            return Task.Factory.StartNew(() => UpdateOperation(data));
        }

        protected virtual T InsertOperation(T data) {
            return data;
        }

        protected virtual T UpdateOperation(T data) {
            return data;
        }

        protected virtual void OnBeginSaveData(T data) {
            OnInitDataFields(data);
            OnSaveData(data);
        }

        protected virtual async void OnSaveData(T data) {
            try {
                var result = await SaveData(data);
                OnEndSaveData(result);
            } catch (Exception exc) {
                DialogMessages.Error(exc.Message);
            }
        }

        protected virtual void OnEndSaveData(T data) {
            Data = data;
            DialogResult = DialogResult.OK;
        }

        protected override void OnSaveClick() {
            OnValidateFormFields();
            if (IsValid()) {
                OnBeginSaveData(Data);
            }
        }
    }
}

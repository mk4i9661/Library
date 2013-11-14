using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;
using Ninject;
using Library.UI.DevExpressControls.Controls;
using System.Monads;
using Library.UI.DevExpressControls.Forms;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace Library.WindowsClient.Pages.Abstract
{
    interface IPage
    {
        XtraTabPage TabPage {
            get;
        }

        RibbonPage RibbonPage {
            get;
        }

        bool IsActive {
            get;
        }

        void Activate();

        void Deactivate();

        void AddClick();

        void EditClick();

        void DeleteClick();

        void ReloadClick();
    }

    abstract class Page<TContract, TNecessary, TData> : IPage
        where TData : class, IEquatable<TData>
    {
        [Inject]
        public IKernel Ninject {
            get;
            set;
        }

        public XtraTabPage TabPage {
            get;
            private set;
        }

        public RibbonPage RibbonPage {
            get;
            private set;
        }

        public bool IsActive {
            get;
            private set;
        }

        public LibraryGridControl GridControl {
            get;
            set;
        }

        protected Page(PageParameters parameters) {
            TabPage = parameters.TabPage;
            RibbonPage = parameters.RibbonPage;
            GridControl = parameters.GridControl;

            TabPage.Tag = this;
            RibbonPage.Tag = this;

            InitHandlers();
        }

        protected virtual void InitHandlers() {
            GridControl.Do(c => c.GridView.Do(v => v.RowCellClick += OnRowCellClick));
        }

        protected virtual void OnRowCellClick(object sender, RowCellClickEventArgs e) {
            if (e.Clicks > 1) {
                EditClick();
            }
        }

        public virtual void Activate() {
            IsActive = true;
            OnLoadNecessaryData();
        }

        public virtual void Deactivate() {
            IsActive = false;
        }

        protected virtual void OnBeginLoadNecessaryData() {

        }

        protected virtual async void OnLoadNecessaryData() {
            if (IsActive) {
                OnBeginLoadNecessaryData();
                var result = await LoadNecessaryData();
                OnEndLoadNecessaryData(result);
            }
        }

        protected virtual void OnEndLoadNecessaryData(TNecessary result) {
            OnLoadData();
        }

        protected virtual Task<TNecessary> LoadNecessaryData() {
            return Task.Factory.StartNew<TNecessary>(() => LoadNecessaryDataOperation());
        }

        protected virtual TNecessary LoadNecessaryDataOperation() {
            return default(TNecessary);
        }

        protected virtual void OnBeginLoadData() {

        }

        protected virtual void OnEndLoadData(IEnumerable<TData> result) {
            GridControl.Do(control => control.Bind(Filter(result)));
        }

        protected virtual IEnumerable<TData> Filter(IEnumerable<TData> data) {
            return data;
        }

        protected virtual async void OnLoadData(Action callback = null) {
            if (IsActive) {
                OnBeginLoadData();
                var result = await LoadData();
                OnEndLoadData(result);
                if (callback != null) {
                    callback();
                }
            }
        }

        protected virtual Task<IEnumerable<TData>> LoadData() {
            return Task.Factory.StartNew<IEnumerable<TData>>(() => LoadDataOperation());
        }

        protected virtual IEnumerable<TData> LoadDataOperation() {
            return new List<TData>();
        }

        protected TContract GetProxy() {
            return Ninject.Get<TContract>();
        }

        protected virtual TData GetSelectedRow() {
            return GridControl.Return(grid => grid.GridView.GetSelectedRow<TData>(), default(TData));
        }

        protected virtual TData GetRow(int index) {
            return GridControl.Return(grid => grid.GridView.GetRow<TData>(index), default(TData));
        }

        protected void ShowEditForm(TData data, EditFormOperation operation) {
            if (data != null) {
                var form = CreateEditForm();
                if (form != null) {
                    using (form) {
                        form.Operation = operation;
                        form.SetData(data);
                        if (form.ShowDialog() == DialogResult.OK) {
                            var result = form.Data;
                            OnLoadData(() => AfterModifyDataOperation(result));
                        }
                    }
                }
            }
        }

        protected virtual void AfterModifyDataOperation(TData data) {
            GridControl.GridView.SelectRow(data);
        }

        public virtual void AddClick() {
            ShowEditForm(CreateDefaultRow(), EditFormOperation.Insert);
        }

        public virtual void EditClick() {
            ShowEditForm(GetSelectedRow(), EditFormOperation.Update);
        }

        public virtual void DeleteClick() {
            var data = GetSelectedRow();
            if (data != null && DialogMessages.Question("Удалить выбранную запись?")) {
                OnDeleteData(data);
            }
        }

        protected virtual async void OnDeleteData(TData data) {
            try {
                var result = await DeleteData(data);
                OnLoadData();
            } catch (Exception exc) {
                DialogMessages.Error(exc.Message);
            }
        }

        public void ReloadClick() {
            OnLoadData();
        }

        protected Task<TData> DeleteData(TData data) {
            return Task.Factory.StartNew(() => DeleteOperation(data));
        }

        protected virtual TData DeleteOperation(TData data) {
            return data;
        }

        protected virtual TypedEditForm<TData> CreateEditForm() {
            return null;
        }

        protected virtual TData CreateDefaultRow() {
            return default(TData);
        }
    }

    class PageParameters
    {
        public RibbonPage RibbonPage {
            get;
            set;
        }

        public XtraTabPage TabPage {
            get;
            set;
        }

        public LibraryGridControl GridControl {
            get;
            set;
        }
    }
}

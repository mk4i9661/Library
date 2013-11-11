using Library.Contracts;
using Library.DataContracts.Concrete;
using Library.WindowsClient.Pages.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Monads;
using Library.UI.DevExpressControls.Controls;
using Ninject;
using Library.WindowsClient.EditForms;

namespace Library.WindowsClient.Pages.Concrete
{
    class RubricsPage : Page<IBibliographer, RubricsPage.LoadNecessaryDataWrap, Rubric>
    {
        IEnumerable<Rubric> LoadedRubrics {
            get;
            set;
        }

        public RubricsPage(PageParameters parameters)
            : base(parameters) {
            LoadedRubrics = new List<Rubric>();
            parameters.GridControl.ViewRegistered += GridControl_ViewRegistered;
        }

        public override void Activate() {
            base.Activate();
            Ninject.Rebind<RubricEditForm>().ToMethod(method => new RubricEditForm(LoadedRubrics));
        }

        void GridControl_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e) {
            var view = (LibraryGridView)e.View;
            view.RowCellClick += OnRowCellClick;
            view.OptionsView.ShowColumnHeaders = false;
            view.Columns.Clear();
            view.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() {
                FieldName = "Name",
                Visible = true
            });
        }

        protected override UI.DevExpressControls.Forms.TypedEditForm<Rubric> CreateEditForm() {
            return Ninject.Get<RubricEditForm>();
        }

        protected override Rubric CreateDefaultRow() {
            return new Rubric() {
                Parent = GetSelectedRow(),
                Childs = new List<Rubric>()
            };
        }

        protected override IEnumerable<Rubric> LoadDataOperation() {
            var proxy = GetProxy();
            var rubrics = Task.Factory.StartNew(() => proxy.GetRubrics());
            var hierarchy = Task.Factory.StartNew(() => proxy.GetRubricsHierarchy());

            Task.WaitAll(rubrics, hierarchy);
            LoadedRubrics = rubrics.Result;
            return hierarchy.Result;
        }

        protected override Rubric GetSelectedRow() {
            return (GridControl.FocusedView as LibraryGridView).With(v => v.GetSelectedRow<Rubric>());
        }

        protected override Rubric DeleteOperation(Rubric data) {
            return GetProxy().DeleteRubric(data);
        }

        internal class LoadNecessaryDataWrap
        {
            public IEnumerable<Rubric> Rubrics {
                get;
                set;
            }
        }
    }
}

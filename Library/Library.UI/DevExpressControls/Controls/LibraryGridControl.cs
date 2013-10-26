using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Handler;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Library.UI.DevExpressControls.Controls
{
    public class LibraryGridControl : GridControl
    {
        protected override BaseView CreateDefaultView() {
            return CreateView("SimpleGridView");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new LibraryGridViewRegistrator());
        }

        public LibraryGridView GridView {
            get {
                return MainView as LibraryGridView;
            }
        }

        /// <summary>
        /// Привязка данных к таблице
        /// </summary>
        public void Bind(object data) {
            BeginUpdate();
            DataSource = data;
            EndUpdate();
        }

    }

    public class LibraryGridView : GridView
    {
        public LibraryGridView()
            : this(null) {
        }

        public LibraryGridView(GridControl gc)
            : base(gc) {
            OptionsBehavior.ReadOnly = true;
            OptionsBehavior.Editable = false;
            OptionsCustomization.AllowFilter = false;
            OptionsCustomization.AllowQuickHideColumns = false;
            FocusRectStyle = DrawFocusRectStyle.None;
            OptionsMenu.EnableColumnMenu = false;
            OptionsMenu.EnableFooterMenu = false;
            OptionsMenu.EnableGroupPanelMenu = false;
            OptionsSelection.EnableAppearanceFocusedCell = false;
            OptionsView.ShowGroupPanel = false;
            OptionsDetail.AllowZoomDetail = false;
            OptionsDetail.ShowDetailTabs = false;

            Appearance.HeaderPanel.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            Appearance.Row.Font = new Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point);
        }

        protected override string ViewName {
            get {
                return "SimpleGridView";
            }
        }

        /// <summary>
        /// Получить строку по ее номеру
        /// </summary>
        public T GetRow<T>(int index) where T : class {
            return GetRow(index) as T;
        }

        /// <summary>
        /// Получить текущую выделенную строку
        /// </summary>
        public T GetSelectedRow<T>() where T : class {
            return GetRow<T>(FocusedRowHandle);
        }

        /// <summary>
        /// Выбрать строку в соответствии с шаблоном
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elem"></param>
        public virtual void SelectRow<T>(T elem) where T : class, IEquatable<T> {
            var data = DataSource as List<T>;
            if (data != null) {
                for (int i = 0; i < data.Count; i++) {
                    if (GetRow<T>(i).Equals(elem)) {
                        FocusedRowHandle = i;
                        break;
                    }
                }
            }
        }
    }

    public class LibraryGridViewRegistrator : GridInfoRegistrator
    {
        public override string ViewName {
            get {
                return "SimpleGridView";
            }
        }

        public override BaseView CreateView(GridControl grid) {
            var result = new LibraryGridView(grid);
            return result;
        }

        public override DevExpress.XtraGrid.Views.Base.ViewInfo.BaseViewInfo CreateViewInfo(BaseView view) {
            return new LibraryGridViewInfo(view as GridView);
        }

        public override DevExpress.XtraGrid.Views.Base.Handler.BaseViewHandler CreateHandler(BaseView view) {
            return new LibraryGridViewHandler(view as GridView);
        }

    }

    public class LibraryGridViewInfo : GridViewInfo
    {
        public LibraryGridViewInfo(GridView view)
            : base(view) {
        }
    }

    public class LibraryGridViewHandler : GridHandler
    {
        public LibraryGridViewHandler(GridView view)
            : base(view) {
        }
    }

}

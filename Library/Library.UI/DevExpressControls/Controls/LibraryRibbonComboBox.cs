using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UI.DevExpressControls.Controls
{
    /// <summary>
    /// Обертка для выпадающих списков ленточного интерфейса
    /// </summary>
    public class LibraryRibbonComboBox
    {
        /// <summary>
        /// Сам элемент ленты
        /// </summary>
        BarEditItem _this;
        /// <summary>
        /// Объект редактора элемента
        /// </summary>
        RepositoryItemComboBox _comboBox;

        /// <summary>
        /// Изменилось значение выпадающего списка
        /// </summary>
        public event EventHandler EditValueChanged;

        public LibraryRibbonComboBox(BarEditItem item) {
            _this = item;
            _comboBox = (RepositoryItemComboBox)item.Edit;
            _comboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            _comboBox.DropDownRows = 15;
            _this.EditValueChanged += new EventHandler(OnEditValueChanged);
        }

        void OnEditValueChanged(object sender, EventArgs e) {
            if (EditValueChanged != null)
                EditValueChanged(sender, e);
        }

        /// <summary>
        /// Привязать к выпадающему списку элементы
        /// </summary>
        /// <param name="data">Элементы для привязки</param>
        /// <param name="converter">Конвертация объектов в строковое представление</param>
        public void Bind<T>(IEnumerable<T> data, Func<T, string> converter) {
            var items = _comboBox.Items;
            items.BeginUpdate();
            items.Clear();
            items.AddRange((from item in data
                            select new SimpleComboBoxData<T>(item, converter)).ToArray());
            items.EndUpdate();
        }

        /// <summary>
        /// Объекты списка
        /// </summary>
        DevExpress.XtraEditors.Controls.ComboBoxItemCollection Items {
            get {
                return _comboBox.Items;
            }
        }

        /// <summary>
        /// Текущий выбранный элемент выпадающего списка
        /// </summary>
        public T GetSelectedElement<T>() {
            var value = _this.EditValue as SimpleComboBoxData<T>;
            return value == null ? default(T) : value.Data;
        }

        /// <summary>
        /// Выбрать первый элемент выпадающего списка, если имеется
        /// </summary>
        public T SelectFirstElement<T>() {
            try {
                _this.BeginUpdate();
                var items = Items;
                if (items.Count > 0) {
                    _this.EditValue = items[0];
                    return GetSelectedElement<T>();
                } else
                    _this.EditValue = null;
                return default(T);
            } finally {
                _this.EndUpdate();
            }
        }

        /// <summary>
        /// Выбрать элемент списка
        /// </summary>
        /// <param name="element">Элемент эталон. С ним будут сравниваться остальные элементы</param>
        public void SelectElement<T>(T element) where T : IEquatable<T> {
            if (element == null) {
                SelectFirstElement<T>();
                return;
            }
            var items = Items;
            for (int i = 0; i < items.Count; i++) {
                var item = (SimpleComboBoxData<T>)items[i];
                if (item.Data.Equals(element)) {
                    _this.EditValue = item;
                    break;
                }
            }
        }

        /// <summary>
        /// Выбрать элемент списка в соответствии с условием
        /// </summary>
        /// <param name="equility">Условие выбора элемента</param>
        /// <returns>Выбранный элемент</returns>
        public T SelectElement<T>(Func<T, bool> equility) {
            var items = Items;
            for (int i = 0; i < items.Count; i++) {
                var item = (SimpleComboBoxData<T>)items[i];
                if (equility(item.Data)) {
                    _this.EditValue = item;
                    return item.Data;
                }
            }
            return default(T);
        }

        /// <summary>
        /// Добавить в выпадающий список элементы, выбрать элемент и возвратить выбранный
        /// </summary>
        public T Bind<T>(List<T> data, Func<T, string> converter, T element) where T : IEquatable<T> {
            Bind<T>(data, converter);
            if (element != null) {
                element = data.FirstOrDefault(e => e.Equals(element));
                if (element != null) {
                    int index = data.IndexOf(element);
                    if (index > -1) {
                        _this.BeginUpdate();
                        _this.EditValue = Items[index];
                        _this.EndUpdate();
                        return GetSelectedElement<T>();
                    } else
                        return SelectFirstElement<T>();
                } else
                    return SelectFirstElement<T>();
            } else
                return SelectFirstElement<T>();
        }

        public int SelectedIndex {
            get {
                return _comboBox.Items.IndexOf(_this.EditValue);
            }
        }
    }
}

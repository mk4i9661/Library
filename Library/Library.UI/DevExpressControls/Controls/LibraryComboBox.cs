using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace Library.UI.DevExpressControls.Controls
{
    public class LibraryComboBox : ComboBoxEdit
    {
        public LibraryComboBox() {
            Properties.DropDownRows = 15;
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            Font = new Font("Tahoma", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        /// <summary>
        /// Добавить в выпадающий список элементы
        /// </summary>
        /// <param name="data">Элементы для добавления</param>
        /// <param name="converter">Функция конвертации объекта в его строковое представление</param>
        public void Bind<T>(List<T> data, Func<T, string> converter) {
            BeginUpdate();
            Properties.Items.Clear();
            Properties.Items.AddRange((from elem in data
                                       select new SimpleComboBoxData<T>(elem, converter)).ToArray());
            EndUpdate();
        }

        /// <summary>
        /// Выбрать элемент списка в соответствии с выбранным шаблоном
        /// </summary>
        /// <param name="element">Шаблон</param>
        public void SelectElement<T>(T element) where T : IEquatable<T> {
            if (element == null) {
                SelectFirstElement<T>();
                return;
            }
            var items = Properties.Items;
            for (int i = 0; i < items.Count; i++) {
                var item = (SimpleComboBoxData<T>)items[i];
                if (item.Data.Equals(element)) {
                    EditValue = item;
                    break;
                }
            }
        }

        /// <summary>
        /// Выбрать элемент в соответствии с условием
        /// </summary>
        /// <param name="equility">Условие для выбора</param>
        /// <returns>Выбранный элемент</returns>
        public T SelectElement<T>(Func<T, bool> equility) {
            var items = Properties.Items;
            for (int i = 0; i < items.Count; i++) {
                var item = (SimpleComboBoxData<T>)items[i];
                if (equility(item.Data)) {
                    EditValue = item;
                    return item.Data;
                }
            }
            return default(T);
        }

        /// <summary>
        /// Получить выбранный элемент выпадающего списка
        /// </summary>
        public T GetSelectedElement<T>() {
            var value = (SimpleComboBoxData<T>)SelectedItem;
            return value == null ? default(T) : value.Data;
        }

        /// <summary>
        /// Выбрать первый элемент в списке и возвратить его
        /// </summary>
        public T SelectFirstElement<T>() {
            var items = Properties.Items;
            if (items.Count > 0) {
                EditValue = items[0];
                return GetSelectedElement<T>();
            } else {
                EditValue = null;
            }
            return default(T);
        }

        /// <summary>
        /// Добавить элементы в выпадающий список, выбрать в соответствии с шаблоном и возвратить выбранный
        /// </summary>
        public T Bind<T>(List<T> data, Func<T, string> converter, T elem) where T : IEquatable<T> {
            Bind<T>(data, converter);
            if (elem != null) {
                elem = data.FirstOrDefault(e => elem.Equals(e));
                if (elem != null) {
                    int index = data.IndexOf(elem);
                    if (index > -1) {
                        EditValue = Properties.Items[index];
                        return GetSelectedElement<T>();
                    } else
                        return SelectFirstElement<T>();
                } else
                    return SelectFirstElement<T>();
            } else
                return SelectFirstElement<T>();
        }
    }

    /// <summary>
    /// Обертка для данных выпадающего списка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SimpleComboBoxData<T>
    {
        public SimpleComboBoxData(T data, Func<T, string> converter) {
            Data = data;
            Converter = converter;
        }

        /// <summary>
        /// Данные выпадающего списка
        /// </summary>
        public T Data {
            get;
            private set;
        }

        /// <summary>
        /// Функция для представления элемента в строковом значении
        /// </summary>
        public Func<T, string> Converter {
            get;
            private set;
        }

        public override string ToString() {
            return Converter(Data);
        }
    }
}

using System.Runtime.Serialization;

namespace Library.DataContracts.Abstract
{
    /// <summary>
    /// Объект, имеющий целочисленный уникальный идентификатор
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [DataContract]
    public abstract class UniqueObjectInt<T> : UniqueObject<int, T> where T : UniqueObject<int, T>
    {

        protected UniqueObjectInt()
            : base() {

        }

        protected UniqueObjectInt(int id)
            : base(id) {

        }

        #region Реализация интерфейсов
        public override int CompareTo(T other) {
            return Id - other.Id;
        }

        public override bool Equals(T other) {
            return Id == other.Id;
        }

        public override int Compare(T x, T y) {
            return x.Id - y.Id;
        }
        #endregion
    }
}

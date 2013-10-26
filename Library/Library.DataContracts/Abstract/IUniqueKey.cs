namespace Library.DataContracts.Abstract
{
    public interface IUniqueKey<T>
    {
        /// <summary>
        /// ”никальный идентификатор, характеризующий объект
        /// </summary>
        T Id {
            get;
            set;
        }
    }
}

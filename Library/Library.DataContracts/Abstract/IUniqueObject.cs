using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Library.DataContracts.Abstract
{
    /// <summary>
    /// ”никальный объект
    /// </summary>
    public interface IUniqueObject<T> : IComparer<T>, IComparable<T>, IEquatable<T>
    {

    }

    /// <summary>
    /// ”никальный объект, имеющий уникальный идентификатор
    /// </summary>
    public interface IUniqueObject<T, V> : IUniqueKey<T>, IUniqueObject<V>
    {

    }
}

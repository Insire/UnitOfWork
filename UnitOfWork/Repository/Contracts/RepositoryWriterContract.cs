﻿namespace Repository.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using BaseDataModel;

    using static System.Diagnostics.Contracts.Contract;

    [ContractClassFor(typeof(IRepositoryWriter<>))]
    internal sealed class RepositoryWriterContract<T>: IRepositoryWriter<T> where T : class, IDataModel, new()
    {
        T IRepositoryWriter<T>.Insert(T item)
        {
            Requires<ArgumentNullException>(item != null, "item can't be null");

            return default(T);
        }

        IEnumerable<T> IRepositoryWriter<T>.InsertRange(IEnumerable<T> items)
        {
            Requires<ArgumentNullException>(items != null, "items can't be null");
            Requires<ArgumentException>(items.Any(), "items count should be greater than zero");

            return default(IEnumerable<T>);
        }

        void IRepositoryWriter<T>.Update(T item)
        {
            Requires<ArgumentNullException>(item != null, "item can't be null");
        }

        T IRepositoryWriter<T>.Delete(Guid id)
        {
            return default(T);
        }

        T IRepositoryWriter<T>.Delete(T item)
        {
            Requires<ArgumentNullException>(item != null, "item can't be null");

            return default(T);
        }
    }
}
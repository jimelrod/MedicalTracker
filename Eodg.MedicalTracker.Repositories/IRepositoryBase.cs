using System;
using System.Collections.Generic;
using System.Linq;
using Eodg.MedicalTracker.Data;

namespace Eodg.MedicalTracker.Repositories
{
    public interface IRepositoryBase<T>
    {
        MedicalTrackerContext MedicalTrackerContext { get; }

        IQueryable<T> Get();
        T Get(Guid id);
        IEnumerable<T> Get(Func<T, bool> whereClause);
        IOrderedEnumerable<T> Get(Func<T, bool> whereClause, Func<T, Guid> orderBy);
        IOrderedEnumerable<T> Get(Func<T, Guid> orderBy);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        void Delete(Guid id);
    }
}
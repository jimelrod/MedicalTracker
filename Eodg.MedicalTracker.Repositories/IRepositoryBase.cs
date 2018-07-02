using System;
using System.Collections.Generic;
using Eodg.MedicalTracker.Data;

namespace Eodg.MedicalTracker.Repositories
{
    public interface IRepositoryBase<T>
    {
        MedicalTrackerContext MedicalTrackerContext { get; }
        
        List<T> Get();
        T Get(Guid id);
        List<T> Get(Func<T, bool> whereClause);
        List<T> Get(Func<T, bool> whereClause, Func<T, Guid> orderBy);
        List<T> Get(Func<T, Guid> orderBy);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        void Delete(Guid id);
    }
}
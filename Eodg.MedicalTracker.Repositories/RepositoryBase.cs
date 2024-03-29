using System;
using System.Collections.Generic;
using System.Linq;
using Eodg.MedicalTracker.Data;
using Eodg.MedicalTracker.Data.Models;

namespace Eodg.MedicalTracker.Repositories
{
    // TODO: All async methods...

    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private MedicalTrackerContext _medicalTrackerContext;

        public RepositoryBase(MedicalTrackerContext medicalTrackerContext)
        {
            _medicalTrackerContext = medicalTrackerContext;
        }

        public MedicalTrackerContext MedicalTrackerContext
        {
            get { return _medicalTrackerContext; }
            private set { _medicalTrackerContext = value; }
        }

        public virtual IQueryable<T> Get()
        {
            return _medicalTrackerContext.Set<T>();
        }

        public virtual T Get(Guid id)
        {
            return _medicalTrackerContext.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> Get(Func<T, bool> whereClause)
        {
            return _medicalTrackerContext.Set<T>().Where(whereClause);
        }

        public virtual IOrderedEnumerable<T> Get(Func<T, bool> whereClause, Func<T, Guid> orderBy)
        {
            return _medicalTrackerContext.Set<T>().Where(whereClause).OrderBy(orderBy);
        }

        public virtual IOrderedEnumerable<T> Get(Func<T, Guid> orderBy)
        {
            return _medicalTrackerContext.Set<T>().OrderBy(orderBy);
        }

        public virtual T Add(T entity)
        {
            _medicalTrackerContext.Add<T>(entity);
            _medicalTrackerContext.SaveChanges();

            return entity;
        }

        public virtual T Update(T entity)
        {
            _medicalTrackerContext.Update<T>(entity);
            _medicalTrackerContext.SaveChanges();

            return entity;
        }

        public virtual void Delete(T entity)
        {
            _medicalTrackerContext.Remove(entity);
            _medicalTrackerContext.SaveChanges();
        }

        public virtual void Delete(Guid id)
        {
            Delete(Get(id));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RutaPro.Common.Data.Repository
{
    public interface IBaseRepository<T, TKey> where T : class
    {
        void Save(T entity);
        void Update(T entity);
        void Remove(T entity);
        List<T> GetAll();
        T GetEntityBy(TKey id);
        bool Exist(Expression<Func<T, bool>> filter);
    }
}
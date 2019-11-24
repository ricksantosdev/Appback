using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.ApplicationCore.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity AddEntity(TEntity entity);

        TEntity UpdateEntity(TEntity entity);

        IEnumerable<TEntity> GetALl();

        TEntity GetEntityById(int id);

        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);

        void DeleteEntity(TEntity entity);
    }
}

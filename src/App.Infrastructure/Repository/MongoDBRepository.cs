using App.ApplicationCore.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.Infrastructure.Repository
{
    public class MongoDBRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public TEntity AddEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetALl()
        {
            throw new NotImplementedException();
        }

        public TEntity GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity UpdateEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

using App.ApplicationCore.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using App.Infrastructure.Data;
using System.Linq;

namespace App.Infrastructure.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationContext _appContext;


        public EFRepository(ApplicationContext context)
        {
            _appContext = context;
        }


        public virtual TEntity AddEntity(TEntity entity)
        {
            _appContext.Set<TEntity>().Add(entity);
            _appContext.SaveChanges();
            return entity;
        }

        public virtual void DeleteEntity(TEntity entity)
        {
            _appContext.Set<TEntity>().Remove(entity);
        }

        public IEnumerable<TEntity> GetALl()
        {
            return _appContext.Set<TEntity>().AsEnumerable();
        }

        public virtual TEntity GetEntityById(int id)
        {
            return _appContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return _appContext.Set<TEntity>().Where(predicate).AsEnumerable();
        }

        public virtual TEntity UpdateEntity(TEntity entity)
        {
            _appContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appContext.SaveChanges();

            return entity;
        }
    }
}

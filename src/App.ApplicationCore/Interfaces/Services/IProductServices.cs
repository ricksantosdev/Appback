using App.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.ApplicationCore.Interfaces.Services
{
    public interface IProductServices
    {
        Product AddEntity(Product entity);

        Product UpdateEntity(Product entity);

        IEnumerable<Product> GetALl();

        Product GetEntityById(int id);

        IEnumerable<Product> Search(Expression<Func<Product, bool>> predicate);

        void DeleteEntity(Product entity);
    }
}

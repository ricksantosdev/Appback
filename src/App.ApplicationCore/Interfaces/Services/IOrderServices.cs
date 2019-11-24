using App.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.ApplicationCore.Interfaces.Services
{
    public interface IOrderServices
    {
        Order AddEntity(Order entity);

        Order UpdateEntity(Order entity);

        IEnumerable<Order> GetALl();

        Order GetEntityById(int id);

        IEnumerable<Order> Search(Expression<Func<Order, bool>> predicate);

        void DeleteEntity(Order entity);

        public List<Product> GetProductOrder(int id);
    }
}

using App.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.ApplicationCore.Interfaces.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        public List<Product> GetProductOrder(int id);
    }
}

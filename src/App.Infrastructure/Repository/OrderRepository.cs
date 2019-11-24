using App.ApplicationCore.Entity;
using App.ApplicationCore.Interfaces.Repository;
using App.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace App.Infrastructure.Repository
{
    public class OrderRepository : EFRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationContext appContext) : base(appContext)
        {

        }

        public override Order GetEntityById(int id)
        {
            Order order = base.GetEntityById(id);
            if (order != null) order.Client = _appContext.Set<Client>().Where(o => o.ClientId == order.ClientId).FirstOrDefault();

            return order;
        }

        public List<Product> GetProductOrder(int id)
        {
            List<OrderProducts> orderProducts = _appContext.Set<OrderProducts>().Where(x => x.OrderId == id).ToList();
            List<Product> prods = new List<Product>();
            foreach (var item in orderProducts)
            {
                Product p = _appContext.Set<Product>().Where(o => o.Id == item.ProductId).FirstOrDefault();
                Price price = _appContext.Set<Price>().Where(o => o.PriceId == p.PriceId).FirstOrDefault();
                p.Price = price;

                prods.Add(p);
            }

            return prods;
        }
    }
}

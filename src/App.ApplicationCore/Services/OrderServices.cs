using App.ApplicationCore.Entity;
using App.ApplicationCore.Interfaces.Repository;
using App.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.ApplicationCore.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IProductRepository _productRepository;

        public OrderServices(IOrderRepository orderRepository, IClientRepository clientRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _clientRepository = clientRepository;
            _productRepository = productRepository;
        }
        public Order AddEntity(Order entity)
        {
            return _orderRepository.AddEntity(entity);
        }

        public void DeleteEntity(Order entity)
        {
            _orderRepository.DeleteEntity(entity);
        }

        public IEnumerable<Order> GetALl()
        {
            return _orderRepository.GetALl();
        }

        public Order GetEntityById(int id)
        {
            Order order = _orderRepository.GetEntityById(id);

            return order;
        }

        public List<Product> GetProductOrder(int id)
        {
            return _orderRepository.GetProductOrder(id);
        }

        public IEnumerable<Order> Search(Expression<Func<Order, bool>> predicate)
        {
            return _orderRepository.Search(predicate);
        }

        public Order UpdateEntity(Order entity)
        {
            return _orderRepository.UpdateEntity(entity);
        }
    }
}

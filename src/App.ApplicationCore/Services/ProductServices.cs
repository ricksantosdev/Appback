using App.ApplicationCore.Entity;
using App.ApplicationCore.Interfaces.Repository;
using App.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.ApplicationCore.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _productRepository;
        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product AddEntity(Product entity)
        {
            return _productRepository.AddEntity(entity);
        }

        public void DeleteEntity(Product entity)
        {
            _productRepository.DeleteEntity(entity);
        }

        public IEnumerable<Product> GetALl()
        {
            return _productRepository.GetALl();
        }

        public Product GetEntityById(int id)
        {
            return _productRepository.GetEntityById(id);
        }

        public IEnumerable<Product> Search(Expression<Func<Product, bool>> predicate)
        {
            return _productRepository.Search(predicate);
        }

        public Product UpdateEntity(Product entity)
        {
            return _productRepository.UpdateEntity(entity);
        }
    }
}

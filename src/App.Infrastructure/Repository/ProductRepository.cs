using App.ApplicationCore.Entity;
using App.ApplicationCore.Interfaces.Repository;
using App.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.Infrastructure.Repository
{
    public class ProductRepository : EFRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext appContext) : base(appContext)
        {
       
        }
    }
}

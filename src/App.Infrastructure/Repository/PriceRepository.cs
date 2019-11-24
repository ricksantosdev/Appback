using App.ApplicationCore.Entity;
using App.ApplicationCore.Interfaces.Repository;
using App.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.Infrastructure.Repository
{
    public class PriceRepository : EFRepository<Price>,  IPriceRepository
    {
        public PriceRepository(ApplicationContext appContext) : base(appContext)
        {
       
        }
    }
}

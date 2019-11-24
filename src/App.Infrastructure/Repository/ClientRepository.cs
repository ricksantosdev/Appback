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
    public class ClientRepository : EFRepository<Client>, IClientRepository
    {
        public ClientRepository(ApplicationContext appContext) : base(appContext)
        {

        }

        public Client GetClientByCpf(decimal cpf)
        {
            return _appContext.Set<Client>().Where(x => x.Cpf == cpf).FirstOrDefault();
        }
    }
}

using App.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.ApplicationCore.Interfaces.Repository
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetClientByCpf(decimal cpf);
    }
}

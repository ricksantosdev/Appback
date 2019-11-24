using App.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.ApplicationCore.Interfaces.Services
{
    public interface IClientServices
    {
        Client AddEntity(Client entity);

        Client UpdateEntity(Client entity);

        IEnumerable<Client> GetALl();

        Client GetEntityById(int id);

        IEnumerable<Client> Search(Expression<Func<Client, bool>> predicate);

        void DeleteEntity(Client entity);

        Client GetClientByCpf(decimal cpf);
    }
}

using App.ApplicationCore.Entity;
using App.ApplicationCore.Interfaces.Repository;
using App.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace App.ApplicationCore.Services
{
    public class ClientServices : IClientServices
    {
        private readonly IClientRepository _clientRepository;
        public ClientServices(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Client AddEntity(Client entity)
        {
            return _clientRepository.AddEntity(entity);
        }

        public void DeleteEntity(Client entity)
        {
            _clientRepository.DeleteEntity(entity);
        }

        public IEnumerable<Client> GetALl()
        {
            return _clientRepository.GetALl();
        }

        public Client GetClientByCpf(decimal cpf)
        {
            return _clientRepository.GetClientByCpf(cpf);
        }

        public Client GetEntityById(int id)
        {
            return _clientRepository.GetEntityById(id);
        }

        public IEnumerable<Client> Search(Expression<Func<Client, bool>> predicate)
        {
            return _clientRepository.Search(predicate);
        }

        public Client UpdateEntity(Client entity)
        {
            return _clientRepository.UpdateEntity(entity);
        }
    }
}

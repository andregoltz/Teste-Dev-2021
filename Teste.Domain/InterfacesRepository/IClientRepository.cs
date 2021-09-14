using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Domain.InterfacesRepository
{
    public interface IClientRepository: IRepository<Client>
    {
        IEnumerable<Client> GetAll();
    }
}

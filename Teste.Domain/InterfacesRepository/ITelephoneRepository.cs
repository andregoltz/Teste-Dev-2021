using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Domain.InterfacesRepository
{
    public interface ITelephoneRepository : IRepository<ClientsTelephone>
    {
        List<ClientsTelephone> GetAllById(string guid);
    }
}

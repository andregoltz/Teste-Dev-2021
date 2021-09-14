using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;
using Teste.Domain.InterfacesRepository;

namespace Teste.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(TesteContext context)
            :base(context) { }

        public IEnumerable<Client> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}

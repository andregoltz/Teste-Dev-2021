using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain;
using Teste.Domain.InterfacesRepository;

namespace Teste.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(TesteContext context)
            : base(context) { }
    }
}

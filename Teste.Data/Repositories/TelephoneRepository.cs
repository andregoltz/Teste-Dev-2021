using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;
using Teste.Domain.InterfacesRepository;

namespace Teste.Data.Repositories
{
    public class TelephoneRepository :  Repository<ClientsTelephone>, ITelephoneRepository
    {
        public TelephoneRepository(TesteContext context)
            :base(context)
        { }

        public List<ClientsTelephone> GetAllById(string id)
        {
            if (!Guid.TryParse(id, out Guid idTelephone))
                throw new Exception("TelephoneID is not valid");

            var Queryresult = Query(x => !x.IsDeleted && x.IdClient == idTelephone);

            List<ClientsTelephone> clientes = new List<ClientsTelephone>();

            foreach (var result in Queryresult)
            {
                clientes.Add(result);
            }
            return clientes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Teste.Application.ViewModels;

namespace Teste.Application.Interfaces
{
    public interface IClientService
    {
        List<ClientViewModel> Get();
        bool Post(ClientViewModel clientViewModel);
        ClientViewModel GetById(string id);
        bool Put(ClientViewModel clientViewModel);
        bool Delete(string id);
    }
}

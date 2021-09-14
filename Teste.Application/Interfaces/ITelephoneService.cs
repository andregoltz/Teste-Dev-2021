using System;
using System.Collections.Generic;
using System.Text;
using Teste.Application.ViewModels;

namespace Teste.Application.Interfaces
{
    public interface ITelephoneService
    {
        void Get();
        bool Post(TelephonesViewModel telephonesViewModel);
        List<TelephonesViewModel> GetById(string id);
        bool Delete(string id);
    }
}

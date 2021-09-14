using System;
using System.Collections.Generic;
using System.Text;
using Teste.Application.ViewModels;

namespace Teste.Application.Interfaces
{
    public interface IUserService
    {
        bool Post(UserViewModel userViewModel);
        UserViewModel GetById(string id);
        bool Put(UserViewModel userViewModel);
        UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user);
    }
}

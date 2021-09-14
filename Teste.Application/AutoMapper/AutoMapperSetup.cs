using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Application.ViewModels;
using Teste.Domain;
using Teste.Domain.Entities;

namespace Teste.Application.AutoMapper
{
    public class AutoMapperSetup: Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain
            CreateMap<UserViewModel, User>();
            CreateMap<ClientViewModel, Client>();
            CreateMap<TelephonesViewModel, ClientsTelephone>();
            #endregion

            #region DomainToViewModel
            CreateMap<User, UserViewModel>();
            CreateMap<Client, ClientViewModel>();
            CreateMap<ClientsTelephone, TelephonesViewModel>();
            #endregion
        }
    }
}

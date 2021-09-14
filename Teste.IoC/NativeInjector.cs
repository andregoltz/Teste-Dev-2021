using Microsoft.Extensions.DependencyInjection;
using System;
using Teste.Application;
using Teste.Application.Interfaces;
using Teste.Application.Services;
using Teste.Data.Repositories;
using Teste.Domain.InterfacesRepository;

namespace Teste.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Service
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<ITelephoneService, TelephoneService>();
            #endregion

            #region Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<ITelephoneRepository, TelephoneRepository>();
            #endregion
        }
    }
}

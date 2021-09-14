using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Application.Interfaces;
using Teste.Application.ViewModels;
using Teste.Domain.Entities;
using Teste.Domain.InterfacesRepository;

namespace Teste.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;
        private readonly IMapper mapper;
        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            this.clientRepository = clientRepository;
            this.mapper = mapper;
        }
        public List<ClientViewModel> Get()
        {
            List<ClientViewModel> _clientViewModels = new List<ClientViewModel>();

            IEnumerable<Client> _clients = this.clientRepository.GetAll();

            _clientViewModels = mapper.Map<List<ClientViewModel>>(_clients);

            foreach (ClientViewModel client in _clientViewModels)
            {
                client.BirthDate = DateTime.Parse(client.BirthDate).ToString("dd/MM/yyyy");
            }

            return _clientViewModels;

        }

        public bool Post(ClientViewModel clientViewModel)
        {
            Client _client = this.clientRepository.Find(x => x.CPF == clientViewModel.CPF && !x.IsDeleted);
            if (_client == null)
            {
                _client = mapper.Map<Client>(clientViewModel);

                this.clientRepository.Create(_client);

                return true;
            }
            else
            {
                throw new Exception("Client already exists!");
            }
        }

        public ClientViewModel GetById(string id)
        {
            if (!Guid.TryParse(id, out Guid clientid))
                throw new Exception("ClientID is not valid");

            Client _client = this.clientRepository.Find(x => x.Id == clientid && !x.IsDeleted);

            if (_client == null)
                throw new Exception("Client not found");

            ClientViewModel _clientViewModels =  mapper.Map<ClientViewModel>(_client);

            _clientViewModels.BirthDate = DateTime.Parse(_clientViewModels.BirthDate).ToString("yyyy-MM-dd");

            return _clientViewModels;
        }

        public bool Put(ClientViewModel clientViewModel)
        {
            Client _client = this.clientRepository.Find(x => x.Id == clientViewModel.Id && !x.IsDeleted);
            if (_client == null)
                throw new Exception("Client not found");

            _client = mapper.Map<Client>(clientViewModel);

            this.clientRepository.Update(_client);

            return true;
        }

        public bool Delete(string id)
        {
            if (!Guid.TryParse(id, out Guid clientid))
                throw new Exception("ClientID is not valid");

            Client _client = this.clientRepository.Find(x => x.Id == clientid && !x.IsDeleted);

            if (_client == null)
                throw new Exception("Client not found");

            return this.clientRepository.Delete(_client);
        }
    }
}

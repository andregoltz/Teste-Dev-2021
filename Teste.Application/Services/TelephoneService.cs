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
    public class TelephoneService : ITelephoneService
    {
        private readonly ITelephoneRepository telephoneRepository;
        private readonly IMapper mapper;
        public TelephoneService(ITelephoneRepository telephoneRepository, IMapper mapper)
        {
            this.telephoneRepository = telephoneRepository;
            this.mapper = mapper;
        }

        public void Get()
        {
            //List<TelephonesViewModel> _telephonesViewModels = new List<TelephonesViewModel>();

            //IEnumerable<ClientsTelephone> _telephones = this.telephoneRepository.GetAll();

            //_telephonesViewModels = mapper.Map<List<TelephonesViewModel>>(_telephones);

            //return _telephonesViewModels;
        }

        public bool Post(TelephonesViewModel telephonesViewModel)
        {
            ClientsTelephone _telephone = this.telephoneRepository.Find(x => x.DDD == telephonesViewModel.DDD && x.TelephoneNumber == telephonesViewModel.TelephoneNumber && !x.IsDeleted);

            if (_telephone == null)
            {
                _telephone = mapper.Map<ClientsTelephone>(telephonesViewModel);

                this.telephoneRepository.Create(_telephone);

                return true;
            }
            else
            {
                throw new Exception("Telephone already exists!");
            }

        }

        public List<TelephonesViewModel> GetById(string id)
        {
            //if (!Guid.TryParse(id, out Guid idTelephone))
            //    throw new Exception("TelephoneID is not valid");

            List<ClientsTelephone> _telephone = telephoneRepository.GetAllById(id);

            if (_telephone == null)
                throw new Exception("Telephone not found");

            List<TelephonesViewModel> _telephonesViewModels = new List<TelephonesViewModel>();

            _telephonesViewModels = mapper.Map<List<TelephonesViewModel>>(_telephone);

            return _telephonesViewModels;
        }

        public bool Delete(string id)
        {
            if (!int.TryParse(id, out int idTelephone))
                throw new Exception("TelephoneID is not valid");

            ClientsTelephone _telephone = this.telephoneRepository.Find(x => x.Id == idTelephone && !x.IsDeleted);

            if (_telephone == null)
                throw new Exception("Telephone not found!");

            return this.telephoneRepository.Delete(_telephone);
        }
    }
}

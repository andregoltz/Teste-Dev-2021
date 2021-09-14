using AutoMapper;
using System;
using System.Security.Cryptography;
using System.Text;
using Teste.Application.Interfaces;
using Teste.Application.ViewModels;
using Teste.Auth.Services;
using Teste.Domain;
using Teste.Domain.InterfacesRepository;

namespace Teste.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public bool Post(UserViewModel userViewModel)
        {
            User _user = this.userRepository.Find(x => x.Email.ToLower() == userViewModel.Email.ToLower() && !x.IsDeleted);

            if (_user == null)
            {
                _user = mapper.Map<User>(userViewModel);
                _user.Password = EncryptPassword(_user.Password);

                this.userRepository.Create(_user);

                return true;
            }
            else
            {
                throw new Exception("User already exists!");
            }
        }

        public UserViewModel GetById(string id)
        {
            if (!Guid.TryParse(id, out Guid userid))
                throw new Exception("UserID is not valid");

            User _user = this.userRepository.Find(x => x.Id == userid && !x.IsDeleted);

            if (_user == null)
                throw new Exception("User not found");

            return mapper.Map<UserViewModel>(_user);
        }

        public bool Put(UserViewModel userViewModel)
        {
            User _user = this.userRepository.Find(x => x.Id == userViewModel.Id && !x.IsDeleted);
            if (_user == null)
                throw new Exception("User not found");

            _user = mapper.Map<User>(userViewModel);
            _user.Password = EncryptPassword(_user.Password);

            this.userRepository.Update(_user);
            return true;
        }

        public UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
                throw new Exception("Email/Password are required.");

            user.Password = EncryptPassword(user.Password);

            User _user = this.userRepository.Find(x => !x.IsDeleted && x.Email.ToLower() == user.Email.ToLower()
                                                    && x.Password.ToLower() == user.Password.ToLower());

            if (_user == null)
                throw new Exception("User not found");

            return new UserAuthenticateResponseViewModel(mapper.Map<UserViewModel>(_user),TokenService.GenerateToken(_user));
        }

        private string EncryptPassword(string password)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();

            byte[] encryptedPassword = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                stringBuilder.Append(caracter.ToString("X2"));
            }

            return stringBuilder.ToString();
        }
    }
}

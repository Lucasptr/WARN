using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warn.Data.Repository;
using Warn.Domain.Commands.UserCommands;
using Warn.Domain.Entities;
using Warn.Domain.Interfaces.Repository;
using Warn.Domain.Interfaces.Service;

namespace Warn.ApplicationService
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User Authenticate(string login, string password)
        {
           return _repository.Authenticate(login, password);
        }

        public User GetUser(string login)
        {
            return _repository.GetUser(login);
        }

        public User Register(RegisterUserCommand command)
        {
            var user = new User(command.Login, command.Password, command.Name, command.Email, command.Phone, command.ProfileID);
            user.Register();

            _repository.Register(user);

            return user;
        }
    }
}

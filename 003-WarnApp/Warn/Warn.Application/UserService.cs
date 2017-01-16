using Warn.Data;
using Warn.Domain.Commands.UserCommands;
using Warn.Domain.Entities;
using Warn.Domain.Interfaces.Repository;
using Warn.Domain.Interfaces.Service;

namespace Warn.ApplicationService
{
    public class UserService : ApplicationService, IUserService
    {
        private IUserRepository _repository;

        public UserService(IUserRepository repository, IUnityOfWork unitOfWork) : base(unitOfWork)
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

            if (Commit())
                return user;

            return null;
        }
    }
}

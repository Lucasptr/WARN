using Warn.Data;
using Warn.Domain.Commands.UserCommands;
using Warn.Domain.Entities;
using Warn.Domain.Interfaces.Repository;
using Warn.Domain.Interfaces.Service;
using Warn.SharedKernel.Helpers.Cryptography;

namespace Warn.ApplicationService
{
    public class UserService : ApplicationService, IUserService
    {
        private IUserRepository _repository;
        private ICryptographyHelper _cript;

        public UserService(IUserRepository repository, ICryptographyHelper cript, IUnityOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = repository;
            _cript = cript;
        }

        public User Authenticate(string login, string password)
        {
            var user = _repository.Authenticate(login);

            if(_cript.ValidatePassword(password, user.Password))
                return user;

            return null;
        }
        public User GetUser(string login)
        {
            return _repository.GetUser(login);
        }

        public User Register(RegisterUserCommand command)
        {
            var password = _cript.CreateHash(command.Password);
            var user = new User(command.Login, password, command.Name, command.Email, command.Phone, command.ProfileID);
            user.Register();

            _repository.Register(user);

            if (Commit())
                return user;

            return null;
        }
    }
}

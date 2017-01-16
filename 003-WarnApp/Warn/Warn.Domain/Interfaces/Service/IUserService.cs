using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warn.Domain.Commands.UserCommands;
using Warn.Domain.Entities;

namespace Warn.Domain.Interfaces.Service
{
    public interface IUserService
    {
        User Register(RegisterUserCommand command);
        User Authenticate(string login, string password);
        User GetUser(string login);
    }
}

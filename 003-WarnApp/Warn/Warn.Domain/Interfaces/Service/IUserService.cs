using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warn.Domain.Entities;

namespace Warn.Domain.Interfaces.Service
{
    public interface IUserService
    {
        void Register(User user);
        User Authenticate(string login, string password);
        User GetUser(string login);
    }
}

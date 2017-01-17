using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warn.Domain.Entities;

namespace Warn.Domain.Interfaces.Repository
{
    public interface IUserRepository : IDisposable
    {
        void Register(User user);
        User Authenticate(string login);
        User GetUser(string login);
    }
}

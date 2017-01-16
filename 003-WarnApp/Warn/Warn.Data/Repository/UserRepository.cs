using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warn.Data.Context;
using Warn.Domain.Entities;
using Warn.Domain.Interfaces.Repository;
using System.Data.Entity;

namespace Warn.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private WarnContext _context;

        public UserRepository(WarnContext context)
        {
            _context = context;
        }
        public User Authenticate(string login, string password)
        {
            return _context.User.Include(x => x.Profile).FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper() && x.Password == password);            
        }

        public void Register(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public User GetUser(string login)
        {
            return _context.User.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

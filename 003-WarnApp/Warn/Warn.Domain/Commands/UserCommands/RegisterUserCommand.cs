using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warn.Domain.Commands.UserCommands
{
    public class RegisterUserCommand
    {
        public RegisterUserCommand(string login, string password, string name, string email, int? phone, int? profile)
        {
            Login = login;
            Password = password;
            Name = name;
            Email = email;
            Phone = phone;
            ProfileID = profile;
        }
        public string Login { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int? Phone { get; set; }
        public int? ProfileID { get; set; }
    }
}

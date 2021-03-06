namespace Warn.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using Scopes;

    public partial class User
    {
        public User()
        {
            Subscribed = new HashSet<Subscribed>();
            Message = new HashSet<Message>();
        }
        public User(string login, string password, string name, string email, int? phone, int? profile)
        {
            Login = login;
            Password = password;
            Name = name;
            Email = email;
            Phone = phone;
            ProfileID = profile;
            CreationDate = DateTime.Now;
            Ativo = true;
        }

        public int? UserID { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int? Phone { get; set; }

        public bool Ativo { get; set; }

        //[Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }

        public int? ProfileID { get; set; }

        public virtual ICollection<Subscribed> Subscribed { get; set; }

        public virtual ICollection<Message> Message { get; set; }

        public virtual Profile Profile { get; set; }

        public void Register()
        {
            if (!this.RegisterUserScopeIsValid())
                return;
        }
    }
}

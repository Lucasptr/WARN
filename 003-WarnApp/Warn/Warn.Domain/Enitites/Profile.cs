namespace Warn.Domain.Entities
{
    using System.Collections.Generic;

    public class Profile
    {
        public Profile()
        {
            User = new HashSet<User>();
        }

        public int ProfileID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}

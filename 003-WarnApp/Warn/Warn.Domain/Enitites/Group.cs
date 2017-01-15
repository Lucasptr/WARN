namespace Warn.Domain.Entities
{
    using System;
    using System.Collections.Generic;

    public class Group
    {     
        public Group()
        {
            Subscribed = new HashSet<Subscribed>();
            Message = new HashSet<Message>();
        }

        public int GroupID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //[Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Subscribed> Subscribed { get; set; }

        public virtual ICollection<Message> Message { get; set; }
    }
}

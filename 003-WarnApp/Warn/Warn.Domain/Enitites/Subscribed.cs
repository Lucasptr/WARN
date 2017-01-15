namespace Warn.Domain.Entities
{
    using System.Collections.Generic;

    public class Subscribed
    {
        public Subscribed()
        {
            Feedback = new HashSet<Feedback>();
        }

        public int SubscribedID { get; set; }

        public int UserID { get; set; }

        public int GroupID { get; set; }

        public virtual Group Group { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Feedback> Feedback { get; set; }
    }
}

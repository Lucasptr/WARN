namespace Warn.Domain.Entities
{
    using System;
    using System.Collections.Generic;

    public partial class Message
    {
        public Message()
        {
            Feedback = new HashSet<Feedback>();
        }

        public int MessageID { get; set; }

        public string Text { get; set; }

        public DateTime SendDate { get; set; }

        public int GroupID { get; set; }

        public int MessageTypeID { get; set; }

        public int UserID { get; set; }

        public virtual ICollection<Feedback> Feedback { get; set; }

        public virtual Group Group { get; set; }

        public virtual User User { get; set; }

        public virtual MessageType MessageType { get; set; }
    }
}

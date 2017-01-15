namespace Warn.Domain.Entities
{
    using System.Collections.Generic;

    public class MessageType
    {
        public MessageType()
        {
            Message = new HashSet<Message>();
        }

        public int MessageTypeID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Message> Message { get; set; }
    }
}

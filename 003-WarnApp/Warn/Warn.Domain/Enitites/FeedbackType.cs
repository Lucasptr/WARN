namespace Warn.Domain.Entities
{
    using System.Collections.Generic;

    public class FeedbackType
    {
        public FeedbackType()
        {
            Feedback = new HashSet<Feedback>();
        }

        public int FeedbackTypeID { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Feedback> Feedback { get; set; }
    }
}

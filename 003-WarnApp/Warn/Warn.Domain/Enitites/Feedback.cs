namespace Warn.Domain.Entities
{
    public class Feedback
    {
        //[Key]
        public int FeedbackID { get; set; }

        public int MessageID { get; set; }

        public int FeedbackTypeID { get; set; }

        public int SubscribedID { get; set; }

        public virtual Subscribed Subscribed { get; set; }

        public virtual Message Message { get; set; }

        public virtual FeedbackType FeedbackType { get; set; }
    }
}

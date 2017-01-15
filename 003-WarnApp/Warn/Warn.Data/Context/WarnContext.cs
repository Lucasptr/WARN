namespace Warn.Data.Context
{
    using System.Data.Entity;
    using Domain.Entities;
    using EntityConfig;

    public class WarnContext : DbContext
    {
        public WarnContext()
            : base("name=connWarn")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Subscribed> Subscribed { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<FeedbackType> FeedbackType { get; set; }
        public virtual DbSet<MessageType> MessageType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FeedbackMap());
            modelBuilder.Configurations.Add(new FeedbackTypeMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new MessageTypeMap());
            modelBuilder.Configurations.Add(new ProfileMap());
            modelBuilder.Configurations.Add(new SubscribedMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}

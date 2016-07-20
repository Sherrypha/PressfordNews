namespace PressfordNewsSite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PressfordNewsModelData : DbContext
    {
        public PressfordNewsModelData()
            : base("name=PressfordNewsModelData")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Article1> Articles1 { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Articles1)
                .Map(m => m.ToTable("Likes").MapLeftKey("ArticleID").MapRightKey("UserID"));

            modelBuilder.Entity<User>()
                .HasMany(e => e.Articles)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.AuthorID)
                .WillCascadeOnDelete(false);
        }
    }
}

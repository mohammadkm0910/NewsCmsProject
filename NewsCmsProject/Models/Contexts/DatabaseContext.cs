using Microsoft.EntityFrameworkCore;
using NewsCmsProject.Models.Entities;

namespace NewsCmsProject.Models.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<TheNews> News { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FromTheWeb> FromTheWebs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Comment>().HasOne(c => c.User).WithMany().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
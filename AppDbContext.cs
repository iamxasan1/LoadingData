using LoadingData.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoadingData
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogUser> BlogUsers {get; set;}
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.LogTo(Console.WriteLine)
                //.UseLazyLoadingProxies()
                .UseSqlite("data source=Mydata.db");
        }
    }
}

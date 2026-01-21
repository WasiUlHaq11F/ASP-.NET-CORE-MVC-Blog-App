using BloggieMVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BloggieMVC.Data
{
    public class BloggieDbContext : DbContext // DbContext is a class that represents the database context
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
            // This is a constructor for the BloggieDbContext class
            // It is used to initialize the database context
            // It is called when a new instance of the BloggieDbContext class is created using the DbContextOptions
            // The DbContextOptions is a class that contains the options for the database context
            // The DbContextOptions is a class that contains the options for the database context
        }
        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }

        

    }


}
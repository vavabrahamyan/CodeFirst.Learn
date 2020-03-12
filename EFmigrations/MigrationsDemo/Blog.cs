using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace MigrationsDemo
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {

        }
        public BlogContext(string connectionString):base(connectionString)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
    public class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}

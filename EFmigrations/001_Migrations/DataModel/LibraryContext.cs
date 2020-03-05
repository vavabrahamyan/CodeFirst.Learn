namespace _001_Migrations.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
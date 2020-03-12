using System;

namespace MigrationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( var db = new BlogContext(@"Data Source=DESKTOP-BG4E31L;Initial Catalog=BlogDb;Integrated Security=True"))
            {
                db.Blogs.Add(new Blog { Name = "Another Blog", Url = "192.128.1.1" });
                db.SaveChanges();

                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(blog.Name);
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

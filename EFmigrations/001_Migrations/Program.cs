using _001_Migrations.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( var context = new LibraryContext())
            {
                var book = new Book { Author = "Remark", Title = "The Road Back" };

                context.Books.Add(book);
                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Migration
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var Context = new PhoneContext())
            {
                var phone = new Phone { Name = "Nokia", Price = 290 };
                Context.Phones.Add(phone);
                Context.SaveChanges();
            }
        }
    }
}

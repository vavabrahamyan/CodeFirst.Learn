using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Migration
{
    class PhoneContext : DbContext
    {
        public PhoneContext() : base("DefaultConnection") { }
        public DbSet<Phone> Phones { get; set; }
    }
    class Phone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }
}

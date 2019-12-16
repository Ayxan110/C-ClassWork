using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("myDb") { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Photo> Photos { get; set; }
        
    }
}

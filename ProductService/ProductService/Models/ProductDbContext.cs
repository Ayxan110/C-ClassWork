using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductService.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("myDb") { }
        public DbSet<Models.Product> Products { get; set; }
    }
}
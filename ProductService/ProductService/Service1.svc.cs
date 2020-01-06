using ProductService.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Product> GetAllProducts()
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                return db.Products.ToList();
            }
        }

        public bool GetProductById(int id)
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                if (db.Products.Find(id))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void InsertProduct(string name, int price, int count)
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                db.Products.Add(new Product
                {
                    Name = name,
                    Price = price,
                    Count = count
                });
                db.SaveChanges();
            }
        }
    }
}

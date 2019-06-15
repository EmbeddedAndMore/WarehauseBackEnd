using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehauseBackEndCore.Model
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime? entrDate { get; set; }
        public string ownerName { get; set; }



        public List<Product> GetAllProducts()
        {
            using (WarehauseContext db = new WarehauseContext())
            {
                List<Product> products = db.Products.ToList();
                return products;
            }
        }

        public bool AddProduct(Product product)
        {
            using (WarehauseContext db = new WarehauseContext())
            {
                try
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return true;
                }
                
            }
        }

        public bool RemoveProduct(int id)
        {
            using (WarehauseContext db = new WarehauseContext())
            {
                Product p = db.Products.FirstOrDefault(x => x.id == id);
                if (p != null)
                {
                    db.Products.Attach(p);
                    db.Remove(p);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
        }
    }
}

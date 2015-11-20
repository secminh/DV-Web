using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Productservice" in both code and config file together.
    public class Productservice : IProductservice
    {
        WcfServiceContext db = new WcfServiceContext();
        
        public List<Product> GetAll()
        {
            return db.Product.ToList();
        }

        public Product GetByID(int id)
        {
            Product p = db.Product.Find(id);
            return p;
        }

        public void AddProduct(Product p)
        {
            db.Product.Add(p);
            db.SaveChanges();
        }

        public void UpdateProduct(Product p)
        {
            db.Entry(p).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product p = db.Product.Find(id);
            db.Product.Remove(p);
            db.SaveChanges();
        }
    }
}

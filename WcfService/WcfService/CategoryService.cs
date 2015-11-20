using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CategoryService" in both code and config file together.
    public class CategoryService : ICategoryService
    {
        WcfServiceContext db = new WcfServiceContext();
        public List<Category> GetAll()
        {
            return db.Category.ToList();
        }

        public Category GetByID(int id)
        {
            Category c = db.Category.Find(id);
            return c;
        }

        public void AddCategory(Category c)
        {
            db.Category.Add(c);
            db.SaveChanges();
        }

        public void UpdateCategory(Category c)
        {
            db.Entry(c).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            Category c = db.Category.Find(id);
            db.Category.Remove(c);
            db.SaveChanges();
        }
    }
}

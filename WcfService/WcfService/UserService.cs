using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in both code and config file together.
    public class UserService : IUserService
    {
        WcfServiceContext db = new WcfServiceContext();
        public List<User> GetAll()
        {
            return db.User.ToList();
        }

        public User GetByID(int id)
        {
            User u = db.User.Find(id);
            return u;
        }

        public void AddUser(User u)
        {
            db.User.Add(u);
            db.SaveChanges();
        }

        public void UpdateUser(User u)
        {
            db.Entry(u).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            User u = db.User.Find(id);
            db.User.Remove(u);
            db.SaveChanges();
        }
    }
}

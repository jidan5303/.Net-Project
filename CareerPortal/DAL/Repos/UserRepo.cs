using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepo<User, int, bool>, IAuth<bool>
    {
        public bool Authenticate(string username, string password, string type)
        {
            var data = db.Users.FirstOrDefault(u => u.Username.Equals(username) &&
            u.Password.Equals(password) && u.Type.Equals(type));
            if (data != null) return true;
            return false;
        }

        public bool Create(User obj)
        {
            db.Users.Add(obj);
            return db.SaveChanges() > 0;
        }

        public List<User> Read()
        {
            return db.Users.ToList();
        }

        public User Read(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User obj)
        {
            var profile = db.Users.Find(obj.Id);
            db.Entry(profile).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var profile = Read(id);
            db.Users.Remove(profile);
            return db.SaveChanges() > 0;
        }
    }
}

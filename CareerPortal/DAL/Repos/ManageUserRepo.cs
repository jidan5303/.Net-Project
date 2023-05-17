using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageUserRepo : Repo, IRepo<ManageUsers, int, bool>
    {
        public bool Create(ManageUsers obj)
        {
            db.ManageUsers.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int iD)
        {
            var user = Read(iD);
            db.ManageUsers.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<ManageUsers> Read()
        {
            return db.ManageUsers.ToList();
        }

        public ManageUsers Read(int iD)
        {
            return db.ManageUsers.Find(iD);
        }

        public bool Update(ManageUsers obj)
        {
            var user = Read(obj.Id);
            db.Entry(user).CurrentValues.SetValues(user);
            return db.SaveChanges() > 0;
        }
    }
}

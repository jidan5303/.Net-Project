using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageCategoryRepo : Repo, IRepo<ManageCategory, int, bool>
    {
        public bool Create(ManageCategory obj)
        {
            db.ManageCategories.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int iD)
        {
            var category = Read(iD);
            db.ManageCategories.Remove(category);
            return db.SaveChanges() > 0;
        }

        public List<ManageCategory> Read()
        {
            return db.ManageCategories.ToList();
        }

        public ManageCategory Read(int iD)
        {
            return db.ManageCategories.Find(iD);
        }

        public bool Update(ManageCategory obj)
        {
            var category = Read(obj.Id);
            db.Entry(category).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

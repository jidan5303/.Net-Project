using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployerProfileRepo : Repo, IRepo<EmployerProfile, int, bool>
    {
        public bool Create(EmployerProfile obj)
        {
            db.EmployerProfiles.Add(obj);
            return db.SaveChanges() > 0;
        }

        public List<EmployerProfile> Read()
        {
            return db.EmployerProfiles.ToList();
        }

        public EmployerProfile Read(int id)
        {
            return db.EmployerProfiles.Find(id);
        }

        public bool Update(EmployerProfile obj)
        {
            var profile = db.EmployerProfiles.Find(obj.Id);
            db.Entry(profile).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var profile = Read(id);
            db.EmployerProfiles.Remove(profile);
            return db.SaveChanges() > 0;
        }
    }
}

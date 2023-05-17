using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageEmployerRepo : Repo, IRepo<EmployerProfile, int, bool>
    {
        public bool Create(EmployerProfile obj)
        {
            db.EmployerProfiles.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var employer = db.EmployerProfiles.Find(id);
            if (employer == null)
            {
                return false;
            }

            var user = db.Users.Find(employer.User_Id);
            if (user == null)
            {
                return false;
            }

            db.EmployerProfiles.Remove(employer);
            db.Users.Remove(user);

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
            var user = Read(obj.Id);
            db.Entry(user).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

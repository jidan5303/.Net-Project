using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployerRecruitmentRepo : Repo, IRepo<EmployerRecruitment, int, bool>
    {
        public bool Create(EmployerRecruitment obj)
        {
            db.EmployerRecruitments.Add(obj);
            return db.SaveChanges() > 0;
        }

        public List<EmployerRecruitment> Read()
        {
            return db.EmployerRecruitments.ToList();
        }

        public EmployerRecruitment Read(int id)
        {
            return db.EmployerRecruitments.Find(id);
        }

        public bool Update(EmployerRecruitment obj)
        {
            var profile = db.EmployerRecruitments.Find(obj.Id);
            db.Entry(profile).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var profile = Read(id);
            db.EmployerRecruitments.Remove(profile);
            return db.SaveChanges() > 0;
        }
    }
}

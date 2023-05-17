using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ApplicantProfileRepo : Repo, IRepo<ApplicantProfile, int, bool>
    {
        public bool Create(ApplicantProfile obj)
        {
            db.ApplicantProfiles.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.ApplicantProfiles.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<ApplicantProfile> Read()
        {
            return db.ApplicantProfiles.ToList();
        }

        public ApplicantProfile Read(int id)
        {
            return db.ApplicantProfiles.Find(id);
        }

        public bool Update(ApplicantProfile obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

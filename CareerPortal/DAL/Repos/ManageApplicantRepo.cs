using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageApplicantRepo : Repo, IRepo<ApplicantProfile, int, bool>
    {
        public bool Create(ApplicantProfile obj)
        {
            db.ApplicantProfiles.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var applicant = db.ApplicantProfiles.Find(id);
            if (applicant == null)
            {
                return false;
            }

            var user = db.Users.Find(applicant.UId);
            if (user == null)
            {
                return false;
            }

            db.ApplicantProfiles.Remove(applicant);
            db.Users.Remove(user);

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
            var user = Read(obj.Id);
            db.Entry(user).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ApplicantEducationRepo : Repo, IRepo<ApplicantEducationalQualification, int, bool>
    {
        public bool Create(ApplicantEducationalQualification obj)
        {
            db.Qualifications.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Qualifications.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<ApplicantEducationalQualification> Read()
        {
            return db.Qualifications.ToList();
        }

        public ApplicantEducationalQualification Read(int id)
        {
            return db.Qualifications.Find(id);
        }

        public bool Update(ApplicantEducationalQualification obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

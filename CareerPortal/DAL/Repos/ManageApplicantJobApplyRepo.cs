using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageApplicantJobApplyRepo : Repo, IRepo<ApplicantJobApply, int, bool>
    {
        public bool Create(ApplicantJobApply obj)
        {
            db.ApplicantJobApply.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var data = Read(id);
            db.ApplicantJobApply.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<ApplicantJobApply> Read()
        {
            return db.ApplicantJobApply.ToList();
        }

        public ApplicantJobApply Read(int id)
        {
            return db.ApplicantJobApply.Find(id);
        }

        public bool Update(ApplicantJobApply obj)
        {
            var data = Read(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

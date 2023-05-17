using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageEmployerJobPostRepo : Repo, IRepo<EmployerJobPost, int, bool>
    {
        public bool Create(EmployerJobPost obj)
        {
            db.EmployerJobPosts.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var jobs = Read(id);
            db.EmployerJobPosts.Remove(jobs);
            return db.SaveChanges() > 0;
        }

        public List<EmployerJobPost> Read()
        {
            return db.EmployerJobPosts.ToList();
        }

        public EmployerJobPost Read(int id)
        {
            return db.EmployerJobPosts.Find(id);
        }

        public bool Update(EmployerJobPost obj)
        {
            var jobs = Read(obj.Id);
            db.Entry(jobs).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

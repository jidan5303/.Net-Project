using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployerJobPostRepo : Repo, IRepo<EmployerJobPost, int, bool>
    {
        public bool Create(EmployerJobPost obj)
        {
            db.EmployerJobPosts.Add(obj);
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
            var profile = db.EmployerJobPosts.Find(obj.Id);
            db.Entry(profile).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var profile = Read(id);
            db.EmployerJobPosts.Remove(profile);
            return db.SaveChanges() > 0;
        }
    }
}

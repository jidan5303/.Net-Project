using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManageJobPostRepo : Repo, IRepo<ManageJobPost, int, bool>
    {
        public bool Create(ManageJobPost obj)
        {
            db.ManageJobPosts.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int iD)
        {
            var jobPost = Read(iD);
            db.ManageJobPosts.Remove(jobPost);
            return db.SaveChanges() > 0;
        }

        public List<ManageJobPost> Read()
        {
            return db.ManageJobPosts.ToList();
        }

        public ManageJobPost Read(int iD)
        {
            return db.ManageJobPosts.Find(iD);
        }

        public bool Update(ManageJobPost obj)
        {
            var jobPost = Read(obj.Id);
            db.Entry(jobPost).CurrentValues.SetValues(jobPost);
            return db.SaveChanges() > 0;
        }
    }
}

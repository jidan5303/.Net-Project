using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CPContext : DbContext
    {
        public DbSet<Token> Tokens { get; set; }

        public DbSet<EmployerJobPost> EmployerJobPosts { get; set; }
        public DbSet<EmployerProfile> EmployerProfiles { get; set; }
        public DbSet<EmployerRecruitment> EmployerRecruitments { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<ApplicantProfile> ApplicantProfiles { get; set; }
        public DbSet<ApplicantJobApply> ApplicantJobApply { get; set; }
        public DbSet<ApplicantEducationalQualification> Qualifications { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        public DbSet<ManageUsers> ManageUsers { get; set; }
        public DbSet<ManageJobPost> ManageJobPosts { get; set; }
        public DbSet<ManageCategory> ManageCategories { get; set; }
    }
}

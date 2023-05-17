using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IAuth<bool> AuthData()
        {
            return new UserRepo();
        }

        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }

        public static IRepo<User, int, bool> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<EmployerJobPost, int, bool> EmployerJobPostData()
        {
            return new EmployerJobPostRepo();
        }
        public static IRepo<EmployerProfile, int, bool> EmployerProfileData()
        {
            return new EmployerProfileRepo();
        }
        public static IRepo<EmployerRecruitment, int, bool> EmployerRecruitmentData()
        {
            return new EmployerRecruitmentRepo();
        }
        public static IRepo<ApplicantProfile, int, bool> ManageApplicantData()
        {
            return new ManageApplicantRepo();
        }
        public static IRepo<EmployerProfile, int, bool> ManageEmployerData()
        {
            return new ManageEmployerRepo();
        }
        public static IRepo<ManageJobPost, int, bool> ManageJobPostData()
        {
            return new ManageJobPostRepo();
        }
        public static IRepo<ManageCategory, int, bool> ManageCategoryData()
        {
            return new ManageCategoryRepo();
        }
        public static IRepo<EmployerJobPost, int, bool> ManageEmployerJobPostData()
        {
            return new ManageEmployerJobPostRepo();
        }
        public static IRepo<ApplicantJobApply, int, bool> ManageApplicantJobApplyData()
        {
            return new ManageApplicantJobApplyRepo();
        }

        public static IRepo<ApplicantProfile,int,bool> ApplicantData()

        {
            return new ApplicantProfileRepo();
        }
        public static IRepo<ApplicantEducationalQualification,int,bool> ApplicantEducationalData()
        {
            return new ApplicantEducationRepo();
        }
        public static IRepo<ApplicantJobApply, int, bool> ApplicantJobApplyData()
        {
            return new ApplicantJobApplyRepo();
        }
        public static IRepo<Notification, int, bool> NotificationData()
        {
            return new NotificationRepo();
        }
    }
}

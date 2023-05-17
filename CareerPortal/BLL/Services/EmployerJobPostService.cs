using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployerJobPostService
    {
        public static bool Create(EmployerJobPostDTO obj)
        {
            var data = Convert(obj);
            return DataAccessFactory.EmployerJobPostData().Create(data);
        }
        public static List<EmployerJobPostDTO> Read()
        {
            var data = DataAccessFactory.EmployerJobPostData().Read();
            return Convert(data);
        }
        public static EmployerJobPostDTO Read(int id)
        {
            var data = DataAccessFactory.EmployerJobPostData().Read(id);
            return Convert(data);
        }
        public static bool Update(EmployerJobPostDTO obj)
        {
            var data = Convert(obj);
            return DataAccessFactory.EmployerJobPostData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.EmployerJobPostData().Delete(id);
        }
        static EmployerJobPost Convert(EmployerJobPostDTO obj)
        {
            return new EmployerJobPost()
            {
                Id = obj.Id,
                Title = obj.Title,
                Description = obj.Description,
                Type = obj.Type,
                Salary = obj.Salary,
                Location = obj.Location,
                RequiredSkills = obj.RequiredSkills,
                EducationLevel = obj.EducationLevel,
                Experience = obj.Experience,
                ApplicationDeadline = obj.ApplicationDeadline,
                CompanyName = obj.CompanyName,
                CompanyMail = obj.CompanyMail,
                Employer_Id = obj.Employer_Id,
                Category_Id = obj.Category_Id,
            };
        }
        static List<EmployerJobPost> Convert(List<EmployerJobPostDTO> list)
        {
            var data = new List<EmployerJobPost>();
            foreach (var item in list)
            {
                data.Add(new EmployerJobPost()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Description = item.Description,
                    Type = item.Type,
                    Salary = item.Salary,
                    Location = item.Location,
                    RequiredSkills = item.RequiredSkills,
                    EducationLevel = item.EducationLevel,
                    Experience = item.Experience,
                    ApplicationDeadline = item.ApplicationDeadline,
                    CompanyName = item.CompanyName,
                    CompanyMail = item.CompanyMail,
                    Employer_Id = item.Employer_Id,
                    Category_Id = item.Category_Id,
                });
            }
            return data;
        }
        static EmployerJobPostDTO Convert(EmployerJobPost obj)
        {
            return new EmployerJobPostDTO()
            {
                Id = obj.Id,
                Title = obj.Title,
                Description = obj.Description,
                Type = obj.Type,
                Salary = obj.Salary,
                Location = obj.Location,
                RequiredSkills = obj.RequiredSkills,
                EducationLevel = obj.EducationLevel,
                Experience = obj.Experience,
                ApplicationDeadline = obj.ApplicationDeadline,
                CompanyName = obj.CompanyName,
                CompanyMail = obj.CompanyMail,
                Employer_Id = obj.Employer_Id,
                Category_Id = obj.Category_Id,
            };
        }
        static List<EmployerJobPostDTO> Convert(List<EmployerJobPost> list)
        {
            var data = new List<EmployerJobPostDTO>();
            foreach (var item in list)
            {
                data.Add(new EmployerJobPostDTO()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Description = item.Description,
                    Type = item.Type,
                    Salary = item.Salary,
                    Location = item.Location,
                    RequiredSkills = item.RequiredSkills,
                    EducationLevel = item.EducationLevel,
                    Experience = item.Experience,
                    ApplicationDeadline = item.ApplicationDeadline,
                    CompanyName = item.CompanyName,
                    CompanyMail = item.CompanyMail,
                    Employer_Id = item.Employer_Id,
                    Category_Id = item.Category_Id,
                });
            }
            return data;
        }
    }
}

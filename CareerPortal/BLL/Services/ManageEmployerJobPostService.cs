using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ManageEmployerJobPostService
    {
        public static bool Create(ManageEmployerJobPostDTO manageEmployerJobPostDTO)
        {
            var data = Convert(manageEmployerJobPostDTO);
            return DataAccessFactory.ManageEmployerJobPostData().Create(data);
        }
        public static List<ManageEmployerJobPostDTO> Read()
        {
            var data = DataAccessFactory.ManageEmployerJobPostData().Read();
            return Convert(data);
        }
        public static ManageEmployerJobPostDTO Read(int id)
        {
            return Convert(DataAccessFactory.ManageEmployerJobPostData().Read(id));
        }
        public static bool Update(ManageEmployerJobPostDTO manageEmployerJobPostDTO)
        {
            var data = Convert(manageEmployerJobPostDTO);
            return DataAccessFactory.ManageEmployerJobPostData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ManageEmployerJobPostData().Delete(id);
        }
        static List<ManageEmployerJobPostDTO> Convert(List<EmployerJobPost> employerJobPosts)
        {
            var data = new List<ManageEmployerJobPostDTO>();
            foreach (EmployerJobPost employerJobPost in employerJobPosts)
            {
                data.Add(Convert(employerJobPost));
            }
            return data;
        }
        static List<EmployerJobPost> Convert(List<ManageEmployerJobPostDTO> manageEmployerJobPostDTOs)
        {
            var data = new List<EmployerJobPost>();
            foreach (ManageEmployerJobPostDTO manageEmployerJobPostDTO in manageEmployerJobPostDTOs)
            {
                data.Add(Convert(manageEmployerJobPostDTO));
            }
            return data;
        }
        static ManageEmployerJobPostDTO Convert(EmployerJobPost employerJobPost)
        {
            return new ManageEmployerJobPostDTO()
            {
                Id = employerJobPost.Id,
                Title = employerJobPost.Title,
                Description = employerJobPost.Description,
                Type = employerJobPost.Type,
                Salary = employerJobPost.Salary,
                Location = employerJobPost.Location,
                RequiredSkills = employerJobPost.RequiredSkills,
                EducationLevel = employerJobPost.EducationLevel,
                Experience = employerJobPost.Experience,
                ApplicationDeadline = employerJobPost.ApplicationDeadline,
                CompanyName = employerJobPost.CompanyName,
                CompanyMail = employerJobPost.CompanyMail,
                Employer_Id = employerJobPost.Employer_Id,
                Category_Id = employerJobPost.Category_Id
            };
        }
        static EmployerJobPost Convert(ManageEmployerJobPostDTO manageEmployerJobPostDTO)
        {
            return new EmployerJobPost()
            {
                Id = manageEmployerJobPostDTO.Id,
                Title = manageEmployerJobPostDTO.Title,
                Description = manageEmployerJobPostDTO.Description,
                Type = manageEmployerJobPostDTO.Type,
                Salary = manageEmployerJobPostDTO.Salary,
                Location = manageEmployerJobPostDTO.Location,
                RequiredSkills = manageEmployerJobPostDTO.RequiredSkills,
                EducationLevel = manageEmployerJobPostDTO.EducationLevel,
                Experience = manageEmployerJobPostDTO.Experience,
                ApplicationDeadline = manageEmployerJobPostDTO.ApplicationDeadline,
                CompanyName = manageEmployerJobPostDTO.CompanyName,
                CompanyMail = manageEmployerJobPostDTO.CompanyMail,
                Employer_Id = manageEmployerJobPostDTO.Employer_Id,
                Category_Id = manageEmployerJobPostDTO.Category_Id
            };
        }
    }
}

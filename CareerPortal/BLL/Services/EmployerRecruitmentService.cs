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
    public class EmployerRecruitmentService
    {
        public static bool Create(EmployerRecruitmentDTO obj)
        {
            var data = Convert(obj);
            return DataAccessFactory.EmployerRecruitmentData().Create(data);
        }
        public static List<EmployerRecruitmentDTO> Read()
        {
            var data = DataAccessFactory.EmployerRecruitmentData().Read();
            return Convert(data);
        }
        public static EmployerRecruitmentDTO Read(int id)
        {
            var data = DataAccessFactory.EmployerRecruitmentData().Read(id);
            return Convert(data);
        }
        public static bool Update(EmployerRecruitmentDTO obj)
        {
            var data = Convert(obj);
            return DataAccessFactory.EmployerRecruitmentData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.EmployerRecruitmentData().Delete(id);
        }
        static EmployerRecruitment Convert(EmployerRecruitmentDTO obj)
        {
            return new EmployerRecruitment()
            {
                Id = obj.Id,
                Shortlist = obj.Shortlist,
                Employer_Id = obj.Employer_Id,
                Applicant_Id = obj.Applicant_Id,
                JobPost_Id = obj.JobPost_Id
            };
        }
        static List<EmployerRecruitment> Convert(List<EmployerRecruitmentDTO> list)
        {
            var data = new List<EmployerRecruitment>();
            foreach (var item in list)
            {
                data.Add(new EmployerRecruitment()
                {
                    Id = item.Id,
                    Shortlist = item.Shortlist,
                    Employer_Id = item.Employer_Id,
                    Applicant_Id = item.Applicant_Id,
                    JobPost_Id = item.JobPost_Id
                });
            }
            return data;
        }
        static EmployerRecruitmentDTO Convert(EmployerRecruitment obj)
        {
            return new EmployerRecruitmentDTO()
            {
                Id = obj.Id,
                Shortlist = obj.Shortlist,
                Employer_Id = obj.Employer_Id,
                Applicant_Id = obj.Applicant_Id,
                JobPost_Id = obj.JobPost_Id
            };
        }
        static List<EmployerRecruitmentDTO> Convert(List<EmployerRecruitment> list)
        {
            var data = new List<EmployerRecruitmentDTO>();
            foreach (var item in list)
            {
                data.Add(new EmployerRecruitmentDTO()
                {
                    Id = item.Id,
                    Shortlist = item.Shortlist,
                    Employer_Id = item.Employer_Id,
                    Applicant_Id = item.Applicant_Id,
                    JobPost_Id = item.JobPost_Id
                });
            }
            return data;
        }
    }
}

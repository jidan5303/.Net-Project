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
    public class ApplicantProfileService
    {
        static List<ApplicantProfileDTO> Convert(List<ApplicantProfile> applicants)
        {
            var data = new List<ApplicantProfileDTO>();
            foreach (ApplicantProfile applicant in applicants)
            {
                data.Add(Convert(applicant));
            }
            return data;
        }
        static ApplicantProfileDTO Convert(ApplicantProfile applicant)
        {
            return new ApplicantProfileDTO()
            {
                Id = applicant.Id,
                UId = applicant.UId,
                Name = applicant.Name,
                Mail = applicant.Mail,
                Phone = applicant.Phone,
                Nationality = applicant.Nationality,
                Address = applicant.Address,
                Gender = applicant.Gender,
                DOB= applicant.DOB
            };
        }
        static ApplicantProfile Convert(ApplicantProfileDTO applicant)
        {
            return new ApplicantProfile()
            {
                Id = applicant.Id,
                UId = applicant.UId,
                Name = applicant.Name,
                Mail = applicant.Mail,
                Phone = applicant.Phone,
                Nationality = applicant.Nationality,
                Address = applicant.Address,
                Gender = applicant.Gender,
                DOB = applicant.DOB
            };
        }
        public static List<ApplicantProfileDTO> Read()
        {
            var data = DataAccessFactory.ApplicantData().Read();
            return Convert(data);
        }
        public static ApplicantProfileDTO Read(int id)
        {
            return Convert(DataAccessFactory.ApplicantData().Read(id));
        }
        public static bool Create(ApplicantProfileDTO applicant)
        {
            var data = Convert(applicant);
            return DataAccessFactory.ApplicantData().Create(data);
        }
        public static bool Update(ApplicantProfileDTO applicant)
        {
            var data = Convert(applicant);
            return DataAccessFactory.ApplicantData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ApplicantData().Delete(id);
        }
    }
}

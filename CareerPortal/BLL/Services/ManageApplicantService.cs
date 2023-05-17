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
    public class ManageApplicantService
    {
        public static bool Create(ManageApplicantDTO manageApplicant)
        {
            var data = Convert(manageApplicant);
            return DataAccessFactory.ManageApplicantData().Create(data);
        }

        public static List<ManageApplicantDTO> Read()
        {
            var data = DataAccessFactory.ManageApplicantData().Read();
            return Convert(data);
        }

        public static ManageApplicantDTO Read(int id)
        {
            return Convert(DataAccessFactory.ManageApplicantData().Read(id));
        }

        public static bool Update(ManageApplicantDTO manageApplicant)
        {
            var data = Convert(manageApplicant);
            return DataAccessFactory.ManageApplicantData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ManageApplicantData().Delete(id);
        }

        static List<ManageApplicantDTO> Convert(List<ApplicantProfile> manageApplicant)
        {
            var data = new List<ManageApplicantDTO>();
            foreach (ApplicantProfile applicantProfile in manageApplicant)
            {
                data.Add(Convert(applicantProfile));
            }
            return data;
        }

        static List<ApplicantProfile> Convert(List<ManageApplicantDTO> manageApplicant)
        {
            var data = new List<ApplicantProfile>();
            foreach (ManageApplicantDTO ManageApplicantDTO2 in manageApplicant)
            {
                data.Add(Convert(ManageApplicantDTO2));
            }
            return data;
        }

        static ManageApplicantDTO Convert(ApplicantProfile manageApplicant)
        {
            return new ManageApplicantDTO()
            {
                Id = manageApplicant.Id,
                UId = manageApplicant.UId,
                Name = manageApplicant.Name,
                Mail = manageApplicant.Mail,
                Phone = manageApplicant.Phone,
                Nationality = manageApplicant.Nationality,
                Address = manageApplicant.Address,
                Gender = manageApplicant.Gender,
                DOB = manageApplicant.DOB
            };
        }

        static ApplicantProfile Convert(ManageApplicantDTO manageApplicant)
        {
            return new ApplicantProfile()
            {
                Id = manageApplicant.Id,
                UId = manageApplicant.UId,
                Name = manageApplicant.Name,
                Mail = manageApplicant.Mail,
                Phone = manageApplicant.Phone,
                Nationality = manageApplicant.Nationality,
                Address = manageApplicant.Address,
                Gender = manageApplicant.Gender,
                DOB = manageApplicant.DOB
            };
        }
    }
}

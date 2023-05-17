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
    public class ApplicantEducationalQualificationService
    {
        static List<ApplicantEducationalQualificationDTO> Convert(List<ApplicantEducationalQualification> applicanteducations)
        {
            var data = new List<ApplicantEducationalQualificationDTO>();
            foreach (ApplicantEducationalQualification applicanteducation in applicanteducations)
            {
                data.Add(Convert(applicanteducation));
            }
            return data;
        }
        static ApplicantEducationalQualificationDTO Convert(ApplicantEducationalQualification applicanteducation)
        {
            return new ApplicantEducationalQualificationDTO()
            {
                Id= applicanteducation.Id,
                ApplicantId= applicanteducation.ApplicantId,
                LevelofEducation= applicanteducation.LevelofEducation,
                InstituteName= applicanteducation.InstituteName,
                YearofPassing=applicanteducation.YearofPassing,
                Degree=applicanteducation.Degree
            };
        }
        static ApplicantEducationalQualification Convert(ApplicantEducationalQualificationDTO applicanteducation)
        {
            return new ApplicantEducationalQualification()
            {
                Id = applicanteducation.Id,
                ApplicantId = applicanteducation.ApplicantId,
                LevelofEducation = applicanteducation.LevelofEducation,
                InstituteName = applicanteducation.InstituteName,
                YearofPassing = applicanteducation.YearofPassing,
                Degree = applicanteducation.Degree
            };
        }
        public static List<ApplicantEducationalQualificationDTO> Read()
        {
            var data = DataAccessFactory.ApplicantEducationalData().Read();
            return Convert(data);
        }
        public static ApplicantEducationalQualificationDTO Read(int id)
        {
            return Convert(DataAccessFactory.ApplicantEducationalData().Read(id));
        }
        public static bool Create(ApplicantEducationalQualificationDTO applicanteducation)
        {
            var data = Convert(applicanteducation);
            return DataAccessFactory.ApplicantEducationalData().Create(data);
        }
        public static bool Update(ApplicantEducationalQualificationDTO applicanteducation)
        {
            var data = Convert(applicanteducation);
            return DataAccessFactory.ApplicantEducationalData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ApplicantEducationalData().Delete(id);
        }
    }
}

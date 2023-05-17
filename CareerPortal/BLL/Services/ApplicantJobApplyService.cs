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
    public class ApplicantJobApplyService
    {
        static List<ApplicantJobApplyDTO> Convert(List<ApplicantJobApply> applicants)
        {
            var data = new List<ApplicantJobApplyDTO>();
            foreach (ApplicantJobApply applicant in applicants)
            {
                data.Add(Convert(applicant));
            }
            return data;
        }
        static ApplicantJobApplyDTO Convert(ApplicantJobApply applicant)
        {
            return new ApplicantJobApplyDTO()
            {
                Id = applicant.Id,
                ApplicantId = applicant.ApplicantId,
                PositionName = applicant.PositionName,
                Phone = applicant.Phone,
                ExpectedSalary = applicant.ExpectedSalary,
                Mail = applicant.Mail,
                StartTime = applicant.StartTime,
                JobId = applicant.JobId
            };
        }
        static ApplicantJobApply Convert(ApplicantJobApplyDTO applicant)
        {
            return new ApplicantJobApply()
            {
                Id = applicant.Id,
                ApplicantId = applicant.ApplicantId,
                PositionName = applicant.PositionName,
                Phone = applicant.Phone,
                ExpectedSalary = applicant.ExpectedSalary,
                Mail = applicant.Mail,
                StartTime = applicant.StartTime,
                JobId = applicant.JobId
            };
        }
        public static List<ApplicantJobApplyDTO> Read()
        {
            var data = DataAccessFactory.ApplicantJobApplyData().Read();
            return Convert(data);
        }
        public static ApplicantJobApplyDTO Read(int id)
        {
            return Convert(DataAccessFactory.ApplicantJobApplyData().Read(id));
        }
        public static bool Create(ApplicantJobApplyDTO applicant)
        {
            var data = Convert(applicant);
            return DataAccessFactory.ApplicantJobApplyData().Create(data);
        }
        public static bool Update(ApplicantJobApplyDTO applicant)
        {
            var data = Convert(applicant);
            return DataAccessFactory.ApplicantJobApplyData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ApplicantJobApplyData().Delete(id);
        }
    }
}

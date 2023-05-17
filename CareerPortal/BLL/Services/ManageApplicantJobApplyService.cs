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
    public class ManageApplicantJobApplyService
    {
        public static bool Create(ManageApplicantJobApplyDTO manageApplicantJobApplyDTO)
        {
            var data = Convert(manageApplicantJobApplyDTO);
            return DataAccessFactory.ManageApplicantJobApplyData().Create(data);
        }
        public static List<ManageApplicantJobApplyDTO> Read()
        {
            var data = DataAccessFactory.ManageApplicantJobApplyData().Read();
            return Convert(data);
        }
        public static ManageApplicantJobApplyDTO Read(int id)
        {
            return Convert(DataAccessFactory.ManageApplicantJobApplyData().Read(id));
        }
        public static bool Update(ManageApplicantJobApplyDTO manageApplicantJobApplyDTO)
        {
            var data = Convert(manageApplicantJobApplyDTO);
            return DataAccessFactory.ManageApplicantJobApplyData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ManageApplicantJobApplyData().Delete(id);
        }
        static List<ManageApplicantJobApplyDTO> Convert(List<ApplicantJobApply> applicantJobApplies)
        {
            var data = new List<ManageApplicantJobApplyDTO>();
            foreach (ApplicantJobApply applicantJobApply in applicantJobApplies)
            {
                data.Add(Convert(applicantJobApply));
            }
            return data;
        }
        static List<ApplicantJobApply> Convert(List<ManageApplicantJobApplyDTO> manageApplicantJobApplyDTOs)
        {
            var data = new List<ApplicantJobApply>();
            foreach (ManageApplicantJobApplyDTO manageApplicantJobApplyDTO in manageApplicantJobApplyDTOs)
            {
                data.Add(Convert(manageApplicantJobApplyDTO));
            }
            return data;
        }
        static ApplicantJobApply Convert(ManageApplicantJobApplyDTO manageApplicantJobApplyDTO)
        {
            return new ApplicantJobApply()
            {
                Id = manageApplicantJobApplyDTO.Id,
                ApplicantId = manageApplicantJobApplyDTO.ApplicantId,
                PositionName = manageApplicantJobApplyDTO.PositionName,
                Phone = manageApplicantJobApplyDTO.Phone,
                Mail = manageApplicantJobApplyDTO.Mail,
                ExpectedSalary = manageApplicantJobApplyDTO.ExpectedSalary,
                StartTime = manageApplicantJobApplyDTO.StartTime
            };
        }
        static ManageApplicantJobApplyDTO Convert(ApplicantJobApply applicantJobApply)
        {
            return new ManageApplicantJobApplyDTO()
            {
                Id = applicantJobApply.Id,
                ApplicantId = applicantJobApply.ApplicantId,
                PositionName = applicantJobApply.PositionName,
                Phone = applicantJobApply.Phone,
                Mail = applicantJobApply.Mail,
                ExpectedSalary = applicantJobApply.ExpectedSalary,
                StartTime = applicantJobApply.StartTime
            };
        }
    }
}

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
    public class ManageJobPostService
    {
        public static bool Create(ManageJobPostDTO manageJobPost)
        {
            var data = Convert(manageJobPost);
            return DataAccessFactory.ManageJobPostData().Create(data);
        }

        public static List<ManageJobPostDTO> Read()
        {
            var data = DataAccessFactory.ManageJobPostData().Read();
            return Convert(data);
        }

        public static ManageJobPostDTO Read(int id)
        {
            return Convert(DataAccessFactory.ManageJobPostData().Read(id));
        }

        public static bool Update(ManageJobPostDTO manageJobPost)
        {
            var data = Convert(manageJobPost);
            return DataAccessFactory.ManageJobPostData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ManageJobPostData().Delete(id);
        }

        static List<ManageJobPostDTO> Convert(List<ManageJobPost> manageJobPosts)
        {
            var data = new List<ManageJobPostDTO>();
            foreach (ManageJobPost manageJobPost in manageJobPosts)
            {
                data.Add(Convert(manageJobPost));
            }
            return data;
        }

        static List<ManageJobPost> Convert(List<ManageJobPostDTO> manageJobPosts)
        {
            var data = new List<ManageJobPost>();
            foreach (ManageJobPostDTO manageJobPost in manageJobPosts)
            {
                data.Add(Convert(manageJobPost));
            }
            return data;
        }

        static ManageJobPostDTO Convert(ManageJobPost manageJobPosts)
        {
            return new ManageJobPostDTO()
            {
                Id = manageJobPosts.Id,
                JobId = manageJobPosts.JobId,
                IsApproved = manageJobPosts.IsApproved
            };
        }

        static ManageJobPost Convert(ManageJobPostDTO manageJobPosts)
        {
            return new ManageJobPost()
            {
                Id = manageJobPosts.Id,
                JobId = manageJobPosts.JobId,
                IsApproved = manageJobPosts.IsApproved
            };
        }
    }
}

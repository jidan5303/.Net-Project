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
    public class ManageUsersService
    {
        public static bool Create(ManageUsersDTO manageUser)
        {
            var data = Convert(manageUser);
            return DataAccessFactory.ManagerUserData().Create(data);
        }

        public static List<ManageUsersDTO> Read()
        {
            var data = DataAccessFactory.ManagerUserData().Read();
            return Convert(data);
        }

        public static ManageUsersDTO Read(int id)
        {
            return Convert(DataAccessFactory.ManagerUserData().Read(id));
        }

        public static bool Update(ManageUsersDTO manageUsers)
        {
            var data = Convert(manageUsers);
            return DataAccessFactory.ManagerUserData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ManagerUserData().Delete(id);
        }

        static List<ManageUsersDTO> Convert(List<ManageUsers> manageUsers)
        {
            var data = new List<ManageUsersDTO>();
            foreach (ManageUsers manageUser in manageUsers) 
            {
                data.Add(Convert(manageUser));
            }
            return data;
        }

        static List<ManageUsers> Convert(List<ManageUsersDTO> manageUsers)
        {
            var data = new List<ManageUsers>();
            foreach(ManageUsersDTO manageUsersDTO in manageUsers)
            {
                data.Add(Convert(manageUsersDTO));
            }
            return data;
        }

        static ManageUsersDTO Convert(ManageUsers manageUsers) 
        {
            return new ManageUsersDTO()
            {
                Id = manageUsers.Id,
                ApplicantID = manageUsers.ApplicantID,
                EmployerID = manageUsers.EmployerID
            };
        }

        static ManageUsers Convert(ManageUsersDTO manageUsers)
        {
            return new ManageUsers()
            {
                Id = manageUsers.Id,
                ApplicantID = manageUsers.ApplicantID,
                EmployerID = manageUsers.EmployerID
            };
        }
    }
}

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
    public class EmployerProfileService
    {
        public static bool Create(EmployerProfileDTO obj)
        {
            var data = Convert(obj);
            return DataAccessFactory.EmployerProfileData().Create(data);
        }
        public static List<EmployerProfileDTO> Read()
        {
            var data = DataAccessFactory.EmployerProfileData().Read();
            return Convert(data);
        }
        public static EmployerProfileDTO Read(int id)
        {
            var data = DataAccessFactory.EmployerProfileData().Read(id);
            return Convert(data);
        }
        public static bool Update(EmployerProfileDTO obj)
        {
            var data = Convert(obj);
            return DataAccessFactory.EmployerProfileData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.EmployerProfileData().Delete(id);
        }
        static EmployerProfile Convert(EmployerProfileDTO obj)
        {
            return new EmployerProfile()
            {
                Id = obj.Id,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                Email = obj.Email,
                PhoneNumber = obj.PhoneNumber,
                Nationality = obj.Nationality,
                DateOfBirth = obj.DateOfBirth,
                Gender = obj.Gender,
                User_Id = obj.User_Id
            };
        }
        static List<EmployerProfile> Convert(List<EmployerProfileDTO> list)
        {
            var data = new List<EmployerProfile>();
            foreach (var item in list)
            {
                data.Add(new EmployerProfile()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    PhoneNumber = item.PhoneNumber,
                    Nationality = item.Nationality,
                    DateOfBirth = item.DateOfBirth,
                    Gender = item.Gender,
                    User_Id = item.User_Id
                });
            }
            return data;
        }
        static EmployerProfileDTO Convert(EmployerProfile obj)
        {
            return new EmployerProfileDTO()
            {
                Id = obj.Id,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                Email = obj.Email,
                PhoneNumber = obj.PhoneNumber,
                Nationality = obj.Nationality,
                DateOfBirth = obj.DateOfBirth,
                Gender = obj.Gender,
                User_Id = obj.User_Id
            };
        }
        static List<EmployerProfileDTO> Convert(List<EmployerProfile> list)
        {
            var data = new List<EmployerProfileDTO>();
            foreach (var item in list)
            {
                data.Add(new EmployerProfileDTO()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    PhoneNumber = item.PhoneNumber,
                    Nationality = item.Nationality,
                    DateOfBirth = item.DateOfBirth,
                    Gender = item.Gender,
                    User_Id = item.User_Id
                });
            }
            return data;
        }
    }
}

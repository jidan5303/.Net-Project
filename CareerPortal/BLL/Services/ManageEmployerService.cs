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
    public class ManageEmployerService
    {
        public static bool Create(ManageEmployerDTO manageEmployer)
        {
            var data = Convert(manageEmployer);
            return DataAccessFactory.ManageEmployerData().Create(data);
        }

        public static List<ManageEmployerDTO> Read()
        {
            var data = DataAccessFactory.ManageEmployerData().Read();
            return Convert(data);
        }

        public static ManageEmployerDTO Read(int id)
        {
            return Convert(DataAccessFactory.ManageEmployerData().Read(id));
        }

        public static bool Update(ManageEmployerDTO manageEmployer)
        {
            var data = Convert(manageEmployer);
            return DataAccessFactory.ManageEmployerData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ManageEmployerData().Delete(id);
        }

        static List<ManageEmployerDTO> Convert(List<EmployerProfile> manageEmployers)
        {
            var data = new List<ManageEmployerDTO>();
            foreach (EmployerProfile manageEmployer in manageEmployers)
            {
                data.Add(Convert(manageEmployer));
            }
            return data;
        }

        static List<EmployerProfile> Convert(List<ManageEmployerDTO> manageEmployerDTOs)
        {
            var data = new List<EmployerProfile>();
            foreach (ManageEmployerDTO manageEmployerDTO in manageEmployerDTOs)
            {
                data.Add(Convert(manageEmployerDTO));
            }
            return data;
        }

        static ManageEmployerDTO Convert(EmployerProfile manageEmployer)
        {
            return new ManageEmployerDTO()
            {
                Id = manageEmployer.Id,
                FirstName = manageEmployer.FirstName,
                LastName = manageEmployer.LastName,
                Email = manageEmployer.Email,
                PhoneNumber = manageEmployer.PhoneNumber,
                Nationality = manageEmployer.Nationality,
                DateOfBirth = manageEmployer.DateOfBirth,
                Gender = manageEmployer.Gender,
                User_Id = manageEmployer.User_Id
            };
        }

        static EmployerProfile Convert(ManageEmployerDTO manageEmployerDTO)
        {
            return new EmployerProfile()
            {
                Id = manageEmployerDTO.Id,
                FirstName = manageEmployerDTO.FirstName,
                LastName = manageEmployerDTO.LastName,
                Email = manageEmployerDTO.Email,
                PhoneNumber  = manageEmployerDTO.PhoneNumber,
                Nationality = manageEmployerDTO.Nationality,
                DateOfBirth = manageEmployerDTO.DateOfBirth,
                Gender = manageEmployerDTO.Gender,
                User_Id = manageEmployerDTO.User_Id
            };
        }
    }
}

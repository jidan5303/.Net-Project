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
    public class ManageCategoryService
    {
        public static bool Create(ManageCategoryDTO manageCategory)
        {
            var data = Convert(manageCategory);
            return DataAccessFactory.ManageCategoryData().Create(data);
        }

        public static List<ManageCategoryDTO> Read()
        {
            var data = DataAccessFactory.ManageCategoryData().Read();
            return Convert(data);
        }

        public static ManageCategoryDTO Read(int id)
        {
            return Convert(DataAccessFactory.ManageCategoryData().Read(id));
        }

        public static bool Update(ManageCategoryDTO manageCategory)
        {
            var data = Convert(manageCategory);
            return DataAccessFactory.ManageCategoryData().Update(data);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ManageCategoryData().Delete(id);
        }

        static List<ManageCategoryDTO> Convert(List<ManageCategory> manageCategories)
        {
            var data = new List<ManageCategoryDTO>();
            foreach (ManageCategory manageCategory in manageCategories)
            {
                data.Add(Convert(manageCategory));
            }
            return data;
        }

        static List<ManageCategory> Convert(List<ManageCategoryDTO> manageCategoryDTOs)
        {
            var data = new List<ManageCategory>();
            foreach (ManageCategoryDTO manageCategoryDTO in manageCategoryDTOs)
            {
                data.Add(Convert(manageCategoryDTO));
            }
            return data;
        }

        static ManageCategoryDTO Convert(ManageCategory manageCategory)
        {
            return new ManageCategoryDTO()
            {
                Id = manageCategory.Id,
                Name = manageCategory.Name
            };
        }

        static ManageCategory Convert(ManageCategoryDTO manageCategoryDTO)
        {
            return new ManageCategory()
            {
                Id = manageCategoryDTO.Id,
                Name = manageCategoryDTO.Name
            };
        }
    }
}

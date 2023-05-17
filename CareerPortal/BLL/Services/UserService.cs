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
    public class UserService
    {
        public static bool Create(UserDTO obj)
        {
            var data = Convert(obj);
            return DataAccessFactory.UserData().Create(data);
        }
        public static List<UserDTO> Read()
        {
            var data = DataAccessFactory.UserData().Read();
            return Convert(data);
        }
        public static UserDTO Read(int id)
        {
            var data = DataAccessFactory.UserData().Read(id);
            return Convert(data);
        }
        public static bool Update(UserDTO obj)
        {
            var data = Convert(obj);
            return DataAccessFactory.UserData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.UserData().Delete(id);
        }
        static User Convert(UserDTO obj)
        {
            return new User()
            {
                Id = obj.Id,
                Username = obj.Username,
                Password = obj.Password,
                Type = obj.Type
            };
        }
        static List<User> Convert(List<UserDTO> list)
        {
            var data = new List<User>();
            foreach (var item in list)
            {
                data.Add(new User()
                {
                    Id = item.Id,
                    Username = item.Username,
                    Password = item.Password,
                    Type = item.Type
                });
            }
            return data;
        }
        static UserDTO Convert(User obj)
        {
            return new UserDTO()
            {
                Id = obj.Id,
                Username = obj.Username,
                Password = obj.Password,
                Type = obj.Type
            };
        }
        static List<UserDTO> Convert(List<User> list)
        {
            var data = new List<UserDTO>();
            foreach (var item in list)
            {
                data.Add(new UserDTO()
                {
                    Id = item.Id,
                    Username = item.Username,
                    Password = item.Password,
                    Type = item.Type
                });
            }
            return data;
        }
    }
}

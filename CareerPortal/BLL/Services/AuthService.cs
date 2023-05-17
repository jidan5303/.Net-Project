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
    public class AuthService
    {
        public static TokenDTO Authenticate(string username, string password, string type)
        {
            var result = DataAccessFactory.AuthData().Authenticate(username, password, type);
            if (result)
            {
                var token = new Token();
                token.Type = type;
                token.Username = username;
                token.CreatedAt = DateTime.Now;
                token.TokenKey = Guid.NewGuid().ToString();

                var data = DataAccessFactory.TokenData().Create(token);
                if (data != null)
                {
                    return Convert(data);
                }
            }
            return null;
        }

        public static bool IsTokenValid(string tokenKey)
        {
            var existingToken = DataAccessFactory.TokenData().Read(tokenKey);
            if (existingToken != null && existingToken.DeletedAt == null)
            {
                return true;
            }
            return false;
        }

        public static bool IsAdmin(string tokenKey)
        {
            var existingToken = DataAccessFactory.TokenData().Read(tokenKey);
            if (existingToken != null && existingToken.Type.Equals("Admin"))
            {
                return true;
            }
            return false;
        }

        public static bool IsEmployer(string tokenKey)
        {
            var existingToken = DataAccessFactory.TokenData().Read(tokenKey);
            if (existingToken != null && existingToken.Type.Equals("Employer"))
            {
                return true;
            }
            return false;
        }

        public static bool IsApplicant(string tokenKey)
        {
            var existingToken = DataAccessFactory.TokenData().Read(tokenKey);
            if (existingToken != null && existingToken.Type.Equals("Applicant"))
            {
                return true;
            }
            return false;
        }

        public static bool Logout(string tokenKey)
        {
            var existingToken = DataAccessFactory.TokenData().Read(tokenKey);
            existingToken.DeletedAt = DateTime.Now;
            if (DataAccessFactory.TokenData().Update(existingToken) != null)
            {
                return true;
            }
            return false;
        }

        static TokenDTO Convert(Token obj)
        {
            return new TokenDTO()
            {
                TokenKey = obj.TokenKey,
                CreatedAt = obj.CreatedAt,
                DeletedAt = obj.DeletedAt,
                Type = obj.Type,
                Username = obj.Username
            };
        }
    }
}

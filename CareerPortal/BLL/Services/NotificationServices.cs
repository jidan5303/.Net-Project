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
    public class NotificationServices
    {
        static List<NotificationDTO> Convert(List<Notification> notifications)
        {
            var data = new List<NotificationDTO>();
            foreach (Notification notification in notifications)
            {
                data.Add(Convert(notification));
            }
            return data;
        }
        static NotificationDTO Convert(Notification notification)
        {
            return new NotificationDTO()
            {
                Id = notification.Id,
                ApplicantId = notification.ApplicantId,
                Message = notification.Message
            };
        }
        static Notification Convert(NotificationDTO notification)
        {
            return new Notification()
            {
                Id = notification.Id,
                ApplicantId = notification.ApplicantId,
                Message = notification.Message
            };
        }
        public static List<NotificationDTO> Read()
        {
            var data = DataAccessFactory.NotificationData().Read();
            return Convert(data);
        }
        public static NotificationDTO Read(int id)
        {
            return Convert(DataAccessFactory.NotificationData().Read(id));
        }
        public static bool Create(NotificationDTO notification)
        {
            var data = Convert(notification);
            return DataAccessFactory.NotificationData().Create(data);
        }
        public static bool Update(NotificationDTO notification)
        {
            var data = Convert(notification);
            return DataAccessFactory.NotificationData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.NotificationData().Delete(id);
        }
    }
}

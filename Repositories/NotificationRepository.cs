using DataAccess;
using DataAccess.DTO;
using DataAccess.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        NotificationDAO notificationDAO = new NotificationDAO();
        public void CreateNotification(NotificationDTO notificationDTO)
        {
            notificationDAO.CreateNotification(Mapper.mapToEntity(notificationDTO));
        }

        public void DeleteNotification(int id)
        {
            notificationDAO.DeleteNotification(id);
        }

        public NotificationDTO GetNotificationById(int id)
        {
            return Mapper.mapToDTO(notificationDAO.GetNotificationById(id));
        }

        public List<NotificationDTO> GetNotifications()
        {
            return notificationDAO.GetNotifications().Select(m => Mapper.mapToDTO(m)).ToList();
        }
    }
}

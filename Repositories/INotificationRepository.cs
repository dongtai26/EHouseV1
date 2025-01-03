﻿using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface INotificationRepository
    {
        List<NotificationDTO> GetNotifications();
        void CreateNotification(NotificationDTO notificationDTO);
        void DeleteNotification(int id);
        NotificationDTO GetNotificationById(int id);
    }
}

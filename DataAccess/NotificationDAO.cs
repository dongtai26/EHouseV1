using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NotificationDAO
    {
        public List<Notification> GetNotifications()
        {
            var ListNotification = new List<Notification>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListNotification = context.Notifications.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListNotification;
        }
        public void CreateNotification(Notification notification)
        {
            try
            {
                var db = new AppDbContext();
                db.Notifications.Add(notification);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteNotification(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var nDelete = context.Notifications.SingleOrDefault(x => x.NoId == id);
                    context.Notifications.Remove(nDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Notification GetNotificationById (int id)
        {
            Notification notification = new Notification();
            try
            {
                var db = new AppDbContext();
                notification = db.Notifications.SingleOrDefault(x => x.NoId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return notification;
        }
    }
}

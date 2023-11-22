using System.Collections.Generic;
using System.Linq;

namespace Curso.NotificationContext
{
    public abstract class notifiable
    {
        public List<Notification> Notifications { get; set;}
        public void AddNotification (Notification notification)
        {
            Notifications.Add(notification);
        }
         public void Addnotifications (IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
        public bool IsInvalid => Notifications.Any();
    }
}
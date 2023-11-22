using System;
using Curso.NotificationContext;

namespace Curso.ContentContext
{
    public abstract class Base : notifiable
    { public Base()
    {
        Id = Guid.NewGuid();
    }
        public Guid Id { get; set; }
    }
}
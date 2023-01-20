using System;

namespace Reminder.Models
{
    public class ReminderTask
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public string Comment { get; set; }
    }
}

using System;

namespace Reminder.Models
{
    public class ReminderTask
    {
        public Guid Id { get; set; }
        // TODO public? Конструктор не нужен?
        public string Name { get; set; }
        // TODO или всё-така только время или в string?
        public DateTime Time { get; set; }
        public string Comment { get; set; }
    }
}

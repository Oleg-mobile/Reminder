using Reminder.Models;
using System;
using System.Windows.Forms;

namespace Reminder.Forms
{
    public partial class TaskForm : Form
    {

        public TaskForm()
        {
            InitializeComponent();

            dateTimePickerTask.Value = DateTime.Now;
            monthCalendarTask.TodayDate = DateTime.Now;
        }

        public TaskForm(ReminderTask task) : this()
        {
            DateTime date = DateTime.Now.Date.Add(new TimeSpan(task.Time.Hour, task.Time.Minute, 0));  // Текущая дата и время из заявки

            monthCalendarTask.BoldedDates = new DateTime[] { task.Time };  // Выделяем дату события
            textBoxName.Text = task.Name;
            dateTimePickerTask.Value = date;
            textBoxComment.Text = task.Comment;
        }

        public ReminderTask GetTask()
        {
            DateTime time = dateTimePickerTask.Value;

            return new ReminderTask
            {
                Id = Guid.NewGuid(),
                Name = textBoxName.Text,
                Time = time.AddSeconds(-time.Second),
                Comment = textBoxComment.Text,
            };
        }

        public void UpdateTask(ReminderTask task)
        {
            DateTime time = dateTimePickerTask.Value;

            task.Name = textBoxName.Text;
            task.Time = time.AddSeconds(-time.Second);
            task.Comment = textBoxComment.Text;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}

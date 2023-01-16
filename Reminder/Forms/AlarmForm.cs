using Reminder.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Reminder.Forms
{
    public partial class AlarmForm : Form
    {
        private readonly ReminderTask _task;
        private readonly string _pathToFile;
        private readonly MainForm _mainForm;
        private List<ReminderTask> myTasks = new List<ReminderTask>();

        public AlarmForm(ReminderTask myTask, string pathToFile, MainForm mainForm)
        {
            InitializeComponent();
            _task = myTask;
            _pathToFile = pathToFile;
            _mainForm = mainForm;

            Utils.InitTasks(_pathToFile, myTasks);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            Close();

            _task.Time = DateTime.Now.AddMinutes(1);

            Utils.RefrashTable(_mainForm, myTasks);
            Utils.UpdateFile(_pathToFile, myTasks);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Close();

            var taskForm = new TaskForm(_task);

            DialogResult result = taskForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            taskForm.UpdateTask(_task);

            Utils.RefrashTable(_mainForm, myTasks);
            Utils.UpdateFile(_pathToFile, myTasks);
        }
    }
}

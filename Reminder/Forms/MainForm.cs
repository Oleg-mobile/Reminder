using Newtonsoft.Json;
using Reminder.Forms;
using Reminder.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Reminder
{
    public partial class MainForm : Form
    {
        // TODO Где лучше хранить файл?
        private readonly string _pathToFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Tasks.json");
        private List<ReminderTask> tasksList = new List<ReminderTask>(); // TODO а если без new List<MyTask>()?

        public MainForm()
        {
            InitializeComponent();

            timerMain.Start();

            // TODO куда это убрать из конструктора?
            Utils.InitTasks(_pathToFile, tasksList);
            Utils.RefrashTable(this, tasksList);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var taskForm = new TaskForm();
            DialogResult result = taskForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            tasksList.Add(taskForm.GetTask());

            Utils.RefrashTable(this, tasksList);

            if (!File.Exists(_pathToFile))
            {
                File.WriteAllText(_pathToFile, string.Empty);
            }

            Utils.UpdateFile(_pathToFile, tasksList);
        }

        public void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                var task = (ReminderTask)dataGridViewTasks.SelectedRows[0].DataBoundItem;
                int index = tasksList.FindIndex(i => i == task);

                var taskForm = new TaskForm(task);
                DialogResult result = taskForm.ShowDialog();

                if (result == DialogResult.Cancel) return;

                tasksList[index] = taskForm.GetTask();

                Utils.RefrashTable(this, tasksList);
                Utils.UpdateFile(_pathToFile, tasksList);
            }
        }

        private void buttonDell_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewTasks.SelectedRows.Count; i++)
            {
                var task = (ReminderTask)dataGridViewTasks.SelectedRows[i].DataBoundItem;
                tasksList.Remove(task);
            }

            Utils.RefrashTable(this, tasksList);
            Utils.UpdateFile(_pathToFile, tasksList);
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            foreach (var task in tasksList)
            {
                // TODO не сравнивает даты
                if (task.Time.ToString() == DateTime.Now.ToString())
                //if (DateTime.Compare(task.Time, DateTime.Now) == 0)
                {
                    var alarmForm = new AlarmForm(task, _pathToFile, this);
                    alarmForm.Show();
                    alarmForm.labelComment.Text = $"Событие: {task.Name}. Сообщение: {task.Comment}";
                }
            }
        }
    }
}

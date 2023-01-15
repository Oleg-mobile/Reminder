using Newtonsoft.Json;
using Reminder.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

            // TODO код как на главной форме
            if (File.Exists(_pathToFile))
            {
                if (new FileInfo(_pathToFile).Length > 0)
                {
                    try
                    {
                        myTasks = JsonConvert.DeserializeObject<List<ReminderTask>>(File.ReadAllText(_pathToFile));
                    }
                    catch (JsonReaderException)
                    {
                        Utils.ShowMessage($"Ошибка чтения файла {_pathToFile}");
                    }
                    catch (JsonSerializationException)
                    {
                        Utils.ShowMessage($"Не корректный файл {_pathToFile}");
                    }
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // TODO что делать с отработанным уведомлением? Удалить?
            Close();
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            Close();

            //int index = myTasks.FindIndex(i => i.Name == _task.Name);

            _task.Time = DateTime.Now.AddMinutes(1);

            //myTasks[index] = _task;

            Utils.RefrashTable(_mainForm, myTasks);
            Utils.UpdateFile(_pathToFile, myTasks);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Close();
            // TODO нужен id? По объекту не видит
            //int index = myTasks.FindIndex(i => i.Name == _task.Name);

            var taskForm = new TaskForm(_task);

            DialogResult result = taskForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            //myTasks[index] = taskForm.GetTask();
            taskForm.UpdateTask(_task);

            Utils.RefrashTable(_mainForm, myTasks);
            Utils.UpdateFile(_pathToFile, myTasks);
        }
    }
}

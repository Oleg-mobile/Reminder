using Newtonsoft.Json;
using Reminder.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Reminder
{
    public static class Utils
    {
        public static void RefrashTable(MainForm form, List<ReminderTask> list)
        {
            BindingList<ReminderTask> bindingList = new BindingList<ReminderTask>(list);

            form.dataGridViewTasks.DataSource = bindingList;

            form.dataGridViewTasks.Columns[0].HeaderText = "Название";
            form.dataGridViewTasks.Columns[1].HeaderText = "Время";
            //form.dataGridViewTasks.Columns[1].DefaultCellStyle.Format = "HH:mm";
            form.dataGridViewTasks.Columns[2].HeaderText = "Комментарий";
        }

        public static void UpdateFile(string pathToFile, List<ReminderTask> list)
        {
            if (string.IsNullOrWhiteSpace(pathToFile)) return;

            if (!File.Exists(pathToFile)) return;

            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(pathToFile, json);
        }

        public static void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}

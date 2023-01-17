using Reminder.Forms;
using Reminder.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Drawing;

namespace Reminder
{
    public partial class MainForm : Form
    {
        // TODO Где лучше хранить файл?
        private readonly string _pathToFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Tasks.json");
        private List<ReminderTask> tasksList = new List<ReminderTask>(); // TODO а если без new List<MyTask>()?

        // Поля
        private IconButton currentButton;
        private Panel leftBorderButton;

        public MainForm()
        {
            InitializeComponent();

            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 45);
            panelMenu.Controls.Add(leftBorderButton);

            timerMain.Start();

            // TODO куда это убрать из конструктора?
            Utils.InitTasks(_pathToFile, tasksList);
            Utils.RefrashTable(this, tasksList);
        }

        // Цвета для кнопок
        private struct ButtonsColors
        {
            public static Color colorBtnAdd = Color.BlueViolet;
            public static Color colorBtnEdit = Color.PaleVioletRed;
            public static Color colorBtnDel = Color.Salmon;
            public static Color colorBtnSett = Color.RoyalBlue;
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                // Настройки кнопок
                currentButton = (IconButton)sender;
                currentButton.BackColor = Color.MediumPurple;
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                // Настройки панели кнопок
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
                // Иконка дочерней формы
                iconPictureBoxFormIcon.IconChar = currentButton.IconChar;
                iconPictureBoxFormIcon.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                // Значения по умолчанию
                currentButton.BackColor = Color.DarkSlateBlue;
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderButton.Visible = false;
            iconPictureBoxFormIcon.IconChar = IconChar.Home;
            iconPictureBoxFormIcon.IconColor = Color.SandyBrown;
            labelFormName.Text = "Начальная страница";
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

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ButtonsColors.colorBtnAdd);

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

        private void iconButtonEdit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ButtonsColors.colorBtnEdit);

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

        private void iconButtonDelite_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ButtonsColors.colorBtnDel);

            for (int i = 0; i < dataGridViewTasks.SelectedRows.Count; i++)
            {
                var task = (ReminderTask)dataGridViewTasks.SelectedRows[i].DataBoundItem;
                tasksList.Remove(task);
            }

            Utils.RefrashTable(this, tasksList);
            Utils.UpdateFile(_pathToFile, tasksList);
        }

        private void iconButtonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ButtonsColors.colorBtnAdd);


        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

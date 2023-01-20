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
    // TODO
    // 1. Вынести рабуту с файлом в интерфейс и класс (методы Add, GetAll, ...)
    // 2. Вынести инициализацию и рефреш из конструктора в форм лоад?
    // 3. Заменить таймер винформс на список таймеров c# (выполнять метод с задержкой)
    // 4. Создать конструктор (id генерить в нём) и пустой для десериализации (т.к. id там уже есть)
    // 5. При изменении заявки спросить - создавать новую, чтобы хранить историю или изменить текущую
    //    (сообщение устарело - изменить дату?) и чекбокс - больше не показывать такое уведомление.
    // 6. Настройки - предупреждать об устаревшей напоминалке, чекбокс - хранить ли устаревшие уведомления
    // 7. Виды уведомлений - разовые (не предлагает продлить), периодические
    // 8. На главной форме кнопка - прошедшие уведомления (история с фильтрами) - другая форма
    // 9. Форма с испторий и фильтрами (дата, ...)
    // 10. В классе заявок булева переменная изФинишед?


    public partial class MainForm : Form
    {
        private readonly string _pathToFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Tasks.json");
        private readonly List<ReminderTask> _tasksList = new List<ReminderTask>();

        // Поля
        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();

            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 45);
            panelMenu.Controls.Add(leftBorderButton);

            timerMain.Start();

            Utils.InitTasks(_pathToFile, _tasksList);
            Utils.RefrashTable(this, _tasksList);
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
            labelFormName.Text = "Список напоминаний";
        }

        private Form OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelFormName.Text = childForm.Text;
            return childForm;
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            foreach (var task in _tasksList)
            {
                if (task.Time.ToString() == DateTime.Now.ToString())
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

            //var taskForm = new TaskForm();
            //DialogResult result = taskForm.ShowDialog();

            TaskForm taskForm = (TaskForm)OpenChildForm(new TaskForm());

            //if (result == DialogResult.Cancel) return;

            _tasksList.Add(taskForm.GetTask());

            Utils.RefrashTable(this, _tasksList);

            if (!File.Exists(_pathToFile))
            {
                File.WriteAllText(_pathToFile, string.Empty);
            }

            Utils.UpdateFile(_pathToFile, _tasksList);
        }

        private void iconButtonEdit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ButtonsColors.colorBtnEdit);

            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                var task = (ReminderTask)dataGridViewTasks.SelectedRows[0].DataBoundItem;
                int index = _tasksList.FindIndex(i => i == task);

                //var taskForm = new TaskForm(task);
                //DialogResult result = taskForm.ShowDialog();

                //if (result == DialogResult.Cancel) return;

                TaskForm taskForm = (TaskForm)OpenChildForm(new TaskForm());

                _tasksList[index] = taskForm.GetTask();

                Utils.RefrashTable(this, _tasksList);
                Utils.UpdateFile(_pathToFile, _tasksList);
            }
        }

        private void iconButtonDelite_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ButtonsColors.colorBtnDel);

            for (int i = 0; i < dataGridViewTasks.SelectedRows.Count; i++)
            {
                var task = (ReminderTask)dataGridViewTasks.SelectedRows[i].DataBoundItem;
                _tasksList.Remove(task);
            }

            Utils.RefrashTable(this, _tasksList);
            Utils.UpdateFile(_pathToFile, _tasksList);
        }

        private void iconButtonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ButtonsColors.colorBtnAdd);

            SettingsForm setForm = (SettingsForm)OpenChildForm(new SettingsForm());
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            Reset();
        }
    }
}

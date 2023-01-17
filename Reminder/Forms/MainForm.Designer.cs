namespace Reminder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.iconButtonSettings = new FontAwesome.Sharp.IconButton();
            this.iconButtonDelite = new FontAwesome.Sharp.IconButton();
            this.iconButtonEdit = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelFormName = new System.Windows.Forms.Label();
            this.iconPictureBoxFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormIcon)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AllowUserToAddRows = false;
            this.dataGridViewTasks.AllowUserToDeleteRows = false;
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(48, 37);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.ReadOnly = true;
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.Size = new System.Drawing.Size(619, 311);
            this.dataGridViewTasks.TabIndex = 3;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenu.Controls.Add(this.iconButtonExit);
            this.panelMenu.Controls.Add(this.iconButtonSettings);
            this.panelMenu.Controls.Add(this.iconButtonDelite);
            this.panelMenu.Controls.Add(this.iconButtonEdit);
            this.panelMenu.Controls.Add(this.iconButtonAdd);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 448);
            this.panelMenu.TabIndex = 4;
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconButtonExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 32;
            this.iconButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.Location = new System.Drawing.Point(0, 298);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonExit.Size = new System.Drawing.Size(220, 45);
            this.iconButtonExit.TabIndex = 9;
            this.iconButtonExit.Text = "Выйти";
            this.iconButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // iconButtonSettings
            // 
            this.iconButtonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSettings.FlatAppearance.BorderSize = 0;
            this.iconButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconButtonSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSettings.IconSize = 32;
            this.iconButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.Location = new System.Drawing.Point(0, 253);
            this.iconButtonSettings.Name = "iconButtonSettings";
            this.iconButtonSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSettings.Size = new System.Drawing.Size(220, 45);
            this.iconButtonSettings.TabIndex = 8;
            this.iconButtonSettings.Text = "Настройки";
            this.iconButtonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSettings.UseVisualStyleBackColor = true;
            this.iconButtonSettings.Click += new System.EventHandler(this.iconButtonSettings_Click);
            // 
            // iconButtonDelite
            // 
            this.iconButtonDelite.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDelite.FlatAppearance.BorderSize = 0;
            this.iconButtonDelite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonDelite.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDelite.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonDelite.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDelite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelite.IconSize = 32;
            this.iconButtonDelite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDelite.Location = new System.Drawing.Point(0, 208);
            this.iconButtonDelite.Name = "iconButtonDelite";
            this.iconButtonDelite.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonDelite.Size = new System.Drawing.Size(220, 45);
            this.iconButtonDelite.TabIndex = 7;
            this.iconButtonDelite.Text = "Удалить";
            this.iconButtonDelite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDelite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDelite.UseVisualStyleBackColor = true;
            this.iconButtonDelite.Click += new System.EventHandler(this.iconButtonDelite_Click);
            // 
            // iconButtonEdit
            // 
            this.iconButtonEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonEdit.FlatAppearance.BorderSize = 0;
            this.iconButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEdit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEdit.IconSize = 32;
            this.iconButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEdit.Location = new System.Drawing.Point(0, 163);
            this.iconButtonEdit.Name = "iconButtonEdit";
            this.iconButtonEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonEdit.Size = new System.Drawing.Size(220, 45);
            this.iconButtonEdit.TabIndex = 6;
            this.iconButtonEdit.Text = "Изменить";
            this.iconButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEdit.UseVisualStyleBackColor = true;
            this.iconButtonEdit.Click += new System.EventHandler(this.iconButtonEdit_Click);
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAdd.FlatAppearance.BorderSize = 0;
            this.iconButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAdd.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.IconSize = 32;
            this.iconButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdd.Location = new System.Drawing.Point(0, 118);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonAdd.Size = new System.Drawing.Size(220, 45);
            this.iconButtonAdd.TabIndex = 5;
            this.iconButtonAdd.Text = "Добавить";
            this.iconButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdd.UseVisualStyleBackColor = true;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 118);
            this.panelLogo.TabIndex = 1;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLogo.Location = new System.Drawing.Point(97, 47);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(90, 24);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "ЭВРИКА!";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Reminder.Properties.Resources.einstein;
            this.pictureBoxLogo.Location = new System.Drawing.Point(28, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(65, 57);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelTitleBar.Controls.Add(this.labelFormName);
            this.panelTitleBar.Controls.Add(this.iconPictureBoxFormIcon);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(717, 58);
            this.panelTitleBar.TabIndex = 5;
            // 
            // labelFormName
            // 
            this.labelFormName.AutoSize = true;
            this.labelFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormName.Location = new System.Drawing.Point(53, 21);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(148, 17);
            this.labelFormName.TabIndex = 1;
            this.labelFormName.Text = "Список напоминаний";
            // 
            // iconPictureBoxFormIcon
            // 
            this.iconPictureBoxFormIcon.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPictureBoxFormIcon.ForeColor = System.Drawing.Color.SandyBrown;
            this.iconPictureBoxFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBoxFormIcon.IconColor = System.Drawing.Color.SandyBrown;
            this.iconPictureBoxFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxFormIcon.Location = new System.Drawing.Point(11, 13);
            this.iconPictureBoxFormIcon.Name = "iconPictureBoxFormIcon";
            this.iconPictureBoxFormIcon.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxFormIcon.TabIndex = 0;
            this.iconPictureBoxFormIcon.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelDesktop.Controls.Add(this.dataGridViewTasks);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 58);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(717, 390);
            this.panelDesktop.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 448);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Напоминалка";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFormIcon)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelLogo;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private FontAwesome.Sharp.IconButton iconButtonSettings;
        private FontAwesome.Sharp.IconButton iconButtonDelite;
        private FontAwesome.Sharp.IconButton iconButtonEdit;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFormIcon;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.Panel panelDesktop;
    }
}


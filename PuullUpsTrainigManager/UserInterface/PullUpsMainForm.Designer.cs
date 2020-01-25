namespace PuullUpsTrainigManager
{
    partial class PullUpsMainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.тренировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ResultsTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserNameHeaderLbl = new System.Windows.Forms.Label();
            this.PlotGroupBox = new System.Windows.Forms.GroupBox();
            this.MainMenu.SuspendLayout();
            this.ResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тренировкаToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(748, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "Главное меню";
            // 
            // тренировкаToolStripMenuItem
            // 
            this.тренировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРезультатToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.тренировкаToolStripMenuItem.Name = "тренировкаToolStripMenuItem";
            this.тренировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.тренировкаToolStripMenuItem.Text = "Тренировка";
            // 
            // добавитьРезультатToolStripMenuItem
            // 
            this.добавитьРезультатToolStripMenuItem.Name = "добавитьРезультатToolStripMenuItem";
            this.добавитьРезультатToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.добавитьРезультатToolStripMenuItem.Text = "Добавить результат";
            this.добавитьРезультатToolStripMenuItem.Click += new System.EventHandler(this.добавитьРезультатToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Controls.Add(this.DeleteBtn);
            this.ResultsGroupBox.Controls.Add(this.AddBtn);
            this.ResultsGroupBox.Controls.Add(this.ResultsTable);
            this.ResultsGroupBox.Controls.Add(this.UserNameLbl);
            this.ResultsGroupBox.Controls.Add(this.UserNameHeaderLbl);
            this.ResultsGroupBox.Location = new System.Drawing.Point(5, 25);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(270, 390);
            this.ResultsGroupBox.TabIndex = 2;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Результаты";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(150, 350);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(90, 30);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(30, 350);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 30);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ResultsTable
            // 
            this.ResultsTable.AllowUserToAddRows = false;
            this.ResultsTable.AllowUserToDeleteRows = false;
            this.ResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Result});
            this.ResultsTable.Location = new System.Drawing.Point(10, 40);
            this.ResultsTable.Name = "ResultsTable";
            this.ResultsTable.ReadOnly = true;
            this.ResultsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultsTable.Size = new System.Drawing.Size(250, 305);
            this.ResultsTable.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "Идентификатор";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Результат";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(75, 20);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(10, 13);
            this.UserNameLbl.TabIndex = 1;
            this.UserNameLbl.Text = " ";
            // 
            // UserNameHeaderLbl
            // 
            this.UserNameHeaderLbl.AutoSize = true;
            this.UserNameHeaderLbl.Location = new System.Drawing.Point(10, 20);
            this.UserNameHeaderLbl.Name = "UserNameHeaderLbl";
            this.UserNameHeaderLbl.Size = new System.Drawing.Size(63, 13);
            this.UserNameHeaderLbl.TabIndex = 0;
            this.UserNameHeaderLbl.Text = "Спортсмен";
            // 
            // PlotGroupBox
            // 
            this.PlotGroupBox.BackColor = System.Drawing.Color.White;
            this.PlotGroupBox.Location = new System.Drawing.Point(280, 30);
            this.PlotGroupBox.Name = "PlotGroupBox";
            this.PlotGroupBox.Size = new System.Drawing.Size(460, 385);
            this.PlotGroupBox.TabIndex = 3;
            this.PlotGroupBox.TabStop = false;
            this.PlotGroupBox.Text = "График результатов";
            // 
            // PullUpsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 424);
            this.Controls.Add(this.PlotGroupBox);
            this.Controls.Add(this.ResultsGroupBox);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "PullUpsMainForm";
            this.Text = "Программа учёта тренировок по подтягиваниям";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PullUpsMainForm_FormClosing);
            this.Load += new System.EventHandler(this.PullUpsMainForm_Load);
            this.Shown += new System.EventHandler(this.PullUpsMainForm_Shown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem тренировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРезультатToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.DataGridView ResultsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label UserNameHeaderLbl;
        private System.Windows.Forms.GroupBox PlotGroupBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}


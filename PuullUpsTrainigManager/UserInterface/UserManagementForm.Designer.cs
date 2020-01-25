namespace PuullUpsTrainigManager.UserInterface
{
    partial class UserManagementForm
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
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SelectUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AllowUserToAddRows = false;
            this.UsersDataGrid.AllowUserToDeleteRows = false;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CurrentMax,
            this.UserName});
            this.UsersDataGrid.Location = new System.Drawing.Point(5, 5);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.ReadOnly = true;
            this.UsersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGrid.Size = new System.Drawing.Size(250, 400);
            this.UsersDataGrid.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "Идентификатор";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CurrentMax
            // 
            this.CurrentMax.HeaderText = "Последний результат";
            this.CurrentMax.Name = "CurrentMax";
            this.CurrentMax.ReadOnly = true;
            this.CurrentMax.Visible = false;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Имя";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 200;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(260, 5);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(90, 30);
            this.AddUserBtn.TabIndex = 1;
            this.AddUserBtn.Text = "Добавить";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Location = new System.Drawing.Point(260, 45);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(90, 30);
            this.DeleteUserBtn.TabIndex = 2;
            this.DeleteUserBtn.Text = "Удалить";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(260, 375);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 30);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SelectUserBtn
            // 
            this.SelectUserBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SelectUserBtn.Location = new System.Drawing.Point(260, 85);
            this.SelectUserBtn.Name = "SelectUserBtn";
            this.SelectUserBtn.Size = new System.Drawing.Size(90, 30);
            this.SelectUserBtn.TabIndex = 4;
            this.SelectUserBtn.Text = "Выбрать";
            this.SelectUserBtn.UseVisualStyleBackColor = true;
            this.SelectUserBtn.Click += new System.EventHandler(this.SelectUserBtn_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(359, 408);
            this.ControlBox = false;
            this.Controls.Add(this.SelectUserBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.UsersDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserManagementForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спортсмены";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SelectUserBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}
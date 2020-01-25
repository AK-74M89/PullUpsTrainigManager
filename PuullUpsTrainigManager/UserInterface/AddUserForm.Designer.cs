namespace PuullUpsTrainigManager.UserInterface
{
    partial class AddUserForm
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
            this.AddUserPanel = new System.Windows.Forms.Panel();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.InitMaxLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.InitMaxBox = new System.Windows.Forms.NumericUpDown();
            this.AddUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InitMaxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserPanel
            // 
            this.AddUserPanel.Controls.Add(this.InitMaxBox);
            this.AddUserPanel.Controls.Add(this.InitMaxLbl);
            this.AddUserPanel.Controls.Add(this.UserNameLbl);
            this.AddUserPanel.Controls.Add(this.UserNameTextBox);
            this.AddUserPanel.Location = new System.Drawing.Point(5, 5);
            this.AddUserPanel.Name = "AddUserPanel";
            this.AddUserPanel.Size = new System.Drawing.Size(365, 75);
            this.AddUserPanel.TabIndex = 4;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(10, 15);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(29, 13);
            this.UserNameLbl.TabIndex = 7;
            this.UserNameLbl.Text = "Имя";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(155, 10);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.UserNameTextBox.TabIndex = 4;
            // 
            // AddBtn
            // 
            this.AddBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddBtn.Location = new System.Drawing.Point(50, 90);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 30);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // InitMaxLbl
            // 
            this.InitMaxLbl.AutoSize = true;
            this.InitMaxLbl.Location = new System.Drawing.Point(10, 50);
            this.InitMaxLbl.Name = "InitMaxLbl";
            this.InitMaxLbl.Size = new System.Drawing.Size(118, 13);
            this.InitMaxLbl.TabIndex = 8;
            this.InitMaxLbl.Text = "Начальный результат";
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(235, 90);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 30);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // InitMaxBox
            // 
            this.InitMaxBox.Location = new System.Drawing.Point(155, 45);
            this.InitMaxBox.Name = "InitMaxBox";
            this.InitMaxBox.Size = new System.Drawing.Size(120, 20);
            this.InitMaxBox.TabIndex = 9;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 130);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AddUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddUserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление спортсмена";
            this.AddUserPanel.ResumeLayout(false);
            this.AddUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InitMaxBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddUserPanel;
        private System.Windows.Forms.Label InitMaxLbl;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.NumericUpDown InitMaxBox;
    }
}
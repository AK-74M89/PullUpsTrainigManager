namespace PuullUpsTrainigManager.UserInterface
{
    partial class AddResultForm
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UseNowDateCheckBox = new System.Windows.Forms.CheckBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.CountLbl = new System.Windows.Forms.Label();
            this.CurrentResult = new System.Windows.Forms.NumericUpDown();
            this.ResultDate = new System.Windows.Forms.DateTimePicker();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentResult)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddBtn.Location = new System.Drawing.Point(25, 120);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 30);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UseNowDateCheckBox);
            this.panel1.Controls.Add(this.DateLbl);
            this.panel1.Controls.Add(this.CountLbl);
            this.panel1.Controls.Add(this.CurrentResult);
            this.panel1.Controls.Add(this.ResultDate);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 105);
            this.panel1.TabIndex = 4;
            // 
            // UseNowDateCheckBox
            // 
            this.UseNowDateCheckBox.AutoSize = true;
            this.UseNowDateCheckBox.Location = new System.Drawing.Point(10, 45);
            this.UseNowDateCheckBox.Name = "UseNowDateCheckBox";
            this.UseNowDateCheckBox.Size = new System.Drawing.Size(198, 17);
            this.UseNowDateCheckBox.TabIndex = 8;
            this.UseNowDateCheckBox.Text = "Использовать сегодняшнюю дату";
            this.UseNowDateCheckBox.UseVisualStyleBackColor = true;
            this.UseNowDateCheckBox.CheckedChanged += new System.EventHandler(this.UseNowDateCheckBox_CheckedChanged);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(10, 80);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(33, 13);
            this.DateLbl.TabIndex = 7;
            this.DateLbl.Text = "Дата";
            // 
            // CountLbl
            // 
            this.CountLbl.AutoSize = true;
            this.CountLbl.Location = new System.Drawing.Point(5, 10);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(66, 13);
            this.CountLbl.TabIndex = 6;
            this.CountLbl.Text = "Количество";
            // 
            // CurrentResult
            // 
            this.CurrentResult.Location = new System.Drawing.Point(115, 10);
            this.CurrentResult.Name = "CurrentResult";
            this.CurrentResult.Size = new System.Drawing.Size(200, 20);
            this.CurrentResult.TabIndex = 5;
            // 
            // ResultDate
            // 
            this.ResultDate.Location = new System.Drawing.Point(115, 75);
            this.ResultDate.Name = "ResultDate";
            this.ResultDate.Size = new System.Drawing.Size(200, 20);
            this.ResultDate.TabIndex = 4;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CancelBtn.Location = new System.Drawing.Point(210, 120);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 30);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 161);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddResultForm";
            this.ShowInTaskbar = false;
            this.Text = "Добавить результат";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label CountLbl;
        private System.Windows.Forms.NumericUpDown CurrentResult;
        private System.Windows.Forms.DateTimePicker ResultDate;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.CheckBox UseNowDateCheckBox;
    }
}
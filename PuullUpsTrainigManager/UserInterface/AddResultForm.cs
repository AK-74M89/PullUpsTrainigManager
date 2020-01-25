using PuullUpsTrainigManager.BusinessLogic;
using System;
using System.Windows.Forms;

namespace PuullUpsTrainigManager.UserInterface
{
    public partial class AddResultForm:Form
    {
        public int currentUserId;

        public AddResultForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var results = new Results();
            DateTime date_to_add;
            if (UseNowDateCheckBox.Checked)
            {
                date_to_add = DateTime.Now;
            }
            else
            {
                date_to_add = ResultDate.Value;
            }
            results.AddResult(Convert.ToInt32(CurrentResult.Value), date_to_add, currentUserId);
            this.Close();
        }

        private void UseNowDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ResultDate.Enabled = !UseNowDateCheckBox.Checked;
        }
    }
}

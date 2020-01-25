using PuullUpsTrainigManager.BusinessLogic;
using System;
using System.Windows.Forms;

namespace PuullUpsTrainigManager.UserInterface
{
    public partial class AddUserForm:Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.AddUser(this.UserNameTextBox.Text, Convert.ToInt32(this.InitMaxBox.Value));
            this.Close();
        }
    }
}

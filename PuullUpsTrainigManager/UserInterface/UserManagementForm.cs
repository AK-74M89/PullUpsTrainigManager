using PuullUpsTrainigManager.BusinessLogic;
using System;
using System.Windows.Forms;

namespace PuullUpsTrainigManager.UserInterface
{
    public partial class UserManagementForm:Form
    {
        private UsersListItem currentUser;

        public UsersListItem CurrentUser
        {
            get
            {
                return currentUser;
            }
        }

        public UserManagementForm()
        {
            InitializeComponent();            
        }                

        private void FillUsersTable()
        {
            var user = new User();
            var UsersList = user.UsersList;
            UsersDataGrid.Rows.Clear();
            for (int i = 0; i < UsersList.Count; i++)
            {
                UsersDataGrid.Rows.Add();
                UsersDataGrid.Rows[UsersDataGrid.Rows.Count - 1].Cells["ID"].Value = UsersList[i].ID;
                UsersDataGrid.Rows[UsersDataGrid.Rows.Count - 1].Cells["UserName"].Value = UsersList[i].UserName;
                UsersDataGrid.Rows[UsersDataGrid.Rows.Count - 1].Cells["CurrentMax"].Value = UsersList[i].CurrentMax;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            var AddUserDialog = new AddUserForm();
            if (AddUserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FillUsersTable();
            }
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.DeleteUser(Convert.ToInt32(UsersDataGrid.Rows[UsersDataGrid.SelectedRows[0].Index].Cells["ID"].Value));
        }

        private void SelectUserBtn_Click(object sender, EventArgs e)
        {
            if (UsersDataGrid.SelectedRows.Count == 0)
            {
                UsersDataGrid.Rows[0].Selected = true;
            }
            this.currentUser.ID = Convert.ToInt32(UsersDataGrid.Rows[UsersDataGrid.SelectedRows[0].Index].Cells["ID"].Value);
            this.currentUser.UserName = Convert.ToString(UsersDataGrid.Rows[UsersDataGrid.SelectedRows[0].Index].Cells["UserName"].Value);
            this.currentUser.CurrentMax = Convert.ToInt32(UsersDataGrid.Rows[UsersDataGrid.SelectedRows[0].Index].Cells["CurrentMax"].Value);
            this.Close();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            FillUsersTable();
        }
    }
}

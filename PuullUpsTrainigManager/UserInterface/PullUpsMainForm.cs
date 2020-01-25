using PuullUpsTrainigManager.BusinessLogic;
using PuullUpsTrainigManager.DataSource;
using PuullUpsTrainigManager.UserInterface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PuullUpsTrainigManager
{
    public partial class PullUpsMainForm:Form
    {
        public PullUpsMainForm()
        {
            InitializeComponent();
            currentUser = new UsersListItem
            {
                ID = -1,
                UserName = "",
                InitMax = -1,
                CurrentMax = -1
            };
        }

        private UsersListItem currentUser;
        private IList<ResultsListItem> currentResultsSet;

        private void ReloadResultsSet()
        {
            var results = new Results();            
            currentResultsSet = results.GetAllResults(currentUser.ID);
        }

        private void FillResultsTable()
        {            
            ResultsTable.Rows.Clear();
            for (int i = 0; i < currentResultsSet.Count; i++)
            {
                ResultsTable.Rows.Add();
                ResultsTable.Rows[ResultsTable.Rows.Count - 1].Cells["ID"].Value = currentResultsSet[i].ID;
                ResultsTable.Rows[ResultsTable.Rows.Count - 1].Cells["Date"].Value = currentResultsSet[i].Date;
                ResultsTable.Rows[ResultsTable.Rows.Count - 1].Cells["Result"].Value = currentResultsSet[i].Result;
            }
        }

        private void добавитьРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBtn_Click(sender, e);
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userManagementDialog = new UserManagementForm();
            if (userManagementDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.currentUser = userManagementDialog.CurrentUser;
                string UserName = this.currentUser.UserName;
                if (UserName.Length >= 200)
                {
                    UserName = UserName.Substring(0, 197) + "...";
                }
                this.UserNameLbl.Text = UserName;
                ReloadResultsSet();
                FillResultsTable();
                DrawPlotFromResults();
            }
        }

        private void PullUpsMainForm_Shown(object sender, EventArgs e)
        {
            пользователиToolStripMenuItem_Click(sender, e);            
        }

        private void PullUpsMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLiteConnectionManager.Disconnect();
        }

        private void PullUpsMainForm_Load(object sender, EventArgs e)
        {
            SQLiteConnectionManager.Connect("pullups.sqlite");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var AddResultDialog = new AddResultForm();
            AddResultDialog.currentUserId = this.currentUser.ID;
            if (AddResultDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ReloadResultsSet();
                FillResultsTable();
                DrawPlotFromResults();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ResultsTable.Rows.Count > 0)
            {
                if (ResultsTable.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите строку для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var results = new Results();
                    results.DeleteResult(Convert.ToInt32(ResultsTable.SelectedRows[0].Cells["ID"].Value));
                    ReloadResultsSet();
                    FillResultsTable();
                    DrawPlotFromResults();
                }
            }
        }

        private void DrawPlotFromResults()
        {
            if (currentResultsSet.Count > 0)
            {
                var plot = new Plot(this.PlotGroupBox.CreateGraphics(), currentResultsSet);
                plot.DrawPlot();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

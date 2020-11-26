using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6
{
    public partial class FormIssueSelect : Form
    {

        FakeIssueStatusRepository _FakeIssueStatusRepository = new FakeIssueStatusRepository();
        FakeIssueRepository _FakeIssueRepository = new FakeIssueRepository();

        int selectedProjectId;
        string action; // Use this to either call the modify or the remove menu.
        int targetId = 0; // Use this to specify which project is going to be modified or removed.

        public FormIssueSelect(int Id, string action)
        {
            InitializeComponent();
            selectedProjectId = Id;
            this.action = action;
        }

        private void FormIssueSelect_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            FillGrid();
        }

        private void FillGrid()
        {
            foreach (Issue issue in _FakeIssueRepository.GetAll(selectedProjectId))
            {
                dataGrid.Rows.Add(issue.Id, issue.Title, issue.DiscoveryDate, issue.Discoverer, issue.InitialDescription, issue.Component, _FakeIssueStatusRepository.GetValueById(issue.IssueStatusId));
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            targetId = Int32.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
        }

        private void buttonSelectIssue_Click(object sender, EventArgs e)
        {
            targetId = Int32.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
            if (targetId != 0)
            {
                if (action == "Modify")
                {
                    FormIssueModify form = new FormIssueModify(targetId);
                    form.ShowDialog();
                    dataGrid.Rows.Clear();
                    FillGrid();
                }
                if (action == "Remove")
                {
                    if (MessageBox.Show("Are you sure you want to remove: " + _FakeIssueRepository.GetIssueById(targetId).Title, "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _FakeIssueRepository.Remove(_FakeIssueRepository.GetIssueById(targetId));
                        dataGrid.Rows.Clear();
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("Remove cancelled.", "Attention");
                        Close();
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

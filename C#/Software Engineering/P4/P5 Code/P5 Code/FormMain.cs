using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_Code
{
    public partial class FormMain : Form
    {
        public AppUser activeUser = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterTheForm();
            this.LoginLoop();
        }

        private void CenterTheForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void LoginLoop()
        {

            using (FormLogin tmp = new FormLogin())
            {
                do
                {
                    tmp.ShowDialog(this);

                } while (tmp.DialogResult == DialogResult.OK && (!tmp.ReturnUser?.isAuthenticated ?? true));

                if(!(tmp.DialogResult == DialogResult.OK))
                {
                    this.Close();
                }
                else
                {
                    tmp.Text = "Main - No Project Selected";
                }

                activeUser = tmp.ReturnUser;
            }

        }

        private void IssueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RequirementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DesignToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CountByAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListByAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CountByArtifactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListByArtifactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CountByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrendByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

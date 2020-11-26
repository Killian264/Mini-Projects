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
    public partial class FormRemoveProject : Form
    {
        public string ProjectToRemove;
        public FormRemoveProject()
        {
            InitializeComponent();
            this.CenterTheForm();
        }
        private void FormRemoveProject_Load(object sender, EventArgs e)
        {
            ProjectToRemoveLabel.Text = "Project to remove: " + ProjectToRemove;
        }

        private void CenterTheForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ProjectToRemoveLabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RemoveProjectButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to permenantly remove this project?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            
            this.Close();
        }
    }
}

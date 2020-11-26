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
    public partial class FormModifyProject : Form
    {
        ////////////////////////////////////////////////////////////////////////////////
        // PROPERTIES

        public string ProjectsNewName { get; set; }

        ////////////////////////////////////////////////////////////////////////////////
        // INITIALIZATION

        public FormModifyProject()
        {
            InitializeComponent();
            this.CenterTheForm();
        }

        private void FormModifyProject_Load(object sender, EventArgs e)
        {
            ProjectNameTextBox.Text = ProjectsNewName;
        }

        private void CenterTheForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        ////////////////////////////////////////////////////////////////////////////////
        // BUTTONS

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.ProjectsNewName = "";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            this.ProjectsNewName = this.ProjectNameTextBox.Text;
            this.ProjectsNewName.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////
        // TEXTBOXES

        private void ProjectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

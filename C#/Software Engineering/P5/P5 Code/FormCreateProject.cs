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
    public partial class FormCreateProject : Form
    {
        ////////////////////////////////////////////////////////////////////////////////
        // PROPERTIES

        public string NewProjectsName { get; set; }

        ////////////////////////////////////////////////////////////////////////////////
        // INITIALIZATION

        public FormCreateProject()
        {
            InitializeComponent();
            this.CenterTheForm();
        }

        private void FormCreateProject_Load(object sender, EventArgs e)
        {

        }

        private void CenterTheForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        ////////////////////////////////////////////////////////////////////////////////
        // BUTTONS

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.NewProjectsName = "";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            this.NewProjectsName = ProjectNameTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////
        // TEXTBOXES

        private void ProjectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////
        // LABELS

        private void ProjectNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

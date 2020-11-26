using System;
using System.Windows.Forms;

namespace P6
{
    public partial class FormSelectProject : Form
    {
        public int _SelectedProjectId = -1;
        public string _SelectedProjectName = "";
        FakeProjectRepository _ProjectRepository = new FakeProjectRepository();

        public FormSelectProject()
        {
            InitializeComponent();
        }

        private void PreferenceSelectProject_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            foreach (Project project in _ProjectRepository.GetAll())
            {
                listBoxProjects.Items.Add(project.Id.ToString() + " - " + project.Name);
            }
            if (listBoxProjects.Items.Count > 0)
            {
                listBoxProjects.SetSelected(0, true);
            }
            else
            {
                MessageBox.Show("There are no existing projects.", "Attention");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }            
        }

        private void buttonSelectProject_Click(object sender, EventArgs e)
        {
            if (listBoxProjects.SelectedIndex < 0 )
            {
                MessageBox.Show("A project must be selected.", "Attention");
            }
            else
            {
                string selectedProject = listBoxProjects.SelectedItem.ToString();
                _SelectedProjectId = Int32.Parse(selectedProject.Substring(0, selectedProject.IndexOf(" ")));
                _SelectedProjectName = selectedProject.Substring(selectedProject.IndexOf("-") + 2);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

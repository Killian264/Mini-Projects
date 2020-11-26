using System;
using System.Windows.Forms;

namespace P6
{
    public partial class FormModifyProject : Form
    {
        AppUser _CurrentAppUser;
        int _SelectedProjectId;
        public FormModifyProject(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void ModifyProject_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("No project selected.", "Attention");
                Close();
            }
            _SelectedProjectId = form._SelectedProjectId;
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_CurrentAppUser.UserName, 
                                                                           FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            if (_SelectedProjectId.ToString() == preferredProjectId)
            {
                MessageBox.Show("Cannot modify your current session project.", "Attention");
                Close();
            }
            textBoxProjectName.Text = form._SelectedProjectName;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            // Better make sure it isn't the empty string or all blanks
            string newProjectName = textBoxProjectName.Text.Trim();
            if (newProjectName == "")
            {
                MessageBox.Show("Project name cannot be empty or blank", "Attention");
                return;
            }
            FakeProjectRepository projectRepository = new FakeProjectRepository();
            if (projectRepository.IsDupliclateName(newProjectName)) {
                MessageBox.Show("Project name already exists.", "Attention");
                return;
            }
            Project project = new Project { Id = _SelectedProjectId, Name = newProjectName};
            string result = projectRepository.Modify(_SelectedProjectId, project);
            if (result != FakeProjectRepository.NO_ERROR)
            {
                MessageBox.Show("Error modifying project. Error: " + result);
            }
            else
            {
                MessageBox.Show("Project modification successful.", "Information");
                this.Close();
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace P6
{
    public partial class FormRemoveProject : Form
    {
        AppUser _CurrentAppUser;
        int _SelectedProjectId;
        public FormRemoveProject(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void RemoveProject_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("No project selected.", "Attention");
                Close();
            }
            _SelectedProjectId = form._SelectedProjectId;
            labelProjectName.Text = form._SelectedProjectName;
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_CurrentAppUser.UserName, 
                                                                           FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            if (_SelectedProjectId.ToString() == preferredProjectId)
            {
                MessageBox.Show("Cannot remove your current session project.", "Attention");
                Close();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DialogResult isSure = MessageBox.Show("Are you sure you want to permenantly remove this project?", "Attention", MessageBoxButtons.YesNo);
            if (isSure == DialogResult.Yes)
            {
                FakeProjectRepository repository = new FakeProjectRepository();
                string result = repository.Remove(_SelectedProjectId);
                if (result == FakeProjectRepository.NO_ERROR)
                {
                    MessageBox.Show("Project removed.", "Information");
                }
                else
                {
                    MessageBox.Show(result, "Attention");
                }
                Close();
            }
        }
    }
}

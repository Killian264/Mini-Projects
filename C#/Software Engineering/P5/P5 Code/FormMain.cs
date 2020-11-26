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

        public Project currentProject = null;

        public FakePreferenceRepository preferences = new FakePreferenceRepository();

        public int Id;

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

            using (FormLogin loginForm = new FormLogin())
            {
                do
                {
                    loginForm.ShowDialog(this);

                } while (loginForm.DialogResult == DialogResult.OK && (!loginForm.ReturnUser?.isAuthenticated ?? true));

                if(!(loginForm.DialogResult == DialogResult.OK))
                {
                    this.Close();
                }

                activeUser = loginForm.ReturnUser;
            }

            if(activeUser == null)
            {
                Environment.Exit(1);
            }

            using (FormSelectProject SelectProjectForm = new FormSelectProject())
            {
                DialogResult result;
                do
                {
                    result = SelectProjectForm.ShowDialog();
                } while (result != DialogResult.OK);

                currentProject = SelectProjectForm.SelectedProject;
            }

            if (currentProject == null)
            {
                Environment.Exit(1);
            }


            preferences.SetPreference(activeUser.UserName, currentProject.Name, currentProject.Name);

            this.SetText();
        }

        private void SetText()
        {
            this.Text = $"Main - {currentProject.Name}";
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

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        { // SELECT
            DialogResult result;
            using (FormSelectProject selectProject = new FormSelectProject())
            {
                selectProject.ShowDialog(this);
                result = selectProject.DialogResult;

                if(result == DialogResult.OK)
                {
                    currentProject = selectProject.SelectedProject;
                }
            }
            if (result == DialogResult.OK)
            {
                this.SetText();
            }
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        { // CREATE

            string newProjectOut;
            DialogResult newProjectResult;

            FakeProjectRepository projects = new FakeProjectRepository();
            Project newProject = new Project();

            bool validresult = false;
            using (FormCreateProject CreateProjectForm = new FormCreateProject())
            {
                do
                {
                    CreateProjectForm.ShowDialog();
                    newProjectResult = CreateProjectForm.DialogResult;

                    if (newProjectResult == DialogResult.OK)
                    {

                        if (CreateProjectForm.NewProjectsName != "")
                        {

                            newProject.Name = CreateProjectForm.NewProjectsName;
                            newProjectOut = projects.Add(newProject, out int Id);

                            if (newProjectOut != "")
                            {
                                MessageBox.Show(newProjectOut); // shows error string from FakeProjectRepo.
                            }
                            else
                            {
                                validresult = true;
                            }
                        }
                    }
                    else if (newProjectResult == DialogResult.Cancel)
                    {
                        validresult = true;
                    }

                } while (!validresult);
            }
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        { // REMOVE
            Project ProjectToRemove = null;
            bool validresult = false;
            FakeProjectRepository projects = new FakeProjectRepository();

            using (FormSelectProject SelectProjectForm = new FormSelectProject())
            {
                do
                {
                    SelectProjectForm.ShowDialog();
                    if (SelectProjectForm.DialogResult == DialogResult.OK)
                    {
                        if (SelectProjectForm.SelectedProject == currentProject)
                        {
                            MessageBox.Show("Cannot remove your current session project.", "Attention");
                        }
                        else
                        {
                            ProjectToRemove = SelectProjectForm.SelectedProject;
                            validresult = true;
                        }
                    }
                    else if (SelectProjectForm.DialogResult == DialogResult.Cancel)
                    {
                        validresult = true;
                    }
                } while (!validresult);
            }

            if (ProjectToRemove != null)
            {
                using (FormRemoveProject RemoveProjectForm = new FormRemoveProject())
                {
                    RemoveProjectForm.ProjectToRemove = ProjectToRemove.Name;
                    RemoveProjectForm.ShowDialog(this);

                    if(RemoveProjectForm.DialogResult == DialogResult.OK)
                    {
                        projects.Remove(ProjectToRemove.Id);
                    }
                }
            }
        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        { // MODIFY
            Project ProjectToModify = null;
            bool validresult = false;
            string modifyProjectOut;
            FakeProjectRepository projects = new FakeProjectRepository();

            using (FormSelectProject SelectProjectForm = new FormSelectProject())
            {
                do
                {
                    SelectProjectForm.ShowDialog();
                    if (SelectProjectForm.DialogResult == DialogResult.OK)
                    {
                        if (SelectProjectForm.SelectedProject == currentProject)
                        {
                            MessageBox.Show("Cannot modify your current session project.", "Attention");
                        }
                        else
                        {
                            ProjectToModify = SelectProjectForm.SelectedProject;
                            validresult = true;
                        }
                    }
                    else if (SelectProjectForm.DialogResult == DialogResult.Cancel)
                    {
                        validresult = true;
                    }
                } while (!validresult);
            }

            if (ProjectToModify != null)
            {
                using (FormModifyProject ModifyProjectForm = new FormModifyProject())
                {
                    validresult = false;
                    do
                    {
                        ModifyProjectForm.ProjectsNewName = ProjectToModify.Name;
                        if (ModifyProjectForm.ShowDialog() == DialogResult.OK)
                        {
                            Project ModifiedProject = new Project
                            {
                                Name = ModifyProjectForm.ProjectsNewName,
                                Id = ProjectToModify.Id
                            };
                            modifyProjectOut = projects.Modify(ProjectToModify.Id, ModifiedProject);

                            if (modifyProjectOut != "")
                            {
                                MessageBox.Show(modifyProjectOut);
                            }
                            else
                            {
                                validresult = true;
                            }
                        }
                        else if (ModifyProjectForm.DialogResult == DialogResult.Cancel)
                        {
                            validresult = true;
                        }
                    } while (!validresult);
                }
            }
        }
    }
}

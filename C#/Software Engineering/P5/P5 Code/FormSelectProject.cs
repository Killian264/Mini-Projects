using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_Code
{
    public partial class FormSelectProject : Form
    {
        public Project SelectedProject { get; set; }

        FakeProjectRepository repo;

        public FormSelectProject()
        {
            repo = new FakeProjectRepository();
            InitializeComponent();
        }

        private void FormSelectProject_Load(object sender, EventArgs e)
        {
            this.CenterTheForm();
            this.FillProjectList();
            this.DialogResult = DialogResult.None;
        }

        private void CenterTheForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void FillProjectList()
        {
            projectListBox.Items.Clear(); 

            foreach (Project prjt in repo.GetAll())
            {
                projectListBox.Items.Add(prjt.Id + " - " + prjt.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SelectProject_Click(object sender, EventArgs e)
        {

            if (projectListBox.SelectedItem == null)
            {
                MessageBox.Show("A project must be selected.", "Attention");
            }
            else
            {
                string selected = projectListBox.SelectedItem.ToString();

                foreach (Project project in repo.GetAll())
                {
                    if (selected == (project.Id + " - " + project.Name))
                    {
                        SelectedProject = project;
                    }
                }

                if (SelectedProject == null)
                {
                    this.DialogResult = DialogResult.No;
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
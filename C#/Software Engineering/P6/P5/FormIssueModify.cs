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
    public partial class FormIssueModify : Form
    {
        FakeIssueStatusRepository _FakeIssueStatusRepository = new FakeIssueStatusRepository();
        FakeIssueRepository _FakeIssueRepository = new FakeIssueRepository();
        FakeAppUserRepository _FakeAppUserRepository = new FakeAppUserRepository();
        Issue IssueToModify;

        public FormIssueModify(int Id)
        {
            InitializeComponent();
            this.IssueToModify = _FakeIssueRepository.GetIssueById(Id);
        }

        private void FormIssueModify_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            textBoxId.Text = Convert.ToString(IssueToModify.Id);
            textBoxTitle.Text = IssueToModify.Title;
            datePickerDiscoveryDate.Value = IssueToModify.DiscoveryDate;
            foreach (AppUser user in _FakeAppUserRepository.GetAll())
            {
                dropDownDiscoverer.Items.Add(user.LastName + ", " + user.FirstName);
            }
            dropDownDiscoverer.SelectedItem = IssueToModify.Discoverer;
            textBoxComponent.Text = IssueToModify.Component;
            foreach (IssueStatus status in _FakeIssueStatusRepository.GetAll())
            {
                dropDownStatus.Items.Add(_FakeIssueStatusRepository.GetValueById(status.Id));
            }
            dropDownStatus.SelectedItem = _FakeIssueStatusRepository.GetValueById(IssueToModify.Id);
            textBoxDescription.Text = IssueToModify.InitialDescription;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Issue ModifiedIssue = new Issue();
            ModifiedIssue.Title = textBoxTitle.Text;
            ModifiedIssue.DiscoveryDate = datePickerDiscoveryDate.Value;
            ModifiedIssue.Discoverer = dropDownDiscoverer.Text;
            ModifiedIssue.Component = textBoxComponent.Text;
            ModifiedIssue.IssueStatusId = _FakeIssueStatusRepository.GetIdByStatus(dropDownStatus.SelectedItem.ToString());
            ModifiedIssue.InitialDescription = textBoxDescription.Text;

            string validationresult = _FakeIssueRepository.ValidateIssue(ModifiedIssue);

            if (ModifiedIssue.Component == "")
            {
                validationresult = "A component is required";
            }
            if (ModifiedIssue.IssueStatusId == 0)
            {
                validationresult = "An issue status is required";
            }
            if (ModifiedIssue.InitialDescription == "")
            {
                validationresult = "A description is required";
            }

            if (validationresult == "")
            {
                MessageBox.Show("Issue successfully modified", "Modification Successful", MessageBoxButtons.OK);
                IssueToModify.Title = ModifiedIssue.Title;
                IssueToModify.DiscoveryDate = ModifiedIssue.DiscoveryDate;
                IssueToModify.Discoverer = ModifiedIssue.Discoverer;
                IssueToModify.Component = ModifiedIssue.Component;
                IssueToModify.IssueStatusId = ModifiedIssue.IssueStatusId;
                IssueToModify.InitialDescription = ModifiedIssue.InitialDescription;
                Close();
            }
            else
            {
                MessageBox.Show(validationresult, "Modification Unsuccessful", MessageBoxButtons.OK);
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void datePickerDiscoveryDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dropDownDiscoverer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxComponent_TextChanged(object sender, EventArgs e)
        {

        }

        private void dropDownStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

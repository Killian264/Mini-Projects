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
    public partial class FormIssueRecord : Form
    {
        FakeIssueStatusRepository _FakeIssueStatusRepository = new FakeIssueStatusRepository();
        FakeIssueRepository _FakeIssueRepository = new FakeIssueRepository();
        FakeAppUserRepository _FakeAppUserRepository = new FakeAppUserRepository();

        int selectedProjectId;

        public FormIssueRecord(int selectedProjectId)
        {
            InitializeComponent();
            this.selectedProjectId = selectedProjectId;
        }
        private void FormIssueRecord_Load(object sender, EventArgs e)
        {
            //gen id
            int newId = 0;
            foreach (Issue ish in _FakeIssueRepository.GetAll(0))
            {
                if (ish.Id > newId)
                {
                    newId = ish.Id;
                }
            }
            newId++;
            textBoxId.Text = newId.ToString();

            //fill Discoverers
            foreach(AppUser user in _FakeAppUserRepository.GetAll())
            {
                dropDownDiscoverer.Items.Add(user.LastName + ", " + user.FirstName);
            }

            //fill IssueStatuses
            foreach (IssueStatus ishStat in _FakeIssueStatusRepository.GetAll())
            {
                dropDownStatus.Items.Add(ishStat.Value);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Issue newIssue = new Issue
            {
                Id = Int32.Parse(textBoxId.Text),
                ProjectId = selectedProjectId,
                Title = textBoxTitle.Text,
                DiscoveryDate = datePickerDiscoveryDate.Value,
                Discoverer = dropDownDiscoverer.Text,
                Component = textBoxComponent.Text,
                IssueStatusId = _FakeIssueStatusRepository.GetIdByStatus(dropDownStatus.Text),
                InitialDescription = textBoxDescription.Text
            };

            string result = _FakeIssueRepository.Add(newIssue);
            if (result != "")
            {
                MessageBox.Show(result, "Attention");
            }
            else
            {
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

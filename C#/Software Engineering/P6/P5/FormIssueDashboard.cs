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
    public partial class FormIssueDashboard : Form
    {
        FakeIssueRepository _fakeIssueRepository;
        int selectedProjectId;

        public FormIssueDashboard(FakeIssueRepository fakeIssueRepository, int selectedProjectId)
        {
            InitializeComponent();
            _fakeIssueRepository = fakeIssueRepository;
            this.selectedProjectId = selectedProjectId;
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e)
        {
            this.labelIssueCount.Text = _fakeIssueRepository.GetTotalNumberOfIssues(selectedProjectId).ToString();

            List<string> byMonth = _fakeIssueRepository.GetIssuesByMonth(selectedProjectId);
            foreach(string entry in byMonth)
            {
                this.listBoxIssuesByMonth.Items.Add(entry);
            }

            List<string> byDiscoverer = _fakeIssueRepository.GetIssuesByDiscoverer(selectedProjectId);
            foreach (string entry in byDiscoverer)
            {
                this.listBoxIssuesByDiscoverer.Items.Add(entry);
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

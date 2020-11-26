using System;
using System.Windows.Forms;

namespace P6
{
    public partial class FormFeatureCreate : Form
    {

        FakeFeatureRepository _FakeFeatureRepository = new FakeFeatureRepository();
        int activeProjectId;

        public FormFeatureCreate(int ProjectId)
        {
            InitializeComponent();
            this.activeProjectId = ProjectId;
        }
        private void FormFeatureCreate_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_CreateFeature_Click(object sender, EventArgs e)
        {
            Feature tmp = new Feature
            {
                Id = _FakeFeatureRepository.GetNextId(),
                ProjectId = activeProjectId,
                Title = titleTextBox.Text.Trim()
            };

            if (validateAndCreateFeature(tmp))
            {
                this.Close();
            }
        }
        private bool validateAndCreateFeature(Feature feature)
        {
            string result = _FakeFeatureRepository.Add(feature);
            if (result != "")
            {
                MessageBox.Show(result, "Attention.");
                return false;
            }
            else
            {
                MessageBox.Show("Feature added successfully.", "Attention.");
                return true;
            }
        }
    }
}

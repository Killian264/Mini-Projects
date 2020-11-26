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
    public partial class FormRequirementSelect : Form
    {
        int selectedProjectId, selectedFeatureId = -1;

        public FormRequirementSelect(int selectedProjectId)
        {
            InitializeComponent();
            CenterToScreen();

            this.selectedProjectId = selectedProjectId;

            FakeFeatureRepository fakeFeature = new FakeFeatureRepository();
            List<Feature> featureList = fakeFeature.GetAll(this.selectedProjectId);

            foreach (Feature feat in featureList)
                featureSelectComboBox.Items.Add(feat.Title);
        }

        private void featureSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FakeFeatureRepository fakeFeature = new FakeFeatureRepository();

            Feature selectedFeature = fakeFeature.GetFeatureByTitle(featureSelectComboBox.SelectedItem.ToString());
            this.selectedFeatureId = selectedFeature.Id;

            requirementDataGridView1.Rows.Clear();

            FakeRequirementRepository fakereq = new FakeRequirementRepository();
            List<Requirement> requirementList = fakereq.GetAll(this.selectedProjectId);

            foreach (Requirement req in requirementList)
                if (req.FeatureId == this.selectedFeatureId)
                    requirementDataGridView1.Rows.Add(req.Id, req.Statement);
        }

        private void requirementDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectRequirementButton_Click(object sender, EventArgs e)
        {
            if (this.selectedFeatureId != -1)
            {
                if (requirementDataGridView1.SelectedCells.Count == 1 || requirementDataGridView1.SelectedRows.Count == 1)
                {
                    int requirementId = Int32.Parse(requirementDataGridView1.CurrentRow.Cells[0].Value.ToString());

                    FakeRequirementRepository fakeRequirement = new FakeRequirementRepository();
                    Requirement req = fakeRequirement.GetRequirementById(requirementId);
                    FormRequirementCreate RequirementForm = new FormRequirementCreate(this.selectedProjectId, FormRequirementCreate.ActionTypes.Modify, req);
                    RequirementForm.ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show("A requirement must be chosen", "Attention");
            }
            else
                MessageBox.Show("A feature must be chosen", "Attention");
        }
    }
}

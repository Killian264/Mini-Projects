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
    public partial class FormFeatureSelect : Form
    {
        FakeFeatureRepository _FakeFeatureRepository = new FakeFeatureRepository();
        private int selectedProjectId;
        private string action; // Use this to either call the modify or the remove menu.
        private int targetId = 0; // Use this to specify which project is going to be modified or removed.

        public FormFeatureSelect(int Id, string act)
        {
            InitializeComponent();
            this.selectedProjectId = Id;
            this.action = act;
        }

        private void FormFeatureSelect_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            FillGrid();
        }
        private void FillGrid()
        {
            foreach (Feature feat in _FakeFeatureRepository.GetAll(this.selectedProjectId))
            {
                dataGrid.Rows.Add(feat.Id, feat.Title);
            }
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            targetId = Int32.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelectIssue_Click(object sender, EventArgs e)
        {
            targetId = Int32.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
            if (targetId != 0)
            {
                if (action == "Modify")
                {
                    FormFeatureModify form = new FormFeatureModify(targetId);
                    form.ShowDialog();
                    dataGrid.Rows.Clear();
                    FillGrid();
                }
                if (action == "Remove")
                {
                    if (MessageBox.Show("Are you sure you want to remove: " + _FakeFeatureRepository.GetFeatureById(targetId).Title, "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FakeRequirementRepository _FakeRequirementRepository = new FakeRequirementRepository();
                        if(_FakeRequirementRepository.CountByFeatureId(targetId) > 0)
                        {
                            if (MessageBox.Show("There are one or more requirements associated with this feature" +
                                "These requirements will be destroyed if you remove this feature." +
                                "Are you sure you want to remove: " + _FakeFeatureRepository.GetFeatureById(targetId).Title, "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                _FakeFeatureRepository.Remove(_FakeFeatureRepository.GetFeatureById(targetId));
                                dataGrid.Rows.Clear();
                                FillGrid();
                            }
                            else
                            {
                                MessageBox.Show("Remove cancelled.", "Attention");
                                Close();
                            }
                        }
                        else
                        {
                            _FakeFeatureRepository.Remove(_FakeFeatureRepository.GetFeatureById(targetId));
                            dataGrid.Rows.Clear();
                            FillGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Remove cancelled.", "Attention");
                        Close();
                    }
                }
            }
        }
    }
}

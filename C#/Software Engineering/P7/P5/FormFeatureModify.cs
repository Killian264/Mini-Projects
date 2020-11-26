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
    public partial class FormFeatureModify : Form
    {


        FakeFeatureRepository _FakeFeatureRepository = new FakeFeatureRepository();
        Feature featureToModify = new Feature();

        public FormFeatureModify(int featureId)
        {
            InitializeComponent();
            this.featureToModify.Id = _FakeFeatureRepository.GetFeatureById(featureId).Id;
            this.featureToModify.ProjectId = _FakeFeatureRepository.GetFeatureById(featureId).ProjectId;
        }
        private void FormFeatureModify_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            titleTextBox.Text = _FakeFeatureRepository.GetFeatureById(featureToModify.Id).Title;
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_ModifyFeature_Click(object sender, EventArgs e)
        {
            featureToModify.Title = titleTextBox.Text.Trim();
            if(featureToModify.Title == "")
            {
                MessageBox.Show("Title must have a value", "Attention");
                return;
            }
            else
            {
                string result = _FakeFeatureRepository.Modify(featureToModify);
                if (result != "")
                {
                    MessageBox.Show(result, "Attention");
                    return;
                }
                else
                {
                    MessageBox.Show("Feature modified successfully.", "Attention.");
                    Close();
                }
            }
        }
    }
}

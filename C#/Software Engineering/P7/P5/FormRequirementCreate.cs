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
    public partial class FormRequirementCreate : Form
    {
        private FakeFeatureRepository _FakeFeatureRepository = new FakeFeatureRepository();
        private FakeRequirementRepository _FakeRequirementRepository = new FakeRequirementRepository();
        int activeProjectId;


        public enum ActionTypes
        {
            Modify,
            Create,
        }

        ActionTypes action;

        Requirement modifyRequirement = null;

        public FormRequirementCreate(int ProjectId, ActionTypes action, Requirement requirement = null)
        {
            InitializeComponent();
            this.activeProjectId = ProjectId;

            this.action = action;

            if(requirement != null)
            {
                this.modifyRequirement = requirement;
            }
        }

        public void fillDropDown()
        {
            List<Feature> features = _FakeFeatureRepository.GetAll(this.activeProjectId);
            foreach (Feature feature in features)
            {
                dropDownFeatures.Items.Add(feature.Title);
            }

            if (action == ActionTypes.Modify)
            {
                Feature requirementFeature = _FakeFeatureRepository.GetFeatureById(modifyRequirement.FeatureId);
                this.dropDownFeatures.SelectedIndex = dropDownFeatures.Items.IndexOf(requirementFeature.Title);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Statement cannot be blank
            if(textBoxStatement.Text == "")
            {
                MessageBox.Show("Statement must have a value.", "Attention.");
                return;
            }

            String textBoxText = this.textBoxStatement.Text;
            Feature createdFromFeature = this._FakeFeatureRepository.GetFeatureByTitle(this.dropDownFeatures.Text);
            int createdFromFeatureId = createdFromFeature.Id;

            string errorString = "";

            if (action == ActionTypes.Create)
            {
                Requirement newRequirement = new Requirement
                {
                    Statement = this.textBoxStatement.Text,
                    FeatureId = createdFromFeatureId,
                    ProjectId = this.activeProjectId
                };
                errorString = this._FakeRequirementRepository.Add(newRequirement);
            }

            if (action == ActionTypes.Modify)
            {
                modifyRequirement.Statement = this.textBoxStatement.Text;
                modifyRequirement.FeatureId = createdFromFeatureId;

                errorString = this._FakeRequirementRepository.Modify(modifyRequirement);
            }

            if (errorString == FakeRequirementRepository.NO_ERROR)
            {
                this.Close();
                return;
            }


            MessageBox.Show(errorString, "Attention.");
            return;

        }

        private void FormRequirementCreate_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.buttonSubmit.Enabled = false;
            fillDropDown();
            this.textBoxStatement.Enabled = dropDownFeatures.Text != "<Make Selection>";

            this.buttonSubmit.Text = (action == ActionTypes.Create ? ActionTypes.Create.ToString() : ActionTypes.Modify.ToString()) + " Requirement";

            if(action == ActionTypes.Modify)
            {
                this.textBoxStatement.Text = this.modifyRequirement.Statement;
            }
        }

        private void dropDownFeatures_TextChanged(object sender, EventArgs e)
        {
            bool textBoxItemSelected = dropDownFeatures.Text != "<Make Selection>";
            this.textBoxStatement.Enabled = textBoxItemSelected;
            this.buttonSubmit.Enabled = textBoxItemSelected;

        }
    }
}

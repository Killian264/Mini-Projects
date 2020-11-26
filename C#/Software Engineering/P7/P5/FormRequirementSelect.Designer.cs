namespace P6
{
    partial class FormRequirementSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.requirementDataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featureLabel = new System.Windows.Forms.Label();
            this.requirementsLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.selectRequirementButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.featureSelectComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.requirementDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // requirementDataGridView1
            // 
            this.requirementDataGridView1.AllowUserToAddRows = false;
            this.requirementDataGridView1.AllowUserToDeleteRows = false;
            this.requirementDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requirementDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requirementDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.requirementColumn});
            this.requirementDataGridView1.Location = new System.Drawing.Point(93, 59);
            this.requirementDataGridView1.Name = "requirementDataGridView1";
            this.requirementDataGridView1.ReadOnly = true;
            this.requirementDataGridView1.Size = new System.Drawing.Size(556, 285);
            this.requirementDataGridView1.TabIndex = 0;
            this.requirementDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requirementDataGridView1_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // requirementColumn
            // 
            this.requirementColumn.FillWeight = 1000F;
            this.requirementColumn.HeaderText = "Requirement";
            this.requirementColumn.Name = "requirementColumn";
            this.requirementColumn.ReadOnly = true;
            // 
            // featureLabel
            // 
            this.featureLabel.AutoSize = true;
            this.featureLabel.Location = new System.Drawing.Point(41, 28);
            this.featureLabel.Name = "featureLabel";
            this.featureLabel.Size = new System.Drawing.Size(46, 13);
            this.featureLabel.TabIndex = 1;
            this.featureLabel.Text = "Feature:";
            // 
            // requirementsLabel
            // 
            this.requirementsLabel.AutoSize = true;
            this.requirementsLabel.Location = new System.Drawing.Point(12, 59);
            this.requirementsLabel.Name = "requirementsLabel";
            this.requirementsLabel.Size = new System.Drawing.Size(75, 13);
            this.requirementsLabel.TabIndex = 2;
            this.requirementsLabel.Text = "Requirements:";
            // 
            // selectRequirementButton
            // 
            this.selectRequirementButton.Location = new System.Drawing.Point(507, 368);
            this.selectRequirementButton.Name = "selectRequirementButton";
            this.selectRequirementButton.Size = new System.Drawing.Size(142, 23);
            this.selectRequirementButton.TabIndex = 3;
            this.selectRequirementButton.Text = "Select Requirement";
            this.selectRequirementButton.UseVisualStyleBackColor = true;
            this.selectRequirementButton.Click += new System.EventHandler(this.selectRequirementButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(339, 368);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // featureSelectComboBox
            // 
            this.featureSelectComboBox.FormattingEnabled = true;
            this.featureSelectComboBox.Location = new System.Drawing.Point(93, 25);
            this.featureSelectComboBox.Name = "featureSelectComboBox";
            this.featureSelectComboBox.Size = new System.Drawing.Size(556, 21);
            this.featureSelectComboBox.TabIndex = 5;
            this.featureSelectComboBox.Text = "<Make Selection>";
            this.featureSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.featureSelectComboBox_SelectedIndexChanged);
            // 
            // FormRequirementSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 419);
            this.Controls.Add(this.featureSelectComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectRequirementButton);
            this.Controls.Add(this.requirementsLabel);
            this.Controls.Add(this.featureLabel);
            this.Controls.Add(this.requirementDataGridView1);
            this.Name = "FormRequirementSelect";
            this.Text = "Select Requirement";
            ((System.ComponentModel.ISupportInitialize)(this.requirementDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView requirementDataGridView1;
        private System.Windows.Forms.Label featureLabel;
        private System.Windows.Forms.Label requirementsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requirementColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button selectRequirementButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox featureSelectComboBox;
    }
}
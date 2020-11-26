namespace P6
{
    partial class FormSelectRequirement
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelectRequirement = new System.Windows.Forms.Button();
            this.dropDownFeatures = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Requirement});
            this.dataGrid.Location = new System.Drawing.Point(152, 110);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.Size = new System.Drawing.Size(1169, 553);
            this.dataGrid.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Requirement
            // 
            this.Requirement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Requirement.HeaderText = "Feature";
            this.Requirement.MinimumWidth = 8;
            this.Requirement.Name = "Requirement";
            this.Requirement.ReadOnly = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(705, 697);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(267, 29);
            this.buttonCancel.TabIndex = 40;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSelectRequirement
            // 
            this.buttonSelectRequirement.Location = new System.Drawing.Point(1054, 697);
            this.buttonSelectRequirement.Name = "buttonSelectRequirement";
            this.buttonSelectRequirement.Size = new System.Drawing.Size(267, 29);
            this.buttonSelectRequirement.TabIndex = 39;
            this.buttonSelectRequirement.Text = "Select Requirement";
            this.buttonSelectRequirement.UseVisualStyleBackColor = true;
            // 
            // dropDownFeatures
            // 
            this.dropDownFeatures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownFeatures.FormattingEnabled = true;
            this.dropDownFeatures.Location = new System.Drawing.Point(152, 52);
            this.dropDownFeatures.Name = "dropDownFeatures";
            this.dropDownFeatures.Size = new System.Drawing.Size(739, 28);
            this.dropDownFeatures.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Features:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Requirements:";
            // 
            // FormSelectRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 768);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectRequirement);
            this.Controls.Add(this.dropDownFeatures);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid);
            this.Name = "FormSelectRequirement";
            this.Text = "FormSelectRequirement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requirement;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSelectRequirement;
        public System.Windows.Forms.ComboBox dropDownFeatures;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}
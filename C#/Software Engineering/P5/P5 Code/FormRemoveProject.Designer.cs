namespace P5_Code
{
    partial class FormRemoveProject
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
            this.ProjectToRemoveLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RemoveProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectToRemoveLabel
            // 
            this.ProjectToRemoveLabel.AutoSize = true;
            this.ProjectToRemoveLabel.Location = new System.Drawing.Point(26, 53);
            this.ProjectToRemoveLabel.Name = "ProjectToRemoveLabel";
            this.ProjectToRemoveLabel.Size = new System.Drawing.Size(93, 13);
            this.ProjectToRemoveLabel.TabIndex = 0;
            this.ProjectToRemoveLabel.Text = "Project to remove:";
            this.ProjectToRemoveLabel.Click += new System.EventHandler(this.ProjectToRemoveLabel_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(87, 97);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RemoveProjectButton
            // 
            this.RemoveProjectButton.Location = new System.Drawing.Point(204, 97);
            this.RemoveProjectButton.Name = "RemoveProjectButton";
            this.RemoveProjectButton.Size = new System.Drawing.Size(111, 23);
            this.RemoveProjectButton.TabIndex = 2;
            this.RemoveProjectButton.Text = "Remove Project";
            this.RemoveProjectButton.UseVisualStyleBackColor = true;
            this.RemoveProjectButton.Click += new System.EventHandler(this.RemoveProjectButton_Click);
            // 
            // FormRemoveProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 147);
            this.Controls.Add(this.RemoveProjectButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProjectToRemoveLabel);
            this.Name = "FormRemoveProject";
            this.Text = "Remove Project";
            this.Load += new System.EventHandler(this.FormRemoveProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectToRemoveLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RemoveProjectButton;
    }
}
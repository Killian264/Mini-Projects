namespace P6
{
    partial class FormFeatureModify
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
            this.button_ModifyFeature = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ModifyFeature
            // 
            this.button_ModifyFeature.Location = new System.Drawing.Point(241, 51);
            this.button_ModifyFeature.Name = "button_ModifyFeature";
            this.button_ModifyFeature.Size = new System.Drawing.Size(94, 23);
            this.button_ModifyFeature.TabIndex = 7;
            this.button_ModifyFeature.Text = "Modify Feature";
            this.button_ModifyFeature.UseVisualStyleBackColor = true;
            this.button_ModifyFeature.Click += new System.EventHandler(this.button_ModifyFeature_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(145, 51);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(53, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(282, 20);
            this.titleTextBox.TabIndex = 5;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(16, 14);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title:";
            // 
            // FormFeatureModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 84);
            this.Controls.Add(this.button_ModifyFeature);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "FormFeatureModify";
            this.Text = "FormFeatureModify";
            this.Load += new System.EventHandler(this.FormFeatureModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ModifyFeature;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}
namespace P6
{
    partial class FormFeatureCreate
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_CreateFeature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(14, 14);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(51, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(282, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(143, 51);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_CreateFeature
            // 
            this.button_CreateFeature.Location = new System.Drawing.Point(239, 51);
            this.button_CreateFeature.Name = "button_CreateFeature";
            this.button_CreateFeature.Size = new System.Drawing.Size(94, 23);
            this.button_CreateFeature.TabIndex = 3;
            this.button_CreateFeature.Text = "Create Feature";
            this.button_CreateFeature.UseVisualStyleBackColor = true;
            this.button_CreateFeature.Click += new System.EventHandler(this.button_CreateFeature_Click);
            // 
            // FormFeatureCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 90);
            this.Controls.Add(this.button_CreateFeature);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "FormFeatureCreate";
            this.Text = "Create Feature";
            this.Load += new System.EventHandler(this.FormFeatureCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_CreateFeature;
    }
}
namespace CSC470_P2
{
    partial class OutcomeForm
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
            this.OkayButton = new System.Windows.Forms.Button();
            this.OutcomeTextbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(74, 82);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(75, 23);
            this.OkayButton.TabIndex = 1;
            this.OkayButton.Text = "OK";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OKButton);
            // 
            // OutcomeTextbox
            // 
            this.OutcomeTextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutcomeTextbox.Location = new System.Drawing.Point(0, 0);
            this.OutcomeTextbox.Name = "OutcomeTextbox";
            this.OutcomeTextbox.Size = new System.Drawing.Size(220, 79);
            this.OutcomeTextbox.TabIndex = 2;
            this.OutcomeTextbox.Text = "Outcome Message";
            this.OutcomeTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(220, 135);
            this.Controls.Add(this.OutcomeTextbox);
            this.Controls.Add(this.OkayButton);
            this.Name = "OutcomeForm";
            this.Text = "Decision";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Label OutcomeTextbox;
    }
}
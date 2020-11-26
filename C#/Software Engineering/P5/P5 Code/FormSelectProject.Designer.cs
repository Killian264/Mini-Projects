namespace P5_Code
{
    partial class FormSelectProject
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
            this.projectListBox = new System.Windows.Forms.ListBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SelectProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectListBox
            // 
            this.projectListBox.FormattingEnabled = true;
            this.projectListBox.ItemHeight = 20;
            this.projectListBox.Location = new System.Drawing.Point(40, 57);
            this.projectListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectListBox.Name = "projectListBox";
            this.projectListBox.Size = new System.Drawing.Size(694, 364);
            this.projectListBox.TabIndex = 0;
            this.projectListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(274, 478);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(189, 49);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SelectProject
            // 
            this.SelectProject.Location = new System.Drawing.Point(534, 478);
            this.SelectProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectProject.Name = "SelectProject";
            this.SelectProject.Size = new System.Drawing.Size(189, 49);
            this.SelectProject.TabIndex = 2;
            this.SelectProject.Text = "Select Project";
            this.SelectProject.UseVisualStyleBackColor = true;
            this.SelectProject.Click += new System.EventHandler(this.SelectProject_Click);
            // 
            // FormSelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 577);
            this.Controls.Add(this.SelectProject);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.projectListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSelectProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Project";
            this.Load += new System.EventHandler(this.FormSelectProject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox projectListBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SelectProject;
    }
}
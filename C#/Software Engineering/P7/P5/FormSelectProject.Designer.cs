namespace P6
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
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.buttonSelectProject = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 20;
            this.listBoxProjects.Location = new System.Drawing.Point(37, 42);
            this.listBoxProjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(600, 304);
            this.listBoxProjects.TabIndex = 0;
            this.listBoxProjects.DoubleClick += new System.EventHandler(this.buttonSelectProject_Click);
            // 
            // buttonSelectProject
            // 
            this.buttonSelectProject.Location = new System.Drawing.Point(457, 396);
            this.buttonSelectProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectProject.Name = "buttonSelectProject";
            this.buttonSelectProject.Size = new System.Drawing.Size(180, 46);
            this.buttonSelectProject.TabIndex = 1;
            this.buttonSelectProject.Text = "Select Project";
            this.buttonSelectProject.UseVisualStyleBackColor = true;
            this.buttonSelectProject.Click += new System.EventHandler(this.buttonSelectProject_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(212, 396);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(180, 46);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSelectProject
            // 
            this.AcceptButton = this.buttonSelectProject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(682, 479);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectProject);
            this.Controls.Add(this.listBoxProjects);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSelectProject";
            this.Text = "Select Project";
            this.Load += new System.EventHandler(this.PreferenceSelectProject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.Button buttonSelectProject;
        private System.Windows.Forms.Button buttonCancel;
    }
}
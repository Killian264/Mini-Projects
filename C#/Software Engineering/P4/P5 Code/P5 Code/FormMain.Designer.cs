namespace P5_Code
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrendByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RequirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreferencesToolStripMenuItem,
            this.IssueToolStripMenuItem,
            this.RequirementToolStripMenuItem,
            this.DesignToolStripMenuItem,
            this.TestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PreferencesToolStripMenuItem
            // 
            this.PreferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectProjectToolStripMenuItem,
            this.createProjectToolStripMenuItem,
            this.modifyProjectToolStripMenuItem,
            this.removeProjectToolStripMenuItem});
            this.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem";
            this.PreferencesToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.PreferencesToolStripMenuItem.Text = "Preferences";
            this.PreferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItem_Click);
            // 
            // IssueToolStripMenuItem
            // 
            this.IssueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DashboardToolStripMenuItem,
            this.RecordToolStripMenuItem,
            this.ModifyToolStripMenuItem,
            this.RemoveToolStripMenuItem,
            this.ReportToolStripMenuItem});
            this.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem";
            this.IssueToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.IssueToolStripMenuItem.Text = "Issue";
            this.IssueToolStripMenuItem.Click += new System.EventHandler(this.IssueToolStripMenuItem_Click);
            // 
            // DashboardToolStripMenuItem
            // 
            this.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem";
            this.DashboardToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.DashboardToolStripMenuItem.Text = "Dashboard";
            this.DashboardToolStripMenuItem.Click += new System.EventHandler(this.DashboardToolStripMenuItem_Click);
            // 
            // RecordToolStripMenuItem
            // 
            this.RecordToolStripMenuItem.Name = "RecordToolStripMenuItem";
            this.RecordToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.RecordToolStripMenuItem.Text = "Record";
            this.RecordToolStripMenuItem.Click += new System.EventHandler(this.RecordToolStripMenuItem_Click);
            // 
            // ModifyToolStripMenuItem
            // 
            this.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem";
            this.ModifyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ModifyToolStripMenuItem.Text = "Modify";
            this.ModifyToolStripMenuItem.Click += new System.EventHandler(this.ModifyToolStripMenuItem_Click);
            // 
            // RemoveToolStripMenuItem
            // 
            this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
            this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.RemoveToolStripMenuItem.Text = "Remove";
            this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // ReportToolStripMenuItem
            // 
            this.ReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountByAssigneeToolStripMenuItem,
            this.ListByAssigneeToolStripMenuItem,
            this.CountByArtifactToolStripMenuItem,
            this.ListByArtifactToolStripMenuItem,
            this.CountByDateRangeToolStripMenuItem,
            this.ListByDateRangeToolStripMenuItem,
            this.TrendByDateRangeToolStripMenuItem});
            this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
            this.ReportToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ReportToolStripMenuItem.Text = "Report";
            this.ReportToolStripMenuItem.Click += new System.EventHandler(this.ReportToolStripMenuItem_Click);
            // 
            // CountByAssigneeToolStripMenuItem
            // 
            this.CountByAssigneeToolStripMenuItem.Name = "CountByAssigneeToolStripMenuItem";
            this.CountByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.CountByAssigneeToolStripMenuItem.Text = "Count by Assignee";
            this.CountByAssigneeToolStripMenuItem.Click += new System.EventHandler(this.CountByAssigneeToolStripMenuItem_Click);
            // 
            // ListByAssigneeToolStripMenuItem
            // 
            this.ListByAssigneeToolStripMenuItem.Name = "ListByAssigneeToolStripMenuItem";
            this.ListByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.ListByAssigneeToolStripMenuItem.Text = "List by Assignee";
            this.ListByAssigneeToolStripMenuItem.Click += new System.EventHandler(this.ListByAssigneeToolStripMenuItem_Click);
            // 
            // CountByArtifactToolStripMenuItem
            // 
            this.CountByArtifactToolStripMenuItem.Name = "CountByArtifactToolStripMenuItem";
            this.CountByArtifactToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.CountByArtifactToolStripMenuItem.Text = "Count by Artifact";
            this.CountByArtifactToolStripMenuItem.Click += new System.EventHandler(this.CountByArtifactToolStripMenuItem_Click);
            // 
            // ListByArtifactToolStripMenuItem
            // 
            this.ListByArtifactToolStripMenuItem.Name = "ListByArtifactToolStripMenuItem";
            this.ListByArtifactToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.ListByArtifactToolStripMenuItem.Text = "List by Artifact";
            this.ListByArtifactToolStripMenuItem.Click += new System.EventHandler(this.ListByArtifactToolStripMenuItem_Click);
            // 
            // CountByDateRangeToolStripMenuItem
            // 
            this.CountByDateRangeToolStripMenuItem.Name = "CountByDateRangeToolStripMenuItem";
            this.CountByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.CountByDateRangeToolStripMenuItem.Text = "Count by Date Range";
            this.CountByDateRangeToolStripMenuItem.Click += new System.EventHandler(this.CountByDateRangeToolStripMenuItem_Click);
            // 
            // ListByDateRangeToolStripMenuItem
            // 
            this.ListByDateRangeToolStripMenuItem.Name = "ListByDateRangeToolStripMenuItem";
            this.ListByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.ListByDateRangeToolStripMenuItem.Text = "List by Date Range";
            this.ListByDateRangeToolStripMenuItem.Click += new System.EventHandler(this.ListByDateRangeToolStripMenuItem_Click);
            // 
            // TrendByDateRangeToolStripMenuItem
            // 
            this.TrendByDateRangeToolStripMenuItem.Name = "TrendByDateRangeToolStripMenuItem";
            this.TrendByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.TrendByDateRangeToolStripMenuItem.Text = "Trend by Date Range";
            this.TrendByDateRangeToolStripMenuItem.Click += new System.EventHandler(this.TrendByDateRangeToolStripMenuItem_Click);
            // 
            // RequirementToolStripMenuItem
            // 
            this.RequirementToolStripMenuItem.Name = "RequirementToolStripMenuItem";
            this.RequirementToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.RequirementToolStripMenuItem.Text = "Requirement";
            this.RequirementToolStripMenuItem.Click += new System.EventHandler(this.RequirementToolStripMenuItem_Click);
            // 
            // DesignToolStripMenuItem
            // 
            this.DesignToolStripMenuItem.Name = "DesignToolStripMenuItem";
            this.DesignToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.DesignToolStripMenuItem.Text = "Design";
            this.DesignToolStripMenuItem.Click += new System.EventHandler(this.DesignToolStripMenuItem_Click);
            // 
            // TestToolStripMenuItem
            // 
            this.TestToolStripMenuItem.Name = "TestToolStripMenuItem";
            this.TestToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.TestToolStripMenuItem.Text = "Test";
            this.TestToolStripMenuItem.Click += new System.EventHandler(this.TestToolStripMenuItem_Click);
            // 
            // selectProjectToolStripMenuItem
            // 
            this.selectProjectToolStripMenuItem.Name = "selectProjectToolStripMenuItem";
            this.selectProjectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.selectProjectToolStripMenuItem.Text = "Select Project";
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            // 
            // modifyProjectToolStripMenuItem
            // 
            this.modifyProjectToolStripMenuItem.Name = "modifyProjectToolStripMenuItem";
            this.modifyProjectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modifyProjectToolStripMenuItem.Text = "Modify Project";
            // 
            // removeProjectToolStripMenuItem
            // 
            this.removeProjectToolStripMenuItem.Name = "removeProjectToolStripMenuItem";
            this.removeProjectToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.removeProjectToolStripMenuItem.Text = "Remove Project";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RequirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DesignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CountByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CountByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CountByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrendByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProjectToolStripMenuItem;
    }
}


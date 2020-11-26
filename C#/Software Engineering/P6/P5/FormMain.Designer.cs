namespace P6
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesSelectProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesCreateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesModifyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesRemoveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesReportCountByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesReportListByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesReportCountByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesReportListByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesReportCountByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesReportListByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesReportTrendByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.issuesToolStripMenuItem,
            this.requirementsToolStripMenuItem,
            this.designToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1257, 33);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesSelectProjectToolStripMenuItem,
            this.preferencesCreateProjectToolStripMenuItem,
            this.preferencesModifyProjectToolStripMenuItem,
            this.preferencesRemoveProjectToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            // 
            // preferencesSelectProjectToolStripMenuItem
            // 
            this.preferencesSelectProjectToolStripMenuItem.Name = "preferencesSelectProjectToolStripMenuItem";
            this.preferencesSelectProjectToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.preferencesSelectProjectToolStripMenuItem.Text = "&Select Project";
            this.preferencesSelectProjectToolStripMenuItem.Click += new System.EventHandler(this.preferencesSelectProjectToolStripMenuItem_Click);
            // 
            // preferencesCreateProjectToolStripMenuItem
            // 
            this.preferencesCreateProjectToolStripMenuItem.Name = "preferencesCreateProjectToolStripMenuItem";
            this.preferencesCreateProjectToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.preferencesCreateProjectToolStripMenuItem.Text = "&Create Project";
            this.preferencesCreateProjectToolStripMenuItem.Click += new System.EventHandler(this.preferencesCreateProjectToolStripMenuItem_Click);
            // 
            // preferencesModifyProjectToolStripMenuItem
            // 
            this.preferencesModifyProjectToolStripMenuItem.Name = "preferencesModifyProjectToolStripMenuItem";
            this.preferencesModifyProjectToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.preferencesModifyProjectToolStripMenuItem.Text = "&Modify Project";
            this.preferencesModifyProjectToolStripMenuItem.Click += new System.EventHandler(this.preferencesModifyProjectToolStripMenuItem_Click);
            // 
            // preferencesRemoveProjectToolStripMenuItem
            // 
            this.preferencesRemoveProjectToolStripMenuItem.Name = "preferencesRemoveProjectToolStripMenuItem";
            this.preferencesRemoveProjectToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.preferencesRemoveProjectToolStripMenuItem.Text = "&Remove Project";
            this.preferencesRemoveProjectToolStripMenuItem.Click += new System.EventHandler(this.preferencesRemoveProjectToolStripMenuItem_Click);
            // 
            // issuesToolStripMenuItem
            // 
            this.issuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuesDashboardToolStripMenuItem,
            this.issuesRecordToolStripMenuItem,
            this.issuesModifyToolStripMenuItem,
            this.issuesRemoveToolStripMenuItem,
            this.issuesReportToolStripMenuItem});
            this.issuesToolStripMenuItem.Name = "issuesToolStripMenuItem";
            this.issuesToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.issuesToolStripMenuItem.Text = "&Issue";
            // 
            // issuesDashboardToolStripMenuItem
            // 
            this.issuesDashboardToolStripMenuItem.Name = "issuesDashboardToolStripMenuItem";
            this.issuesDashboardToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.issuesDashboardToolStripMenuItem.Text = "&Dashboard";
            this.issuesDashboardToolStripMenuItem.Click += new System.EventHandler(this.issuesDashboardToolStripMenuItem_Click);
            // 
            // issuesRecordToolStripMenuItem
            // 
            this.issuesRecordToolStripMenuItem.Name = "issuesRecordToolStripMenuItem";
            this.issuesRecordToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.issuesRecordToolStripMenuItem.Text = "&Record";
            this.issuesRecordToolStripMenuItem.Click += new System.EventHandler(this.issuesRecordToolStripMenuItem_Click);
            // 
            // issuesModifyToolStripMenuItem
            // 
            this.issuesModifyToolStripMenuItem.Name = "issuesModifyToolStripMenuItem";
            this.issuesModifyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.issuesModifyToolStripMenuItem.Text = "&Modify";
            this.issuesModifyToolStripMenuItem.Click += new System.EventHandler(this.issuesModifyToolStripMenuItem_Click);
            // 
            // issuesRemoveToolStripMenuItem
            // 
            this.issuesRemoveToolStripMenuItem.Name = "issuesRemoveToolStripMenuItem";
            this.issuesRemoveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.issuesRemoveToolStripMenuItem.Text = "R&emove";
            this.issuesRemoveToolStripMenuItem.Click += new System.EventHandler(this.issuesRemoveToolStripMenuItem_Click);
            // 
            // issuesReportToolStripMenuItem
            // 
            this.issuesReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuesReportCountByAssigneeToolStripMenuItem,
            this.issuesReportListByAssigneeToolStripMenuItem,
            this.issuesReportCountByArtifactToolStripMenuItem,
            this.issuesReportListByArtifactToolStripMenuItem,
            this.issuesReportCountByDateRangeToolStripMenuItem,
            this.issuesReportListByDateRangeToolStripMenuItem,
            this.issuesReportTrendByDateRangeToolStripMenuItem});
            this.issuesReportToolStripMenuItem.Name = "issuesReportToolStripMenuItem";
            this.issuesReportToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.issuesReportToolStripMenuItem.Text = "Re&port";
            // 
            // issuesReportCountByAssigneeToolStripMenuItem
            // 
            this.issuesReportCountByAssigneeToolStripMenuItem.Name = "issuesReportCountByAssigneeToolStripMenuItem";
            this.issuesReportCountByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.issuesReportCountByAssigneeToolStripMenuItem.Text = "Count by Assignee";
            // 
            // issuesReportListByAssigneeToolStripMenuItem
            // 
            this.issuesReportListByAssigneeToolStripMenuItem.Name = "issuesReportListByAssigneeToolStripMenuItem";
            this.issuesReportListByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.issuesReportListByAssigneeToolStripMenuItem.Text = "List by Assignee";
            // 
            // issuesReportCountByArtifactToolStripMenuItem
            // 
            this.issuesReportCountByArtifactToolStripMenuItem.Name = "issuesReportCountByArtifactToolStripMenuItem";
            this.issuesReportCountByArtifactToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.issuesReportCountByArtifactToolStripMenuItem.Text = "Count by Artifact";
            // 
            // issuesReportListByArtifactToolStripMenuItem
            // 
            this.issuesReportListByArtifactToolStripMenuItem.Name = "issuesReportListByArtifactToolStripMenuItem";
            this.issuesReportListByArtifactToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.issuesReportListByArtifactToolStripMenuItem.Text = "List by Artifact";
            // 
            // issuesReportCountByDateRangeToolStripMenuItem
            // 
            this.issuesReportCountByDateRangeToolStripMenuItem.Name = "issuesReportCountByDateRangeToolStripMenuItem";
            this.issuesReportCountByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.issuesReportCountByDateRangeToolStripMenuItem.Text = "Count by Date Range";
            // 
            // issuesReportListByDateRangeToolStripMenuItem
            // 
            this.issuesReportListByDateRangeToolStripMenuItem.Name = "issuesReportListByDateRangeToolStripMenuItem";
            this.issuesReportListByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.issuesReportListByDateRangeToolStripMenuItem.Text = "List by Date Range";
            // 
            // issuesReportTrendByDateRangeToolStripMenuItem
            // 
            this.issuesReportTrendByDateRangeToolStripMenuItem.Name = "issuesReportTrendByDateRangeToolStripMenuItem";
            this.issuesReportTrendByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.issuesReportTrendByDateRangeToolStripMenuItem.Text = "Trend by Date Range";
            // 
            // requirementsToolStripMenuItem
            // 
            this.requirementsToolStripMenuItem.Name = "requirementsToolStripMenuItem";
            this.requirementsToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.requirementsToolStripMenuItem.Text = "&Requirement";
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.designToolStripMenuItem.Text = "&Design";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.testToolStripMenuItem.Text = "&Test";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 927);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesSelectProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesCreateProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesModifyProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesRemoveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesReportCountByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesReportListByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesReportCountByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesReportListByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesReportCountByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesReportListByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesReportTrendByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}


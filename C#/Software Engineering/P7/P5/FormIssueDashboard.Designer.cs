namespace P6
{
    partial class FormIssueDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelIssueCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxIssuesByMonth = new System.Windows.Forms.ListBox();
            this.listBoxIssuesByDiscoverer = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of Issues:";
            // 
            // labelIssueCount
            // 
            this.labelIssueCount.AutoSize = true;
            this.labelIssueCount.Location = new System.Drawing.Point(174, 25);
            this.labelIssueCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIssueCount.Name = "labelIssueCount";
            this.labelIssueCount.Size = new System.Drawing.Size(13, 13);
            this.labelIssueCount.TabIndex = 1;
            this.labelIssueCount.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Issues by Month";
            // 
            // listBoxIssuesByMonth
            // 
            this.listBoxIssuesByMonth.FormattingEnabled = true;
            this.listBoxIssuesByMonth.Location = new System.Drawing.Point(45, 81);
            this.listBoxIssuesByMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxIssuesByMonth.Name = "listBoxIssuesByMonth";
            this.listBoxIssuesByMonth.Size = new System.Drawing.Size(203, 121);
            this.listBoxIssuesByMonth.TabIndex = 3;
            // 
            // listBoxIssuesByDiscoverer
            // 
            this.listBoxIssuesByDiscoverer.FormattingEnabled = true;
            this.listBoxIssuesByDiscoverer.Location = new System.Drawing.Point(45, 251);
            this.listBoxIssuesByDiscoverer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxIssuesByDiscoverer.Name = "listBoxIssuesByDiscoverer";
            this.listBoxIssuesByDiscoverer.Size = new System.Drawing.Size(203, 121);
            this.listBoxIssuesByDiscoverer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Issues by Discoverer";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(174, 395);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(74, 31);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormIssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxIssuesByDiscoverer);
            this.Controls.Add(this.listBoxIssuesByMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIssueCount);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormIssueDashboard";
            this.Text = "IssueDashboard";
            this.Load += new System.EventHandler(this.FormIssueDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIssueCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxIssuesByMonth;
        private System.Windows.Forms.ListBox listBoxIssuesByDiscoverer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClose;
    }
}
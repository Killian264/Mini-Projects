namespace P6
{
    partial class FormRequirementCreate
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
            this.textBoxStatement = new System.Windows.Forms.RichTextBox();
            this.dropDownFeatures = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStatement
            // 
            this.textBoxStatement.Location = new System.Drawing.Point(214, 124);
            this.textBoxStatement.Name = "textBoxStatement";
            this.textBoxStatement.Size = new System.Drawing.Size(739, 540);
            this.textBoxStatement.TabIndex = 33;
            this.textBoxStatement.Text = "";
            // 
            // dropDownFeatures
            // 
            this.dropDownFeatures.FormattingEnabled = true;
            this.dropDownFeatures.Location = new System.Drawing.Point(214, 69);
            this.dropDownFeatures.Name = "dropDownFeatures";
            this.dropDownFeatures.Size = new System.Drawing.Size(739, 28);
            this.dropDownFeatures.TabIndex = 32;
            this.dropDownFeatures.Text = "<Make Selection>";
            this.dropDownFeatures.TextChanged += new System.EventHandler(this.dropDownFeatures_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Features:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Statement:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(373, 714);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(267, 29);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(686, 714);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(267, 29);
            this.buttonSubmit.TabIndex = 34;
            this.buttonSubmit.Text = "Create Requirement";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormRequirementCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 806);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxStatement);
            this.Controls.Add(this.dropDownFeatures);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "FormRequirementCreate";
            this.Text = "FormRequirementCreate";
            this.Load += new System.EventHandler(this.FormRequirementCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxStatement;
        public System.Windows.Forms.ComboBox dropDownFeatures;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}
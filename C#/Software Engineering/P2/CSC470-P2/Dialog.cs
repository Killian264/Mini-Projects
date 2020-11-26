using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC470_P2
{
    public partial class Dialog : Form
    {
        public string fishType;
        public OutcomeForm OCF = new OutcomeForm();

        public Dialog(string fishType)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.fishType = fishType;

            if (fishType == "")
            {
                this.OCF.SetOutcomeMsg("Choose a bait before casting!");
                this.OCF.ShowDialog();
                this.Close();
            }
            else
            {
                LoadPictures();
            }
        }

        private void LoadPictures()
        {
            switch(this.fishType)
            {
                case "Crappie":
                    pictureBox1.Image = Properties.Resources.Crappie;
                    break;
                case "Perch":
                    pictureBox1.Image = Properties.Resources.Perch;
                    break;
                case "Walleye":
                    pictureBox1.Image = Properties.Resources.Walleye;
                    break;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.OCF.SetOutcomeMsg("Decision Cancelled");
            this.OCF.ShowDialog();
            this.Close();
        }

        private void ReleaseButton_Click(object sender, EventArgs e)
        {
            this.OCF.SetOutcomeMsg("Decision is to throw it back");
            this.OCF.ShowDialog();
            this.Close();
        }

        private void KeepButton_Click(object sender, EventArgs e)
        {
            this.OCF.SetOutcomeMsg("Decision is to keep it");
            this.OCF.ShowDialog();
            this.Close();
        }
    }
}

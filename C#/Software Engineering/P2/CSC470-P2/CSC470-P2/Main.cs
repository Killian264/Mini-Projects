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
    public partial class Main : Form
    {
        public string fishType = "";
        
        public Main()
        {
            InitializeComponent();
        }

        private void OpenDialog_Click(object sender, EventArgs e)
        {
            if (this.fishType == "")
            {
                OutcomeForm Dec = new OutcomeForm();
                Dec.SetOutcomeMsg("Choose a bait before casting!");
                Dec.ShowDialog();
            }
            else
            {
                Dialog dialog = new Dialog(fishType);
                dialog.ShowDialog();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.fishType = "Crappie";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.fishType = "Perch";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.fishType = "Walleye";
        }
    }
}

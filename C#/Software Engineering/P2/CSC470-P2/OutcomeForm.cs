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
    public partial class OutcomeForm : Form
    {
        public OutcomeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void OutcomeMsg(object sender, EventArgs e)
        {

        }

        private void OKButton(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetOutcomeMsg(string outcome)
        {
            this.OutcomeTextbox.Text = outcome;
        }
    }
}

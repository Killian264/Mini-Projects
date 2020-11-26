using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_Code
{
    public partial class FormLogin : Form
    {
        public AppUser ReturnUser { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            this.CenterTheForm();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.CenterTheForm();
        }
    
        private void CenterTheForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // TEXTBOXES

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // BUTTONS

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            FakeAppUserRepository UserRepo = new FakeAppUserRepository();

            if(UserRepo.Login(UserNameTextBox.Text, PasswordTextBox.Text))
            {
                UserRepo.SetAuthentication(UserNameTextBox.Text, true);
                ReturnUser = UserRepo.GetByUserName(UserNameTextBox.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password","Attention");
            }

        }

        // LABELS

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

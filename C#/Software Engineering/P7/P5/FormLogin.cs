using System;
using System.Windows.Forms;

namespace P6
{
    public partial class FormLogin : Form
    {
        FakeAppUserRepository _AppUserRepository = new FakeAppUserRepository();
        public AppUser _CurrentAppUser;

        public FormLogin()
        {
            InitializeComponent();
            _CurrentAppUser = new AppUser();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (_AppUserRepository.Login(textBoxUserName.Text, textBoxPassword.Text))
            {
                _AppUserRepository.SetAuthentication(textBoxUserName.Text, true);
                _CurrentAppUser = _AppUserRepository.GetByUserName(textBoxUserName.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password.", "Attention");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            // *******************
            // Temporarily hide the forgot password button
            // *******************
            buttonForgotPassword.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

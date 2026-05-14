using System;
using System.Drawing;
using System.Windows.Forms;
using keyfila1.Services;
using keyfila1.Models;

namespace keyfila1.UI.Controls
{
    public partial class LoginControl : UserControl
    {
        public event EventHandler<User> LoginSuccessful;
        public event EventHandler RegisterClicked;
        public event EventHandler ForgotPasswordClicked;

        public LoginControl()
        {
            InitializeComponent();
            
            // Set background image
            try
            {
                string bgPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Assets", "login_bg.png");
                if (System.IO.File.Exists(bgPath))
                {
                    this.BackgroundImage = Image.FromFile(bgPath);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch { /* Fallback to default color if image fails */ }

            btnLogin.Click += BtnLogin_Click;
            lnkRegister.LinkClicked += (s, e) => RegisterClicked?.Invoke(this, EventArgs.Empty);
            lnkForgot.LinkClicked   += (s, e) => ForgotPasswordClicked?.Invoke(this, EventArgs.Empty);

            // Show / hide password toggle
            chkShowPassword.CheckedChanged += (s, e) => {
                txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
            };

            lblClose.Click += (s, e) => Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = AuthService.Login(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                LoginSuccessful?.Invoke(this, user);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

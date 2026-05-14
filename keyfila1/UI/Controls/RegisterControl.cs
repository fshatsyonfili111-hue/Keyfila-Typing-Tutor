using System;
using System.Drawing;
using System.Windows.Forms;
using keyfila1.Services;

namespace keyfila1.UI.Controls
{
    public partial class RegisterControl : UserControl
    {
        public event EventHandler RegistrationSuccessful;
        public event EventHandler LoginClicked;

        public RegisterControl()
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

            btnRegister.Click += BtnRegister_Click;
            lnkLogin.LinkClicked += (s, e) => LoginClicked?.Invoke(this, EventArgs.Empty);
            lblClose.Click += (s, e) => Application.Exit();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbQuestion.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a security question.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                MessageBox.Show("Please provide an answer to your security question.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string question = cmbQuestion.SelectedItem.ToString();
            string answer = txtAnswer.Text.Trim().ToLower(); // store lowercase for case-insensitive comparison

            if (AuthService.Register(txtUsername.Text, txtPassword.Text, question, answer))
            {
                MessageBox.Show("Registration successful! Please login.", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegistrationSuccessful?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

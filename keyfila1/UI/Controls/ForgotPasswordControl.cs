using System;
using System.Windows.Forms;
using keyfila1.Services;

namespace keyfila1.UI.Controls
{
    public partial class ForgotPasswordControl : UserControl
    {
        public event EventHandler BackToLoginClicked;

        public ForgotPasswordControl()
        {
            InitializeComponent();
            lblClose.Click     += (s, e) => Application.Exit();
            btnBack.Click      += (s, e) => BackToLoginClicked?.Invoke(this, EventArgs.Empty);
            btnFindUser.Click  += BtnFindUser_Click;
            btnReset.Click     += BtnReset_Click;

            // Start on step 1
            ShowStep(1);
        }

        private void ShowStep(int step)
        {
            pnlStep1.Visible = (step == 1);
            pnlStep2.Visible = (step == 2);
            pnlStep3.Visible = (step == 3);
        }

        // Step 1: User enters their username
        private void BtnFindUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter your username.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string question = AuthService.GetSecurityQuestion(txtUsername.Text.Trim());
            if (question == null)
            {
                MessageBox.Show("Username not found. Please check your spelling.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Show the security question
            lblQuestion.Text = question;
            ShowStep(2);
        }

        // Step 2: User answers the security question
        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                MessageBox.Show("Please enter your answer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || txtNewPassword.Text != txtConfirmNew.Text)
            {
                MessageBox.Show("Passwords do not match or are empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string answer = txtAnswer.Text.Trim().ToLower(); // compare lowercase
            bool success = AuthService.ResetPassword(txtUsername.Text.Trim(), answer, txtNewPassword.Text);

            if (success)
            {
                MessageBox.Show("Password reset successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackToLoginClicked?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Incorrect answer. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

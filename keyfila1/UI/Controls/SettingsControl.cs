using System;
using System.Drawing;
using System.Windows.Forms;
using keyfila1.Models;
using keyfila1.Services;

namespace keyfila1.UI.Controls
{
    public partial class SettingsControl : UserControl
    {
        private readonly User currentUser;

        public event EventHandler UsernameChanged; // so FormMain can refresh the menu label

        public SettingsControl(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            BuildAccountSection();
        }

        // ─────────────────────────────────────────────
        //  CHANGE USERNAME
        // ─────────────────────────────────────────────
        private void BuildAccountSection()
        {
            lblCurrentUser.Text = $"Logged in as: {currentUser.Username}";

            btnChangeUsername.Click += BtnChangeUsername_Click;
            btnChangePassword.Click += BtnChangePassword_Click;
        }

        private void BtnChangeUsername_Click(object sender, EventArgs e)
        {
            string newUsername   = txtNewUsername.Text.Trim();
            string confirmPass   = txtConfirmPassForUsername.Text;

            if (string.IsNullOrWhiteSpace(newUsername))
            {
                ShowError("Please enter a new username.");
                return;
            }
            if (string.IsNullOrWhiteSpace(confirmPass))
            {
                ShowError("Please enter your current password to confirm.");
                return;
            }

            bool ok = AuthService.UpdateUsername(currentUser.Id, confirmPass, newUsername);
            if (ok)
            {
                currentUser.Username = newUsername;
                lblCurrentUser.Text = $"Logged in as: {currentUser.Username}";
                txtNewUsername.Clear();
                txtConfirmPassForUsername.Clear();
                ShowSuccess("Username updated successfully!");
                UsernameChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                ShowError("Could not update username.\nEither your password is wrong or the username is already taken.");
            }
        }

        // ─────────────────────────────────────────────
        //  CHANGE PASSWORD
        // ─────────────────────────────────────────────
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPass = txtCurrentPassword.Text;
            string newPass     = txtNewPassword.Text;
            string confirmPass = txtConfirmNewPassword.Text;

            if (string.IsNullOrWhiteSpace(currentPass) || string.IsNullOrWhiteSpace(newPass))
            {
                ShowError("Please fill in all password fields.");
                return;
            }
            if (newPass != confirmPass)
            {
                ShowError("New passwords do not match.");
                return;
            }
            if (newPass.Length < 4)
            {
                ShowError("New password must be at least 4 characters.");
                return;
            }

            bool ok = AuthService.UpdatePassword(currentUser.Id, currentPass, newPass);
            if (ok)
            {
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmNewPassword.Clear();
                ShowSuccess("Password changed successfully!");
            }
            else
            {
                ShowError("Current password is incorrect.");
            }
        }

        // ─────────────────────────────────────────────
        //  Helpers
        // ─────────────────────────────────────────────
        private void ShowError(string msg)
            => MessageBox.Show(msg, "Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void ShowSuccess(string msg)
            => MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

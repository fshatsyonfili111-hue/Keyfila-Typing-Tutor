namespace keyfila1.UI.Controls
{
    partial class SettingsControl
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentUser;

        // ── Change Username section ──
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label lblUsernameTitle;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblConfirmPassForUsername;
        private System.Windows.Forms.TextBox txtConfirmPassForUsername;
        private System.Windows.Forms.Button btnChangeUsername;

        // ── Change Password section ──
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label lblPasswordTitle;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Button btnChangePassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle                   = new System.Windows.Forms.Label();
            this.lblCurrentUser             = new System.Windows.Forms.Label();
            this.pnlUsername                = new System.Windows.Forms.Panel();
            this.lblUsernameTitle           = new System.Windows.Forms.Label();
            this.lblNewUsername             = new System.Windows.Forms.Label();
            this.txtNewUsername             = new System.Windows.Forms.TextBox();
            this.lblConfirmPassForUsername  = new System.Windows.Forms.Label();
            this.txtConfirmPassForUsername  = new System.Windows.Forms.TextBox();
            this.btnChangeUsername          = new System.Windows.Forms.Button();
            this.pnlPassword               = new System.Windows.Forms.Panel();
            this.lblPasswordTitle           = new System.Windows.Forms.Label();
            this.lblCurrentPassword         = new System.Windows.Forms.Label();
            this.txtCurrentPassword         = new System.Windows.Forms.TextBox();
            this.lblNewPassword             = new System.Windows.Forms.Label();
            this.txtNewPassword             = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword      = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword      = new System.Windows.Forms.TextBox();
            this.btnChangePassword          = new System.Windows.Forms.Button();

            this.pnlUsername.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.SuspendLayout();

            // ─── lblTitle ───
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.lblTitle.Location  = new System.Drawing.Point(40, 30);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Size      = new System.Drawing.Size(900, 40);
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "⚙  Settings";

            // ─── lblCurrentUser ───
            this.lblCurrentUser.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblCurrentUser.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentUser.Location  = new System.Drawing.Point(40, 75);
            this.lblCurrentUser.Name      = "lblCurrentUser";
            this.lblCurrentUser.Size      = new System.Drawing.Size(500, 25);
            this.lblCurrentUser.TabIndex  = 1;
            this.lblCurrentUser.Text      = "Logged in as: ...";

            // ══════════════════════════════════════════
            //  CHANGE USERNAME PANEL
            // ══════════════════════════════════════════
            this.pnlUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsername.Location    = new System.Drawing.Point(40, 115);
            this.pnlUsername.Name        = "pnlUsername";
            this.pnlUsername.Size        = new System.Drawing.Size(440, 290);
            this.pnlUsername.TabIndex    = 2;
            this.pnlUsername.Controls.Add(this.lblUsernameTitle);
            this.pnlUsername.Controls.Add(this.lblNewUsername);
            this.pnlUsername.Controls.Add(this.txtNewUsername);
            this.pnlUsername.Controls.Add(this.lblConfirmPassForUsername);
            this.pnlUsername.Controls.Add(this.txtConfirmPassForUsername);
            this.pnlUsername.Controls.Add(this.btnChangeUsername);

            this.lblUsernameTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblUsernameTitle.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.lblUsernameTitle.Location  = new System.Drawing.Point(15, 15);
            this.lblUsernameTitle.Name      = "lblUsernameTitle";
            this.lblUsernameTitle.Size      = new System.Drawing.Size(400, 28);
            this.lblUsernameTitle.TabIndex  = 0;
            this.lblUsernameTitle.Text      = "Change Username";

            this.lblNewUsername.AutoSize  = true;
            this.lblNewUsername.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewUsername.Location  = new System.Drawing.Point(15, 60);
            this.lblNewUsername.Name      = "lblNewUsername";
            this.lblNewUsername.TabIndex  = 1;
            this.lblNewUsername.Text      = "New Username";

            this.txtNewUsername.Font     = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewUsername.Location = new System.Drawing.Point(15, 82);
            this.txtNewUsername.Name     = "txtNewUsername";
            this.txtNewUsername.Size     = new System.Drawing.Size(400, 27);
            this.txtNewUsername.TabIndex = 2;

            this.lblConfirmPassForUsername.AutoSize  = true;
            this.lblConfirmPassForUsername.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmPassForUsername.Location  = new System.Drawing.Point(15, 125);
            this.lblConfirmPassForUsername.Name      = "lblConfirmPassForUsername";
            this.lblConfirmPassForUsername.TabIndex  = 3;
            this.lblConfirmPassForUsername.Text      = "Current Password (to confirm)";

            this.txtConfirmPassForUsername.Font         = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPassForUsername.Location     = new System.Drawing.Point(15, 147);
            this.txtConfirmPassForUsername.Name         = "txtConfirmPassForUsername";
            this.txtConfirmPassForUsername.PasswordChar = '●';
            this.txtConfirmPassForUsername.Size         = new System.Drawing.Size(400, 27);
            this.txtConfirmPassForUsername.TabIndex     = 4;

            this.btnChangeUsername.BackColor            = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnChangeUsername.Cursor               = System.Windows.Forms.Cursors.Hand;
            this.btnChangeUsername.FlatAppearance.BorderSize = 0;
            this.btnChangeUsername.FlatStyle            = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUsername.Font                 = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnChangeUsername.ForeColor            = System.Drawing.Color.White;
            this.btnChangeUsername.Location             = new System.Drawing.Point(15, 200);
            this.btnChangeUsername.Name                 = "btnChangeUsername";
            this.btnChangeUsername.Size                 = new System.Drawing.Size(400, 45);
            this.btnChangeUsername.TabIndex             = 5;
            this.btnChangeUsername.Text                 = "SAVE NEW USERNAME";
            this.btnChangeUsername.UseVisualStyleBackColor = false;

            // ══════════════════════════════════════════
            //  CHANGE PASSWORD PANEL
            // ══════════════════════════════════════════
            this.pnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPassword.Location    = new System.Drawing.Point(510, 115);
            this.pnlPassword.Name        = "pnlPassword";
            this.pnlPassword.Size        = new System.Drawing.Size(440, 360);
            this.pnlPassword.TabIndex    = 3;
            this.pnlPassword.Controls.Add(this.lblPasswordTitle);
            this.pnlPassword.Controls.Add(this.lblCurrentPassword);
            this.pnlPassword.Controls.Add(this.txtCurrentPassword);
            this.pnlPassword.Controls.Add(this.lblNewPassword);
            this.pnlPassword.Controls.Add(this.txtNewPassword);
            this.pnlPassword.Controls.Add(this.lblConfirmNewPassword);
            this.pnlPassword.Controls.Add(this.txtConfirmNewPassword);
            this.pnlPassword.Controls.Add(this.btnChangePassword);

            this.lblPasswordTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPasswordTitle.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.lblPasswordTitle.Location  = new System.Drawing.Point(15, 15);
            this.lblPasswordTitle.Name      = "lblPasswordTitle";
            this.lblPasswordTitle.Size      = new System.Drawing.Size(400, 28);
            this.lblPasswordTitle.TabIndex  = 0;
            this.lblPasswordTitle.Text      = "Change Password";

            this.lblCurrentPassword.AutoSize  = true;
            this.lblCurrentPassword.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentPassword.Location  = new System.Drawing.Point(15, 60);
            this.lblCurrentPassword.Name      = "lblCurrentPassword";
            this.lblCurrentPassword.TabIndex  = 1;
            this.lblCurrentPassword.Text      = "Current Password";

            this.txtCurrentPassword.Font         = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCurrentPassword.Location     = new System.Drawing.Point(15, 82);
            this.txtCurrentPassword.Name         = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '●';
            this.txtCurrentPassword.Size         = new System.Drawing.Size(400, 27);
            this.txtCurrentPassword.TabIndex     = 2;

            this.lblNewPassword.AutoSize  = true;
            this.lblNewPassword.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewPassword.Location  = new System.Drawing.Point(15, 125);
            this.lblNewPassword.Name      = "lblNewPassword";
            this.lblNewPassword.TabIndex  = 3;
            this.lblNewPassword.Text      = "New Password";

            this.txtNewPassword.Font         = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPassword.Location     = new System.Drawing.Point(15, 147);
            this.txtNewPassword.Name         = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size         = new System.Drawing.Size(400, 27);
            this.txtNewPassword.TabIndex     = 4;

            this.lblConfirmNewPassword.AutoSize  = true;
            this.lblConfirmNewPassword.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmNewPassword.Location  = new System.Drawing.Point(15, 190);
            this.lblConfirmNewPassword.Name      = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.TabIndex  = 5;
            this.lblConfirmNewPassword.Text      = "Confirm New Password";

            this.txtConfirmNewPassword.Font         = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmNewPassword.Location     = new System.Drawing.Point(15, 212);
            this.txtConfirmNewPassword.Name         = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '●';
            this.txtConfirmNewPassword.Size         = new System.Drawing.Size(400, 27);
            this.txtConfirmNewPassword.TabIndex     = 6;

            this.btnChangePassword.BackColor            = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnChangePassword.Cursor               = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle            = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font                 = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor            = System.Drawing.Color.White;
            this.btnChangePassword.Location             = new System.Drawing.Point(15, 270);
            this.btnChangePassword.Name                 = "btnChangePassword";
            this.btnChangePassword.Size                 = new System.Drawing.Size(400, 45);
            this.btnChangePassword.TabIndex             = 7;
            this.btnChangePassword.Text                 = "SAVE NEW PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = false;

            // ─── SettingsControl ───
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.pnlPassword);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(984, 600);

            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}

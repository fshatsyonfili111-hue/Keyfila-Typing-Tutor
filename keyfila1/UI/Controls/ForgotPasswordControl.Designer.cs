namespace keyfila1.UI.Controls
{
    partial class ForgotPasswordControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;

        // Step 1 controls
        private System.Windows.Forms.Panel pnlStep1;
        private System.Windows.Forms.Label lblStep1Hint;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnFindUser;

        // Step 2 controls
        private System.Windows.Forms.Panel pnlStep2;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswerLbl;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmLbl;
        private System.Windows.Forms.TextBox txtConfirmNew;
        private System.Windows.Forms.Button btnReset;

        // Step 3 (unused, success is handled by navigation)
        private System.Windows.Forms.Panel pnlStep3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCard       = new System.Windows.Forms.Panel();
            this.lblClose      = new System.Windows.Forms.Label();
            this.lblTitle      = new System.Windows.Forms.Label();
            this.btnBack       = new System.Windows.Forms.Button();
            this.pnlStep1      = new System.Windows.Forms.Panel();
            this.lblStep1Hint  = new System.Windows.Forms.Label();
            this.txtUsername   = new System.Windows.Forms.TextBox();
            this.btnFindUser   = new System.Windows.Forms.Button();
            this.pnlStep2      = new System.Windows.Forms.Panel();
            this.lblQuestion   = new System.Windows.Forms.Label();
            this.lblAnswerLbl  = new System.Windows.Forms.Label();
            this.txtAnswer     = new System.Windows.Forms.TextBox();
            this.lblNewPass    = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmLbl = new System.Windows.Forms.Label();
            this.txtConfirmNew = new System.Windows.Forms.TextBox();
            this.btnReset      = new System.Windows.Forms.Button();
            this.pnlStep3      = new System.Windows.Forms.Panel();

            this.pnlCard.SuspendLayout();
            this.pnlStep1.SuspendLayout();
            this.pnlStep2.SuspendLayout();
            this.SuspendLayout();

            // ─── pnlCard ───
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblClose);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.btnBack);
            this.pnlCard.Controls.Add(this.pnlStep1);
            this.pnlCard.Controls.Add(this.pnlStep2);
            this.pnlCard.Controls.Add(this.pnlStep3);
            this.pnlCard.Location = new System.Drawing.Point(270, 90);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(460, 520);
            this.pnlCard.TabIndex = 0;

            // ─── lblClose ───
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblClose.Location = new System.Drawing.Point(425, 10);
            this.lblClose.Name = "lblClose";
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";

            // ─── lblTitle ───
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Forgot Password";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─── btnBack ───
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(83, 160, 255);
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Location = new System.Drawing.Point(40, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(380, 35);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "← Back to Login";

            // ══════ STEP 1 PANEL ══════
            this.pnlStep1.Location = new System.Drawing.Point(0, 95);
            this.pnlStep1.Name = "pnlStep1";
            this.pnlStep1.Size = new System.Drawing.Size(460, 370);
            this.pnlStep1.TabIndex = 2;
            this.pnlStep1.Controls.Add(this.lblStep1Hint);
            this.pnlStep1.Controls.Add(this.txtUsername);
            this.pnlStep1.Controls.Add(this.btnFindUser);

            this.lblStep1Hint.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStep1Hint.ForeColor = System.Drawing.Color.Gray;
            this.lblStep1Hint.Location = new System.Drawing.Point(40, 20);
            this.lblStep1Hint.Name = "lblStep1Hint";
            this.lblStep1Hint.Size = new System.Drawing.Size(380, 50);
            this.lblStep1Hint.TabIndex = 0;
            this.lblStep1Hint.Text = "Enter your username and we'll ask\nyour security question.";

            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(40, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(380, 29);
            this.txtUsername.TabIndex = 1;

            this.btnFindUser.BackColor = System.Drawing.Color.FromArgb(64, 200, 255);
            this.btnFindUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFindUser.ForeColor = System.Drawing.Color.White;
            this.btnFindUser.Location = new System.Drawing.Point(40, 135);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(380, 45);
            this.btnFindUser.TabIndex = 2;
            this.btnFindUser.Text = "FIND MY ACCOUNT";
            this.btnFindUser.UseVisualStyleBackColor = false;

            // ══════ STEP 2 PANEL ══════
            this.pnlStep2.Location = new System.Drawing.Point(0, 95);
            this.pnlStep2.Name = "pnlStep2";
            this.pnlStep2.Size = new System.Drawing.Size(460, 370);
            this.pnlStep2.TabIndex = 3;
            this.pnlStep2.Controls.Add(this.lblQuestion);
            this.pnlStep2.Controls.Add(this.lblAnswerLbl);
            this.pnlStep2.Controls.Add(this.txtAnswer);
            this.pnlStep2.Controls.Add(this.lblNewPass);
            this.pnlStep2.Controls.Add(this.txtNewPassword);
            this.pnlStep2.Controls.Add(this.lblConfirmLbl);
            this.pnlStep2.Controls.Add(this.txtConfirmNew);
            this.pnlStep2.Controls.Add(this.btnReset);

            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(83, 160, 255);
            this.lblQuestion.Location = new System.Drawing.Point(40, 10);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(380, 40);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Security question goes here";

            this.lblAnswerLbl.AutoSize = true;
            this.lblAnswerLbl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAnswerLbl.Location = new System.Drawing.Point(40, 55);
            this.lblAnswerLbl.Name = "lblAnswerLbl";
            this.lblAnswerLbl.TabIndex = 1;
            this.lblAnswerLbl.Text = "Your Answer";

            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnswer.Location = new System.Drawing.Point(40, 78);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(380, 29);
            this.txtAnswer.TabIndex = 2;

            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNewPass.Location = new System.Drawing.Point(40, 120);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.TabIndex = 3;
            this.lblNewPass.Text = "New Password";

            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewPassword.Location = new System.Drawing.Point(40, 143);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(380, 29);
            this.txtNewPassword.TabIndex = 4;

            this.lblConfirmLbl.AutoSize = true;
            this.lblConfirmLbl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblConfirmLbl.Location = new System.Drawing.Point(40, 185);
            this.lblConfirmLbl.Name = "lblConfirmLbl";
            this.lblConfirmLbl.TabIndex = 5;
            this.lblConfirmLbl.Text = "Confirm New Password";

            this.txtConfirmNew.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmNew.Location = new System.Drawing.Point(40, 208);
            this.txtConfirmNew.Name = "txtConfirmNew";
            this.txtConfirmNew.PasswordChar = '●';
            this.txtConfirmNew.Size = new System.Drawing.Size(380, 29);
            this.txtConfirmNew.TabIndex = 6;

            this.btnReset.BackColor = System.Drawing.Color.FromArgb(64, 200, 255);
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(40, 255);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(380, 45);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET PASSWORD";
            this.btnReset.UseVisualStyleBackColor = false;

            // ══════ STEP 3 PANEL (placeholder) ══════
            this.pnlStep3.Location = new System.Drawing.Point(0, 95);
            this.pnlStep3.Name = "pnlStep3";
            this.pnlStep3.Size = new System.Drawing.Size(460, 370);
            this.pnlStep3.TabIndex = 4;

            // ─── ForgotPasswordControl ───
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(143, 90, 255);
            this.Controls.Add(this.pnlCard);
            this.Name = "ForgotPasswordControl";
            this.Size = new System.Drawing.Size(1000, 700);

            this.pnlStep1.ResumeLayout(false);
            this.pnlStep2.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

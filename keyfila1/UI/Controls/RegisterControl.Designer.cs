namespace keyfila1.UI.Controls
{
    partial class RegisterControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ComboBox cmbQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lnkLogin;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.cmbQuestion = new System.Windows.Forms.ComboBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40))))); // Dark professional background
            this.pnlCard.Controls.Add(this.lblClose);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblUser);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.lblPass);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.lblConfirm);
            this.pnlCard.Controls.Add(this.txtConfirm);
            this.pnlCard.Controls.Add(this.lblQuestion);
            this.pnlCard.Controls.Add(this.cmbQuestion);
            this.pnlCard.Controls.Add(this.lblAnswer);
            this.pnlCard.Controls.Add(this.txtAnswer);
            this.pnlCard.Controls.Add(this.btnRegister);
            this.pnlCard.Controls.Add(this.lnkLogin);
            this.pnlCard.Location = new System.Drawing.Point(270, 40);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(460, 620);
            this.pnlCard.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblClose.Location = new System.Drawing.Point(425, 10);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 19);
            this.lblClose.TabIndex = 10;
            this.lblClose.Text = "X";
            this.lblClose.ForeColor = System.Drawing.Color.White; // Make close button white
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Student";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.ForeColor = System.Drawing.Color.White; // White text for dark theme
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUser.Location = new System.Drawing.Point(40, 100);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(75, 20);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username";
            this.lblUser.ForeColor = System.Drawing.Color.LightGray;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(40, 123);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(380, 29);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPass.Location = new System.Drawing.Point(40, 165);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(70, 20);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            this.lblPass.ForeColor = System.Drawing.Color.LightGray;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(40, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(380, 29);
            this.txtPassword.TabIndex = 4;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblConfirm.Location = new System.Drawing.Point(40, 230);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(127, 20);
            this.lblConfirm.TabIndex = 5;
            this.lblConfirm.Text = "Confirm Password";
            this.lblConfirm.ForeColor = System.Drawing.Color.LightGray;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirm.Location = new System.Drawing.Point(40, 253);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '●';
            this.txtConfirm.Size = new System.Drawing.Size(380, 29);
            this.txtConfirm.TabIndex = 6;
            // 
            // lblQuestion
            // 
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblQuestion.Location = new System.Drawing.Point(40, 295);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(130, 20);
            this.lblQuestion.TabIndex = 11;
            this.lblQuestion.Text = "Security Question";
            this.lblQuestion.ForeColor = System.Drawing.Color.LightGray;
            // 
            // cmbQuestion
            // 
            this.cmbQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbQuestion.Location = new System.Drawing.Point(40, 318);
            this.cmbQuestion.Name = "cmbQuestion";
            this.cmbQuestion.Size = new System.Drawing.Size(380, 28);
            this.cmbQuestion.TabIndex = 12;
            this.cmbQuestion.Items.AddRange(new object[] {
                "What is your pet's name?",
                "What city were you born in?",
                "What is your mother's maiden name?",
                "What was the name of your first school?",
                "What is your favourite colour?"});
            // 
            // lblAnswer
            // 
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAnswer.Location = new System.Drawing.Point(40, 360);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(57, 20);
            this.lblAnswer.TabIndex = 13;
            this.lblAnswer.Text = "Answer";
            this.lblAnswer.ForeColor = System.Drawing.Color.LightGray;
            // 
            // txtAnswer
            // 
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnswer.Location = new System.Drawing.Point(40, 383);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(380, 29);
            this.txtAnswer.TabIndex = 14;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(64, 200, 255);
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(40, 430);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(380, 45);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219))))); // Cyan matching the background
            // 
            // lnkLogin
            // 
            this.lnkLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkLogin.LinkColor = System.Drawing.Color.FromArgb(83, 160, 255);
            this.lnkLogin.Location = new System.Drawing.Point(0, 495);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(460, 25);
            this.lnkLogin.TabIndex = 8;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "Already have an account? Sign In";
            this.lnkLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219))))); // Matching cyan
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(143, 90, 255);
            this.Controls.Add(this.pnlCard);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(1000, 700);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}

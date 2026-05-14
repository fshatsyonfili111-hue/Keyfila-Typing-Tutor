namespace keyfila1.UI.Controls
{
    partial class ProfileControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel profileCard;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblJoined;
        private System.Windows.Forms.Button btnLogout;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.profileCard = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblJoined = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.profileCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 41);
            this.lblTitle.Text = "User Profile";
            // 
            // profileCard
            // 
            this.profileCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.profileCard.Controls.Add(this.btnLogout);
            this.profileCard.Controls.Add(this.lblJoined);
            this.profileCard.Controls.Add(this.lblUsername);
            this.profileCard.Location = new System.Drawing.Point(40, 100);
            this.profileCard.Name = "profileCard";
            this.profileCard.Size = new System.Drawing.Size(500, 300);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(30, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 25);
            this.lblUsername.Text = "Username:";
            // 
            // lblJoined
            // 
            this.lblJoined.AutoSize = true;
            this.lblJoined.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJoined.ForeColor = System.Drawing.Color.Gray;
            this.lblJoined.Location = new System.Drawing.Point(30, 70);
            this.lblJoined.Name = "lblJoined";
            this.lblJoined.Size = new System.Drawing.Size(100, 19);
            this.lblJoined.Text = "Member Since:";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(30, 220);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.profileCard);
            this.Controls.Add(this.lblTitle);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(600, 500);
            this.profileCard.ResumeLayout(false);
            this.profileCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

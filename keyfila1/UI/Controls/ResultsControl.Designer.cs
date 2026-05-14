namespace keyfila1.UI.Controls
{
    partial class ResultsControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRetry;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblDone = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDone
            // 
            this.lblDone.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblDone.Location = new System.Drawing.Point(0, 50);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(984, 60);
            this.lblDone.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.lblDone.Text = "LESSON COMPLETE!";
            this.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStars
            // 
            this.lblStars.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.lblStars.Location = new System.Drawing.Point(0, 120);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(984, 100);
            this.lblStars.ForeColor = System.Drawing.Color.Gold;
            this.lblStars.Text = "★★★";
            this.lblStars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStats
            // 
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblStats.Location = new System.Drawing.Point(200, 240);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(584, 180);
            this.lblStats.TabIndex = 2;
            this.lblStats.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.lblStats.Text = "Stats";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(80, 460);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(180, 50);
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "PREVIOUS";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.Location = new System.Drawing.Point(300, 460);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(180, 50);
            this.btnRetry.BackColor = System.Drawing.Color.FromArgb(255, 184, 0);
            this.btnRetry.FlatAppearance.BorderSize = 0;
            this.btnRetry.TabIndex = 2;
            this.btnRetry.Text = "RETRY";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(520, 460);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(180, 50);
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(740, 460);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 50);
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(46, 147, 255);
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "BACK TO LEVELS";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ResultsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblStars);
            this.Controls.Add(this.lblDone);
            this.Name = "ResultsControl";
            this.Size = new System.Drawing.Size(984, 600);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}

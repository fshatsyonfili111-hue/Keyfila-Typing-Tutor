namespace keyfila1.UI.Controls
{
    partial class LevelSelectorControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblLevelTitle;
        private System.Windows.Forms.Label lblLevelDescription;
        private System.Windows.Forms.FlowLayoutPanel lessonsFlowPanel;
        private System.Windows.Forms.Button btnBeginner;
        private System.Windows.Forms.Button btnIntermediate;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ProgressBar levelProgressBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ToolTip toolTipInfo;

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
            this.components = new System.ComponentModel.Container();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.levelProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.btnIntermediate = new System.Windows.Forms.Button();
            this.btnBeginner = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lessonsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLevelTitle = new System.Windows.Forms.Label();
            this.lblLevelDescription = new System.Windows.Forms.Label();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.sidePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.sidePanel.Controls.Add(this.lblProgress);
            this.sidePanel.Controls.Add(this.levelProgressBar);
            this.sidePanel.Controls.Add(this.btnAdvanced);
            this.sidePanel.Controls.Add(this.btnIntermediate);
            this.sidePanel.Controls.Add(this.btnBeginner);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 600);
            this.sidePanel.TabIndex = 0;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblProgress.Location = new System.Drawing.Point(20, 535);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(87, 15);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Text = "Level Progress";
            // 
            // levelProgressBar
            // 
            this.levelProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.levelProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.levelProgressBar.Location = new System.Drawing.Point(20, 555);
            this.levelProgressBar.Name = "levelProgressBar";
            this.levelProgressBar.Size = new System.Drawing.Size(210, 15);
            this.levelProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.levelProgressBar.TabIndex = 3;
            // 
            // btnBeginner
            // 
            this.btnBeginner.FlatAppearance.BorderSize = 0;
            this.btnBeginner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.btnBeginner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBeginner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBeginner.Location = new System.Drawing.Point(0, 0);
            this.btnBeginner.Name = "btnBeginner";
            this.btnBeginner.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBeginner.Size = new System.Drawing.Size(250, 60);
            this.btnBeginner.TabIndex = 0;
            this.btnBeginner.Text = "Beginner";
            this.btnBeginner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeginner.UseVisualStyleBackColor = true;
            this.btnBeginner.Click += new System.EventHandler(this.BtnLevel_Click);
            // 
            // btnIntermediate
            // 
            this.btnIntermediate.FlatAppearance.BorderSize = 0;
            this.btnIntermediate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.btnIntermediate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntermediate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIntermediate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnIntermediate.Location = new System.Drawing.Point(0, 60);
            this.btnIntermediate.Name = "btnIntermediate";
            this.btnIntermediate.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnIntermediate.Size = new System.Drawing.Size(250, 60);
            this.btnIntermediate.TabIndex = 1;
            this.btnIntermediate.Text = "Intermediate";
            this.btnIntermediate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntermediate.UseVisualStyleBackColor = true;
            this.btnIntermediate.Click += new System.EventHandler(this.BtnLevel_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.FlatAppearance.BorderSize = 0;
            this.btnAdvanced.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.btnAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanced.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdvanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAdvanced.Location = new System.Drawing.Point(0, 120);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAdvanced.Size = new System.Drawing.Size(250, 60);
            this.btnAdvanced.TabIndex = 2;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.BtnLevel_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.cmbFilter);
            this.mainPanel.Controls.Add(this.lblSearch);
            this.mainPanel.Controls.Add(this.txtSearch);
            this.mainPanel.Controls.Add(this.lessonsFlowPanel);
            this.mainPanel.Controls.Add(this.lblLevelDescription);
            this.mainPanel.Controls.Add(this.lblLevelTitle);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(250, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(30);
            this.mainPanel.Size = new System.Drawing.Size(734, 600);
            this.mainPanel.TabIndex = 1;
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All Lessons",
            "Completed",
            "Not Started"});
            this.cmbFilter.Location = new System.Drawing.Point(540, 110);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(160, 25);
            this.cmbFilter.TabIndex = 4;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSearch.Location = new System.Drawing.Point(30, 113);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 19);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(94, 110);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 25);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lessonsFlowPanel
            // 
            this.lessonsFlowPanel.AutoScroll = true;
            this.lessonsFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.lessonsFlowPanel.Location = new System.Drawing.Point(30, 150);
            this.lessonsFlowPanel.Name = "lessonsFlowPanel";
            this.lessonsFlowPanel.Size = new System.Drawing.Size(674, 420);
            this.lessonsFlowPanel.TabIndex = 1;
            // 
            // lblLevelTitle
            // 
            this.lblLevelTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLevelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLevelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblLevelTitle.Location = new System.Drawing.Point(30, 30);
            this.lblLevelTitle.Name = "lblLevelTitle";
            this.lblLevelTitle.Size = new System.Drawing.Size(674, 40);
            this.lblLevelTitle.TabIndex = 0;
            this.lblLevelTitle.Text = "Lessons";
            // 
            // lblLevelDescription
            // 
            this.lblLevelDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLevelDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblLevelDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblLevelDescription.Location = new System.Drawing.Point(30, 70);
            this.lblLevelDescription.Name = "lblLevelDescription";
            this.lblLevelDescription.Size = new System.Drawing.Size(674, 30);
            this.lblLevelDescription.TabIndex = 5;
            this.lblLevelDescription.Text = "Level description goes here...";
            // 
            // LevelSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "LevelSelectorControl";
            this.Size = new System.Drawing.Size(984, 600);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

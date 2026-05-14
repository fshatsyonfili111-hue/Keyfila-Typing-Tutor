namespace keyfila1.UI.Controls
{
    partial class PracticeControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel mainContent;
        private System.Windows.Forms.Label lblWpm;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Panel keyboardPanel;
        private System.Windows.Forms.Button btnQ, btnW, btnE, btnR, btnT, btnY, btnU, btnI, btnO, btnP;
        private System.Windows.Forms.Button btnA, btnS, btnD, btnF, btnG, btnH, btnJ, btnK, btnL;
        private System.Windows.Forms.Button btnZ, btnX, btnC, btnV, btnB, btnN, btnM;
        private System.Windows.Forms.Button btnSpace;

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
            this.statsPanel = new System.Windows.Forms.Panel();
            this.lblWpm = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.mainContent = new System.Windows.Forms.Panel();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.keyboardPanel = new System.Windows.Forms.Panel();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.statsPanel.SuspendLayout();
            this.mainContent.SuspendLayout();
            this.keyboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.lblTime);
            this.statsPanel.Controls.Add(this.lblErrors);
            this.statsPanel.Controls.Add(this.lblAccuracy);
            this.statsPanel.Controls.Add(this.lblWpm);
            this.statsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsPanel.Location = new System.Drawing.Point(0, 0);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(984, 60);
            this.statsPanel.TabIndex = 0;
            // 
            // lblWpm
            // 
            this.lblWpm.AutoSize = true;
            this.lblWpm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWpm.Location = new System.Drawing.Point(20, 15);
            this.lblWpm.Name = "lblWpm";
            this.lblWpm.Size = new System.Drawing.Size(86, 25);
            this.lblWpm.TabIndex = 0;
            this.lblWpm.Text = "WPM: 0";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAccuracy.Location = new System.Drawing.Point(150, 15);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(152, 25);
            this.lblAccuracy.TabIndex = 1;
            this.lblAccuracy.Text = "Accuracy: 100%";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblErrors.Location = new System.Drawing.Point(350, 15);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(86, 25);
            this.lblErrors.TabIndex = 2;
            this.lblErrors.Text = "Errors: 0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(500, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(116, 25);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time: 00:00";
            // 
            // mainContent
            // 
            this.mainContent.Controls.Add(this.keyboardPanel);
            this.mainContent.Controls.Add(this.rtbDisplay);
            this.mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContent.Location = new System.Drawing.Point(0, 60);
            this.mainContent.Name = "mainContent";
            this.mainContent.Size = new System.Drawing.Size(984, 540);
            this.mainContent.TabIndex = 1;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbDisplay.Font = new System.Drawing.Font("Consolas", 24F);
            this.rtbDisplay.Location = new System.Drawing.Point(0, 0);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(984, 150);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // keyboardPanel
            // 
            this.keyboardPanel.Controls.Add(this.btnSpace);
            this.keyboardPanel.Controls.Add(this.btnM);
            this.keyboardPanel.Controls.Add(this.btnN);
            this.keyboardPanel.Controls.Add(this.btnB);
            this.keyboardPanel.Controls.Add(this.btnV);
            this.keyboardPanel.Controls.Add(this.btnC);
            this.keyboardPanel.Controls.Add(this.btnX);
            this.keyboardPanel.Controls.Add(this.btnZ);
            this.keyboardPanel.Controls.Add(this.btnL);
            this.keyboardPanel.Controls.Add(this.btnK);
            this.keyboardPanel.Controls.Add(this.btnJ);
            this.keyboardPanel.Controls.Add(this.btnH);
            this.keyboardPanel.Controls.Add(this.btnG);
            this.keyboardPanel.Controls.Add(this.btnF);
            this.keyboardPanel.Controls.Add(this.btnD);
            this.keyboardPanel.Controls.Add(this.btnS);
            this.keyboardPanel.Controls.Add(this.btnA);
            this.keyboardPanel.Controls.Add(this.btnP);
            this.keyboardPanel.Controls.Add(this.btnO);
            this.keyboardPanel.Controls.Add(this.btnI);
            this.keyboardPanel.Controls.Add(this.btnU);
            this.keyboardPanel.Controls.Add(this.btnY);
            this.keyboardPanel.Controls.Add(this.btnT);
            this.keyboardPanel.Controls.Add(this.btnR);
            this.keyboardPanel.Controls.Add(this.btnE);
            this.keyboardPanel.Controls.Add(this.btnW);
            this.keyboardPanel.Controls.Add(this.btnQ);
            this.keyboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyboardPanel.Location = new System.Drawing.Point(0, 150);
            this.keyboardPanel.Name = "keyboardPanel";
            this.keyboardPanel.Padding = new System.Windows.Forms.Padding(50);
            this.keyboardPanel.Size = new System.Drawing.Size(984, 390);
            this.keyboardPanel.TabIndex = 1;
            // 
            // btnQ
            // 
            this.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQ.Location = new System.Drawing.Point(100, 50);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(50, 50);
            this.btnQ.TabIndex = 0;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            this.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW.Location = new System.Drawing.Point(155, 50);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(50, 50);
            this.btnW.TabIndex = 1;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Location = new System.Drawing.Point(210, 50);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(50, 50);
            this.btnE.TabIndex = 2;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Location = new System.Drawing.Point(265, 50);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(50, 50);
            this.btnR.TabIndex = 3;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT.Location = new System.Drawing.Point(320, 50);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(50, 50);
            this.btnT.TabIndex = 4;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnY.Location = new System.Drawing.Point(375, 50);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(50, 50);
            this.btnY.TabIndex = 5;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.Location = new System.Drawing.Point(430, 50);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(50, 50);
            this.btnU.TabIndex = 6;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // btnI
            // 
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnI.Location = new System.Drawing.Point(485, 50);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(50, 50);
            this.btnI.TabIndex = 7;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            // 
            // btnO
            // 
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO.Location = new System.Drawing.Point(540, 50);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(50, 50);
            this.btnO.TabIndex = 8;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.Location = new System.Drawing.Point(595, 50);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(50, 50);
            this.btnP.TabIndex = 9;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Location = new System.Drawing.Point(125, 105);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(50, 50);
            this.btnA.TabIndex = 10;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Location = new System.Drawing.Point(180, 105);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(50, 50);
            this.btnS.TabIndex = 11;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Location = new System.Drawing.Point(235, 105);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(50, 50);
            this.btnD.TabIndex = 12;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Location = new System.Drawing.Point(290, 105);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(50, 50);
            this.btnF.TabIndex = 13;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG.Location = new System.Drawing.Point(345, 105);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(50, 50);
            this.btnG.TabIndex = 14;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            // 
            // btnH
            // 
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnH.Location = new System.Drawing.Point(400, 105);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(50, 50);
            this.btnH.TabIndex = 15;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            this.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJ.Location = new System.Drawing.Point(455, 105);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(50, 50);
            this.btnJ.TabIndex = 16;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            // 
            // btnK
            // 
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnK.Location = new System.Drawing.Point(510, 105);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(50, 50);
            this.btnK.TabIndex = 17;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Location = new System.Drawing.Point(565, 105);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(50, 50);
            this.btnL.TabIndex = 18;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            this.btnZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ.Location = new System.Drawing.Point(150, 160);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(50, 50);
            this.btnZ.TabIndex = 19;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Location = new System.Drawing.Point(205, 160);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(50, 50);
            this.btnX.TabIndex = 20;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Location = new System.Drawing.Point(260, 160);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 21;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnV
            // 
            this.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV.Location = new System.Drawing.Point(315, 160);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(50, 50);
            this.btnV.TabIndex = 22;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Location = new System.Drawing.Point(370, 160);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(50, 50);
            this.btnB.TabIndex = 23;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN.Location = new System.Drawing.Point(425, 160);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(50, 50);
            this.btnN.TabIndex = 24;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Location = new System.Drawing.Point(480, 160);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(50, 50);
            this.btnM.TabIndex = 25;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // btnSpace
            // 
            this.btnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpace.Location = new System.Drawing.Point(200, 215);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(300, 50);
            this.btnSpace.TabIndex = 26;
            this.btnSpace.Text = "SPACE";
            this.btnSpace.UseVisualStyleBackColor = true;
            // 
            // PracticeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContent);
            this.Controls.Add(this.statsPanel);
            this.Name = "PracticeControl";
            this.Size = new System.Drawing.Size(984, 600);
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.mainContent.ResumeLayout(false);
            this.keyboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

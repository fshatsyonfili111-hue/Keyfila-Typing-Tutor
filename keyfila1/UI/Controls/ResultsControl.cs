using System;
using System.Drawing;
using System.Windows.Forms;
using keyfila1.Services;
using keyfila1.UI;

namespace keyfila1.UI.Controls
{
    public partial class ResultsControl : UserControl
    {
        private TypingStats stats;
        public event EventHandler HomeClicked;
        public event EventHandler RetryClicked;
        public event EventHandler NextClicked;
        public event EventHandler PreviousClicked;

        public ResultsControl(TypingStats stats)
        {
            InitializeComponent();
            this.stats = stats;
            DisplayResults();
            this.Load += (s, e) => {
                if (this.ParentForm != null) this.ParentForm.AcceptButton = btnNext;
                btnNext.Focus();
            };
        }

        private void DisplayResults()
        {
            this.BackColor = AppTheme.BackgroundWhite;
            
            int stars = (stats.Accuracy > 95 && stats.WPM > 40) ? 3 : (stats.Accuracy > 85 ? 2 : 1);
            lblStars.Text = new string('★', stars) + new string('☆', 3 - stars);
            
            lblStats.Text = $"WORDS PER MINUTE: {stats.WPM}\n\nACCURACY: {stats.Accuracy}%\n\nERRORS: {stats.Errors}\n\nTIME: {stats.TimeElapsed:mm\\:ss}";
            lblStats.ForeColor = AppTheme.TextDark;
        }

        private void btnHome_Click(object sender, EventArgs e) => HomeClicked?.Invoke(this, EventArgs.Empty);
        private void btnRetry_Click(object sender, EventArgs e) => RetryClicked?.Invoke(this, EventArgs.Empty);
        private void btnNext_Click(object sender, EventArgs e) => NextClicked?.Invoke(this, EventArgs.Empty);
        private void btnPrevious_Click(object sender, EventArgs e) => PreviousClicked?.Invoke(this, EventArgs.Empty);
    }
}

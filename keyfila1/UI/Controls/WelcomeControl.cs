using System;
using System.Drawing;
using System.Windows.Forms;
using keyfila1.UI;

namespace keyfila1.UI.Controls
{
    public partial class WelcomeControl : UserControl
    {
        public event EventHandler StartClicked;

        public WelcomeControl()
        {
            InitializeComponent();
            LoadBanner();
        }

        private void LoadBanner()
        {
            try
            {
                string imagePath = @"C:\Users\NATICOMS\.gemini\antigravity\brain\660aba2e-77bd-429e-ba68-bf956869fae0\keyfila_home_banner_1777755814181.png";
                if (System.IO.File.Exists(imagePath))
                {
                    picBanner.Image = Image.FromFile(imagePath);
                }
            }
            catch { /* Ignore if image cannot be loaded */ }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

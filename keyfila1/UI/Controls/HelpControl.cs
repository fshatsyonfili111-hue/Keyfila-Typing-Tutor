using System;
using System.Drawing;
using System.Windows.Forms;

namespace keyfila1.UI.Controls
{
    public partial class HelpControl : UserControl
    {
        public HelpControl()
        {
            InitializeComponent();
            PopulateHelp();
        }

        private void PopulateHelp()
        {
            txtHelp.Text = "TYPING TIPS:\r\n\r\n" +
                       "1. Keep your fingers on the Home Row (ASDF - JKL;).\r\n" +
                       "2. Look at the screen, not the keyboard.\r\n" +
                       "3. Maintain a steady rhythm rather than bursts of speed.\r\n" +
                       "4. Focus on accuracy first; speed will follow.\r\n\r\n" +
                       "FREQUENTLY ASKED QUESTIONS:\r\n\r\n" +
                       "Q: How is WPM calculated?\r\n" +
                       "A: (Total characters / 5) / minutes.\r\n\r\n" +
                       "Q: Can I change the difficulty?\r\n" +
                       "A: Yes, use the level selector to switch between Beginner, Intermediate, and Advanced.";
        }
    }
}

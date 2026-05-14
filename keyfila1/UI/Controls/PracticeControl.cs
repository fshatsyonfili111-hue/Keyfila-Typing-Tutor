using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using keyfila1.Models;
using keyfila1.Services;
using keyfila1.UI;

namespace keyfila1.UI.Controls
{
    public partial class PracticeControl : UserControl
    {
        private readonly Lesson lesson;
        private readonly TypingEngine engine;
        private readonly Dictionary<Keys, Button> keyButtons;
        private int currentIndex = 0;
        private readonly Timer updateTimer;

        public event EventHandler<TypingStats> Finished;

        public PracticeControl(Lesson lesson)
        {
            InitializeComponent();
            this.lesson = lesson;
            this.engine = new TypingEngine();
            this.keyButtons = new Dictionary<Keys, Button>();
            this.updateTimer = new Timer { Interval = 500 };
            
            SetupDesignerControls();
            
            // Ensure focus is grabbed when the control is shown
            this.Load += (s, e) => {
                this.Focus();
                rtbDisplay.Focus();
            };

            // If the user clicks anywhere in the typing area, refocus
            rtbDisplay.Click += (s, e) => {
                this.Focus();
                rtbDisplay.Focus();
            };
            
            rtbDisplay.KeyPress += (s, e) => {
                HandleCharPressed(e.KeyChar);
                e.Handled = true; // Prevent the character from appearing in the read-only box
            };

            // Also handle clicks on the main panel
            if (mainContent != null) {
                mainContent.Click += (s, e) => {
                    this.Focus();
                    rtbDisplay.Focus();
                };
            }

            StartLesson();
        }

        private void SetupDesignerControls()
        {
            this.BackColor = Color.White;
            statsPanel.BackColor = AppTheme.SecondaryBlue;
            
            // Map the buttons created in the designer to the dictionary for easy access
            keyButtons[Keys.Q] = btnQ; keyButtons[Keys.W] = btnW; keyButtons[Keys.E] = btnE;
            keyButtons[Keys.R] = btnR; keyButtons[Keys.T] = btnT; keyButtons[Keys.Y] = btnY;
            keyButtons[Keys.U] = btnU; keyButtons[Keys.I] = btnI; keyButtons[Keys.O] = btnO;
            keyButtons[Keys.P] = btnP; keyButtons[Keys.A] = btnA; keyButtons[Keys.S] = btnS;
            keyButtons[Keys.D] = btnD; keyButtons[Keys.F] = btnF; keyButtons[Keys.G] = btnG;
            keyButtons[Keys.H] = btnH; keyButtons[Keys.J] = btnJ; keyButtons[Keys.K] = btnK;
            keyButtons[Keys.L] = btnL; keyButtons[Keys.Z] = btnZ; keyButtons[Keys.X] = btnX;
            keyButtons[Keys.C] = btnC; keyButtons[Keys.V] = btnV; keyButtons[Keys.B] = btnB;
            keyButtons[Keys.N] = btnN; keyButtons[Keys.M] = btnM; keyButtons[Keys.Space] = btnSpace;

            foreach (var btn in keyButtons.Values)
            {
                btn.BackColor = Color.WhiteSmoke;
                btn.Font = AppTheme.RegularFont;
                btn.TabStop = false; // Prevent buttons from taking focus
            }

            updateTimer.Tick += (s, e) => UpdateStats();
        }

        private void StartLesson()
        {
            rtbDisplay.Text = lesson.Content;
            currentIndex = 0;
            HighlightCurrent();
            engine.Start(lesson.Content);
            updateTimer.Start();
        }

        private void HighlightCurrent()
        {
            rtbDisplay.SelectAll();
            rtbDisplay.SelectionColor = Color.Black;
            rtbDisplay.SelectionBackColor = Color.White;
            rtbDisplay.Select(0, currentIndex);
            rtbDisplay.SelectionColor = AppTheme.SuccessGreen;

            if (currentIndex < lesson.Content.Length)
            {
                rtbDisplay.Select(currentIndex, 1);
                rtbDisplay.SelectionBackColor = Color.Yellow;
                char nextChar = char.ToUpper(lesson.Content[currentIndex]);
                Keys nextKey = (nextChar == ' ') ? Keys.Space : (Keys)nextChar;
                
                ResetKeyboardColors();
                if (keyButtons.ContainsKey(nextKey))
                {
                    keyButtons[nextKey].BackColor = Color.Yellow;
                }
            }
        }

        private void ResetKeyboardColors()
        {
            foreach (var btn in keyButtons.Values) btn.BackColor = Color.WhiteSmoke;
        }

        private void HandleCharPressed(char pressedChar)
        {
            if (!engine.IsRunning || currentIndex >= lesson.Content.Length) return;

            char expectedChar = lesson.Content[currentIndex];

            // Case-insensitive comparison for better user experience, or strict? 
            // Usually tutors are strict. Let's stay strict but handle the logic.
            if (pressedChar == expectedChar)
            {
                engine.RecordKeyPress(true);
                currentIndex++;
                if (currentIndex >= lesson.Content.Length) FinishLesson();
                else HighlightCurrent();
            }
            else
            {
                engine.RecordKeyPress(false);
                // Visual feedback for error
                HighlightError();
            }
        }

        private void HighlightError()
        {
            rtbDisplay.Select(currentIndex, 1);
            rtbDisplay.SelectionBackColor = AppTheme.ErrorRed;
            rtbDisplay.SelectionColor = Color.White;
            
            // Revert after a short delay or on next key
            Timer t = new Timer { Interval = 200 };
            t.Tick += (s, e) => {
                if (currentIndex < lesson.Content.Length) HighlightCurrent();
                t.Stop();
                t.Dispose();
            };
            t.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // We still use this to highlight the visual keyboard
            Keys pressedKey = keyData & Keys.KeyCode;
            if (keyButtons.ContainsKey(pressedKey))
            {
                // Only show press if it's not the correct one (which is handled by HighlightCurrent)
                // Actually, let's just let HighlightCurrent handle the keyboard colors.
            }

            // We handle Space here too just in case KeyPress doesn't catch it on some systems
            if (keyData == Keys.Space)
            {
                // KeyPress usually handles space, so we can probably ignore this
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FinishLesson()
        {
            updateTimer.Stop();
            var stats = engine.Stop();
            Finished?.Invoke(this, stats);
        }

        private void UpdateStats()
        {
            var stats = engine.GetCurrentStats();
            lblWpm.Text = $"WPM: {stats.WPM}";
            lblAccuracy.Text = $"Accuracy: {stats.Accuracy}%";
            lblErrors.Text = $"Errors: {stats.Errors}";
            lblTime.Text = $"Time: {stats.TimeElapsed:mm\\:ss}";
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using keyfila1.Models;
using keyfila1.Services;

namespace keyfila1.UI.Controls
{
    public partial class ProgressControl : UserControl
    {
        private User currentUser;

        public ProgressControl(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            LoadUserStats();
        }

        private void LoadUserStats()
        {
            try
            {
                // Clear any existing controls in the stats panel first
                statsPanel.Controls.Clear();

                var history = UserProgressRepository.GetProgressForUser(currentUser.Id);
                
                if (history != null && history.Any())
                {
                    int avgWpm = (int)history.Average(h => h.WPM);
                    int bestWpm = history.Max(h => h.WPM);
                    double avgAccuracy = history.Average(h => h.Accuracy);
                    int totalLessons = history.Select(h => h.LessonId).Distinct().Count();

                    AddStatItem(statsPanel, "Average Speed", $"{avgWpm} WPM", 40);
                    AddStatItem(statsPanel, "Best Speed", $"{bestWpm} WPM", 100);
                    AddStatItem(statsPanel, "Average Accuracy", $"{Math.Round(avgAccuracy, 1)}%", 160);
                    AddStatItem(statsPanel, "Lessons Completed", $"{totalLessons} Lessons", 220);

                    // Add a simple list of recent sessions
                    ListBox lstHistory = new ListBox {
                        Location = new Point(450, 40),
                        Size = new Size(400, 320),
                        Font = AppTheme.RegularFont,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    foreach (var record in history.Take(15))
                    {
                        string stars = new string('★', record.Stars) + new string('☆', 3 - record.Stars);
                        lstHistory.Items.Add($"{record.CompletedAt:g} - {stars} - {record.WPM} WPM ({record.Accuracy}%)");
                    }
                    statsPanel.Controls.Add(lstHistory);
                }
                else
                {
                    Label lblNoData = new Label {
                        Text = "No practice history found for this account.\nFinish a lesson to see your progress here!",
                        Font = AppTheme.RegularFont,
                        ForeColor = Color.DimGray,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };
                    statsPanel.Controls.Add(lblNoData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading progress history: " + ex.Message, "History Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddStatItem(Panel parent, string label, string value, int y)
        {
            Label lblLabel = new Label {
                Text = label,
                Font = AppTheme.SubHeaderFont,
                ForeColor = AppTheme.TextDark,
                Location = new Point(30, y),
                AutoSize = true
            };
            Label lblValue = new Label {
                Text = value,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = AppTheme.PrimaryBlue,
                Location = new Point(30, y + 25),
                AutoSize = true
            };
            parent.Controls.Add(lblLabel);
            parent.Controls.Add(lblValue);
        }
    }
}

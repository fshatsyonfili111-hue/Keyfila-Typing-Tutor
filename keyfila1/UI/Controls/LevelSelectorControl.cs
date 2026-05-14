using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using keyfila1.Models;
using keyfila1.UI;
using keyfila1.Services;

namespace keyfila1.UI.Controls
{
    public partial class LevelSelectorControl : UserControl
    {
        private readonly User currentUser;
        private Level selectedLevel;
        public event EventHandler<Lesson> LessonSelected;

        private readonly List<Level> levels;

        public LevelSelectorControl(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            levels = LessonRepository.GetLevels();
            cmbFilter.SelectedIndex = 0; // All Lessons
            SelectLevel(levels[0]); 
        }

        private void BtnLevel_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (Enum.TryParse(btn.Text, out Difficulty diff))
            {
                Level level = levels.Find(l => l.Difficulty == diff);
                if (level != null) SelectLevel(level);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshLessonList();
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLessonList();
        }

        private void SelectLevel(Level level)
        {
            selectedLevel = level;
            foreach (Control ctrl in sidePanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    bool isActive = (btn.Text == level.Difficulty.ToString());
                    btn.BackColor = isActive ? AppTheme.ActiveBlue : Color.Transparent;
                    btn.ForeColor = isActive ? Color.White : AppTheme.TextDark;
                }
            }

            lblLevelTitle.Text = level.Difficulty + " Lessons";
            lblLevelDescription.Text = level.Description;
            UpdateProgressBar();
            RefreshLessonList();
        }

        private void UpdateProgressBar()
        {
            if (selectedLevel == null) return;
            
            int totalLessons = selectedLevel.Lessons.FindAll(l => !l.IsHeader).Count;
            if (totalLessons == 0) { levelProgressBar.Value = 0; return; }

            int completedCount = 0;
            foreach (var lesson in selectedLevel.Lessons)
            {
                if (lesson.IsHeader) continue;
                int stars = UserProgressRepository.GetBestStarsForLesson(currentUser.Id, lesson.Id);
                if (stars > 0) completedCount++;
            }

            levelProgressBar.Value = (int)((completedCount / (double)totalLessons) * 100);
            lblProgress.Text = $"Level Progress: {levelProgressBar.Value}%";
        }

        private void RefreshLessonList()
        {
            if (selectedLevel == null) return;

            lessonsFlowPanel.Controls.Clear();
            string searchText = txtSearch.Text.ToLower();
            string filter = cmbFilter.SelectedItem?.ToString() ?? "All Lessons";

            foreach (var lesson in selectedLevel.Lessons)
            {
                // If it's a header, we only show it if we aren't searching
                if (lesson.IsHeader)
                {
                    if (string.IsNullOrEmpty(searchText))
                        lessonsFlowPanel.Controls.Add(CreateLessonCard(lesson));
                    continue;
                }

                // Search Filter
                if (!string.IsNullOrEmpty(searchText) && !lesson.Title.ToLower().Contains(searchText))
                    continue;

                // Completion Filter
                int stars = UserProgressRepository.GetBestStarsForLesson(currentUser.Id, lesson.Id);
                if (filter == "Completed" && stars == 0) continue;
                if (filter == "Not Started" && stars > 0) continue;

                lessonsFlowPanel.Controls.Add(CreateLessonCard(lesson));
            }
        }

        private Panel CreateLessonCard(Lesson lesson)
        {
            if (lesson.IsHeader)
            {
                Panel headerPanel = new Panel { Size = new Size(600, 40), Margin = new Padding(0, 10, 0, 10) };
                Label lblHeader = new Label { 
                    Text = lesson.Title.ToUpper(), 
                    Font = new Font("Segoe UI", 10, FontStyle.Bold), 
                    ForeColor = Color.Gray, 
                    Location = new Point(0, 15), 
                    AutoSize = true 
                };
                headerPanel.Controls.Add(lblHeader);
                return headerPanel;
            }

            Panel p = new Panel { Size = new Size(600, 80), BackColor = Color.White, Margin = new Padding(0, 0, 0, 15) };
            p.Paint += (s, e) => {
                using (Pen pen = new Pen(AppTheme.BorderGray, 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
                }
            };

            Label lbl = new Label { 
                Text = (lesson.Id > 0 ? lesson.Id + ". " : "") + lesson.Title, 
                Font = AppTheme.SubHeaderFont, 
                Location = new Point(20, 15), 
                AutoSize = true 
            };
            p.Controls.Add(lbl);

            // Fetch and show stars
            int stars = UserProgressRepository.GetBestStarsForLesson(currentUser.Id, lesson.Id);
            Label lblStars = new Label {
                Text = new string('★', stars) + new string('☆', 3 - stars),
                Font = new Font("Segoe UI", 14),
                ForeColor = Color.Gold,
                Location = new Point(20, 40),
                AutoSize = true
            };
            p.Controls.Add(lblStars);

            Button btnAction = new Button { 
                Text = stars > 0 ? "RETRY" : "START", 
                Size = new Size(100, 40), 
                Location = new Point(480, 20), 
                FlatStyle = FlatStyle.Flat, 
                BackColor = stars > 0 ? AppTheme.ActiveBlue : AppTheme.StartOrange, 
                ForeColor = Color.White, 
                Font = AppTheme.ButtonFont
            };
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.Cursor = Cursors.Hand;
            btnAction.Click += (s, e) => LessonSelected?.Invoke(this, lesson);
            p.Controls.Add(btnAction);

            // Add Tooltip info
            toolTipInfo.SetToolTip(p, $"Lesson: {lesson.Title}\nDifficulty: {lesson.Difficulty}\nExpected WPM: {lesson.ExpectedWPM}");
            toolTipInfo.SetToolTip(lbl, $"Lesson: {lesson.Title}");
            toolTipInfo.SetToolTip(btnAction, "Click to start this lesson");

            return p;
        }
    }
}

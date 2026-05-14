using System;
using System.Drawing;
using System.Windows.Forms;
using keyfila1.UI;
using keyfila1.UI.Controls;
using keyfila1.Models;
using keyfila1.Services;

namespace keyfila1
{
    public partial class FormMain : Form
    {
        private User currentUser;

        public FormMain()
        {
            InitializeComponent();
            SetupCustomStyles();
            ShowLogin();
        }

        private void SetupCustomStyles()
        {
            this.Text = "Keyfila - Typing Tutor";
            this.BackColor = AppTheme.BackgroundWhite;
            menuPanel.BackColor = AppTheme.PrimaryBlue;
            menuPanel.Visible = false; // Hide until login
        }

        private void ShowLogin()
        {
            menuPanel.Visible = false;
            var login = new LoginControl();
            login.LoginSuccessful += (s, user) => {
                currentUser = user;
                OnLoginSuccess();
            };
            login.RegisterClicked += (s, e) => ShowRegister();
            login.ForgotPasswordClicked += (s, e) => ShowForgotPassword();
            ShowControl(login);
        }

        private void ShowRegister()
        {
            var register = new RegisterControl();
            register.RegistrationSuccessful += (s, e) => ShowLogin();
            register.LoginClicked += (s, e) => ShowLogin();
            ShowControl(register);
        }

        private void ShowForgotPassword()
        {
            var forgot = new ForgotPasswordControl();
            forgot.BackToLoginClicked += (s, e) => ShowLogin();
            ShowControl(forgot);
        }

        private void OnLoginSuccess()
        {
            menuPanel.Visible = true;
            AddMenuItems();
            ShowWelcomeScreen();
        }

        private void AddMenuItems()
        {
            menuPanel.Controls.Clear();
            // Full list of tools/menus as requested
            string[] items = { "Home", "Lessons", "Progress", "Profile", "Settings", "Help", "Contact", "Exit" };
            int x = 20;

            // Welcome user label
            Label lblUser = new Label {
                Text = $"USER: {currentUser.Username.ToUpper()}",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(x, 20),
                AutoSize = true
            };
            menuPanel.Controls.Add(lblUser);
            x += 160;

            foreach (var item in items)
            {
                Button btn = new Button();
                btn.Text = item;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, Color.White);
                btn.ForeColor = Color.White;
                btn.Font = AppTheme.ButtonFont;
                btn.Size = new Size(110, 60);
                btn.Location = new Point(x, 0);
                btn.Click += (s, e) => HandleMenuClick(item);
                menuPanel.Controls.Add(btn);
                x += 115;
            }
        }

        private void HandleMenuClick(string item)
        {
            switch (item)
            {
                case "Exit": Application.Exit(); break;
                case "Home": ShowWelcomeScreen(); break;
                case "Lessons": ShowLevelSelection(); break;
                case "Progress": ShowControl(new ProgressControl(currentUser)); break;
                case "Settings":
                    var settings = new SettingsControl(currentUser);
                    settings.UsernameChanged += (sv, ev) => AddMenuItems(); // refresh menu label
                    ShowControl(settings);
                    break;
                case "Help": ShowControl(new HelpControl()); break;
                case "Contact": ShowControl(new ContactControl()); break;
                case "Profile": ShowControl(new ProfileControl(currentUser)); break;
                default: ShowWelcomeScreen(); break;
            }
        }

        private void ShowWelcomeScreen()
        {
            var welcome = new WelcomeControl();
            welcome.StartClicked += (s, e) => ShowLevelSelection();
            ShowControl(welcome);
        }

        private void ShowLevelSelection()
        {
            var selector = new LevelSelectorControl(currentUser);
            selector.LessonSelected += (s, lesson) => StartPractice(lesson);
            ShowControl(selector);
        }

        private void StartPractice(Lesson lesson)
        {
            var practice = new PracticeControl(lesson);
            practice.Finished += (s, stats) => ShowResults(stats, lesson);
            ShowControl(practice);
        }

        private void ShowResults(TypingStats stats, Lesson lesson)
        {
            try
            {
                // Save the progress to the database for THIS user
                UserProgressRepository.SaveProgress(currentUser.Id, lesson.Id, stats);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save progress: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var results = new ResultsControl(stats);
            results.HomeClicked += (s, e) => ShowLevelSelection();
            results.RetryClicked += (s, e) => StartPractice(lesson);
            
            results.NextClicked += (s, e) => {
                var next = LessonRepository.GetNextLesson(lesson.Id);
                if (next != null) StartPractice(next);
                else ShowLevelSelection();
            };

            results.PreviousClicked += (s, e) => {
                var prev = LessonRepository.GetPreviousLesson(lesson.Id);
                if (prev != null) StartPractice(prev);
                else ShowLevelSelection();
            };

            ShowControl(results);
        }

        public void ShowControl(UserControl control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
            control.Focus();
        }
    }
}

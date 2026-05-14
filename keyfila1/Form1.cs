using System;
using System.Drawing;
using System.Windows.Forms;
using keyfila1.UI;
using keyfila1.UI.Controls;
using keyfila1.Models;
using keyfila1.Services;

namespace keyfila1
{
    public partial class Form1 : Form
    {
        private User currentUser;

        public Form1()
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
            menuPanel.Visible = false;
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
            ShowControl(login);
        }

        private void ShowRegister()
        {
            var register = new RegisterControl();
            register.RegistrationSuccessful += (s, e) => ShowLogin();
            register.LoginClicked += (s, e) => ShowLogin();
            ShowControl(register);
        }

        private void OnLoginSuccess()
        {
            menuPanel.Visible = true;
            // Update UI/Sidebar here if needed
            ShowWelcomeScreen();
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
            // Save to Database
            try
            {
                UserProgressRepository.SaveProgress(currentUser.Id, lesson.Id, stats);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save progress: " + ex.Message);
            }

            var results = new ResultsControl(stats);
            results.HomeClicked += (s, e) => ShowLevelSelection();
            results.RetryClicked += (s, e) => StartPractice(lesson);
            ShowControl(results);
        }

        public void ShowControl(UserControl control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }
    }
}

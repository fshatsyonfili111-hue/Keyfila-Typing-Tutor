using System;
using System.Drawing;
using System.Windows.Forms;
using keyfila1.Models;

namespace keyfila1.UI.Controls
{
    public partial class ProfileControl : UserControl
    {
        private User user;

        public ProfileControl(User user)
        {
            this.user = user;
            InitializeComponent();
            LoadUserData();
            btnLogout.Click += (s, e) => Application.Restart();
        }

        private void LoadUserData()
        {
            lblUsername.Text = $"Username: {user.Username}";
            lblJoined.Text = $"Member Since: {user.CreatedAt:MMMM dd, yyyy}";
        }
    }
}

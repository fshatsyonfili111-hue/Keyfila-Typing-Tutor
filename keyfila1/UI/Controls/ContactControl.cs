using System;
using System.Drawing;
using System.Windows.Forms;

namespace keyfila1.UI.Controls
{
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
            PopulateForm();
        }

        private void PopulateForm()
        {
            AddFormField(pnlForm, "Your Email:", 20);
            AddFormField(pnlForm, "Subject:", 100);
            
            Label lblMsg = new Label { Text = "Message:", Location = new Point(20, 180), AutoSize = true, Font = AppTheme.RegularFont };
            TextBox txtMsg = new TextBox { Multiline = true, Location = new Point(20, 205), Size = new Size(460, 100) };
            pnlForm.Controls.Add(lblMsg);
            pnlForm.Controls.Add(txtMsg);

            Button btnSend = new Button {
                Text = "SEND FEEDBACK",
                Location = new Point(20, 320),
                Size = new Size(460, 45),
                BackColor = AppTheme.PrimaryBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = AppTheme.ButtonFont
            };
            btnSend.FlatAppearance.BorderSize = 0;
            pnlForm.Controls.Add(btnSend);
        }

        private void AddFormField(Panel parent, string label, int y)
        {
            Label lbl = new Label { Text = label, Location = new Point(20, y), AutoSize = true, Font = AppTheme.RegularFont };
            TextBox txt = new TextBox { Location = new Point(20, y + 25), Size = new Size(460, 30) };
            parent.Controls.Add(lbl);
            parent.Controls.Add(txt);
        }
    }
}

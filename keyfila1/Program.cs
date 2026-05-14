using System;
using System.Windows.Forms;

namespace keyfila1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Auto-create database and tables if they don't exist
                Services.DatabaseService.InitializeDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if DB setup fails
            }

            Application.Run(new FormMain());
        }
    }
}

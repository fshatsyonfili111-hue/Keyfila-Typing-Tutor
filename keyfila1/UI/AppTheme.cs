using System.Drawing;

namespace keyfila1.UI
{
    public static class AppTheme
    {
        public static Color PrimaryBlue = ColorTranslator.FromHtml("#007BFF");
        public static Color SecondaryBlue = ColorTranslator.FromHtml("#E9F5FF");
        public static Color ActiveBlue = ColorTranslator.FromHtml("#2E93FF");
        public static Color StartOrange = ColorTranslator.FromHtml("#FFB800");
        public static Color SuccessGreen = ColorTranslator.FromHtml("#28A745");
        public static Color ErrorRed = ColorTranslator.FromHtml("#DC3545");
        public static Color TextDark = ColorTranslator.FromHtml("#333333");
        public static Color BackgroundWhite = Color.White;
        public static Color BorderGray = ColorTranslator.FromHtml("#DDDDDD");
        
        public static Font HeaderFont = new Font("Segoe UI", 18, FontStyle.Bold);
        public static Font SubHeaderFont = new Font("Segoe UI", 14, FontStyle.Bold);
        public static Font RegularFont = new Font("Segoe UI", 10);
        public static Font ButtonFont = new Font("Segoe UI", 10, FontStyle.Bold);
    }
}

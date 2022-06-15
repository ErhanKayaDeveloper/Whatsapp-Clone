using System;
using System.Windows.Forms;

namespace Whatsapp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Merhaba asdas
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
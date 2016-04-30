using System;
using System.Windows.Forms;

namespace CrossApp
{
    static class Program
    {
        /// <summary>
        /// Main enter in app
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

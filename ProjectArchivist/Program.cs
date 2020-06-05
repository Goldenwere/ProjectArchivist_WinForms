using System;
using System.Windows.Forms;

namespace ProjectArchivist
{
    /// <summary>
    /// Contains the main entry point for the application
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}

using System;
using System.Windows.Forms;

namespace SprintLayoutPluginDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Pass the command line arguments to the MainForm constructor
            Application.Run(new MainForm(args));
        }
    }
}

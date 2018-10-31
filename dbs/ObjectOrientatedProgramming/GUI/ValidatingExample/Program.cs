using System;
using System.Windows.Forms;

namespace dbs.ObjectOrientatedProgramming.GUI.ValidatingExample
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ValidatingExample());
        }
    }
}

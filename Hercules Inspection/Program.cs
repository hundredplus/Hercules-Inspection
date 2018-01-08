using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hercules_Inspection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Hercules_Inspector_Authentication loginForm = new Hercules_Inspector_Authentication();
            Application.Run(loginForm);

            if (loginForm.loginSuccessfull)
                Application.Run(new HerculesInspection());
        }
    }
}

using aero_quest.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Flight.InitializeFlights();

            UserControlManager newApp = new UserControlManager();
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            Application.Run(mainForm);
        }
    }
}

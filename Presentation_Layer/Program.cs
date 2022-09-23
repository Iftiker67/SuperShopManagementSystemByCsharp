using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
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
            //Application.Run(new UI.FormUI.POSTerminalForm());
            //Application.Run(new UI.FormUI.MainForm());
            Application.Run(new UI.FormUI.LoginForm());
            //Application.Run(new UI.FormUI.RegistrationForm());
            //Application.Run(new UI.PanelUI.PanelHome());
        }
    }
}

using Blood_Bank.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
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
            //Application.Run(new SingleDonReport());
            var login = new Login();
            login.ShowDialog();
            if (login.Issucced)
            {

                var dash = new Dash();
                Shared.Dash = dash;
                Shared.fromBloodGroup = dash.fromBloodGroup;
                Application.Run(dash);
            }
            else
                Application.Exit();
        }
    }
}

using HundsunExtDemo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HundsunExtDemo
{
    static class Program
    {
        public static MainController _s_mainfrmController = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginController loginController = new LoginController(new LoginForm());
            Application.Run(loginController.LoginForm);
            if (_s_mainfrmController != null)
            {
                Application.Run(_s_mainfrmController.MainForm);
            }
        }
    }
}

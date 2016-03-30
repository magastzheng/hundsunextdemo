using HundsunExtDemo.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HundsunExtDemo
{
    public partial class LoginForm : Form
    {
        private LoginController _loginController;
        public LoginController LoginController
        {
            set { _loginController = value; }
        }
        private bool _isExit = true;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, System.EventArgs e)
        {
            this.Exit();
        }

        private void ButtonLogin_Click(object sender, System.EventArgs e)
        {
            Login();
        }

        private void LoginForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Exit();
        }

        public void Login()
        {
            string userName = this.cmbOperatorNo.Text;
            string password = this.tbOperatorPwd.Text;
            Console.WriteLine("user: " + userName + " " + "Password: " + password);
            //HundsunExtDemo2 mainForm = new HundsunExtDemo2();
            //MainController mainController = new MainController(mainForm);
            //Program._s_mainfrmController = mainController;

            //this._isExit = false;
            //this.Close();
        }

        public void Exit()
        {
            if (this._isExit)
            {
                Application.Exit();
            }
        }
    }
}

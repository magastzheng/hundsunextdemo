using HundsunExtDemo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundsunExtDemo.Controller
{
    public class LoginController
    {
        private LoginForm _loginForm;
        public LoginForm LoginForm
        {
            get { return _loginForm; }
        }

        public LoginController(LoginForm loginForm)
        {
            this._loginForm = loginForm;
            this._loginForm.LoginController = this;
        }

        public int Login(string userName, string password)
        {
            

            return 0;
        }
    }
}

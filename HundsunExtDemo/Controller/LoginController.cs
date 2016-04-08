using BLL;
using HundsunExtDemo.View;
using Model;
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
        private T2SDKWrap _t2SDKWrap;
        private LoginBLL2 _loginBLL;
        public LoginForm LoginForm
        {
            get { return _loginForm; }
        }

        public T2SDKWrap T2SDKWrap
        {
            get { return _t2SDKWrap; }
        }

        public LoginController(LoginForm loginForm, T2SDKWrap t2SDKWrap)
        {
            this._t2SDKWrap = t2SDKWrap;
            this._loginBLL = new LoginBLL2(t2SDKWrap);

            this._loginForm = loginForm;
            this._loginForm.LoginController = this;
        }

        public int Login(string userName, string password)
        {

            User user = new User
            {
                Operator = userName,
                Password = password
            };

            int retCode = (int)_loginBLL.Login(user);
            if (retCode == (int)ConnectionCode.Success)
            {
                _loginBLL.QueryAccount();
                
                //_loginBLL.QueryPortfolio();
                //_loginBLL.QueryHolder();
                //_loginBLL.QueryTrading();
            }

            return retCode;
        }
    }
}

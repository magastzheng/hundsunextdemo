using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class LoginManager
    {
        private static readonly LoginManager _instance = new LoginManager();

        private User _loginUser;

        static LoginManager()
        { 
        
        }

        private LoginManager()
        { 
            
        }

        public static LoginManager Instance
        {
            get { return _instance; }
        }

        public User LoginUser
        {
            get { return _loginUser; }
            set { _loginUser = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundsunExtDemo.Controller
{
    public class MainController
    {
        private HundsunExtDemo2 _mainForm;
        public HundsunExtDemo2 MainForm
        {
            get { return _mainForm; }
        }

        public MainController(HundsunExtDemo2 mainForm)
        {
            this._mainForm = mainForm;
        }
    }
}

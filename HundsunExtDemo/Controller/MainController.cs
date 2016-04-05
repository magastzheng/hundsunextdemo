using HundsunExtDemo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundsunExtDemo.Controller
{
    public class MainController
    {
        private MainForm _mainForm;
        public MainForm MainForm
        {
            get { return _mainForm; }
        }

        public MainController(MainForm mainForm)
        {
            this._mainForm = mainForm;
        }
    }
}

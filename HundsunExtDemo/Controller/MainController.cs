using BLL;
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
        private StrategyBLL2 _strategyBLL;
        private T2SDKWrap _t2SDKWrap;
        public MainForm MainForm
        {
            get { return _mainForm; }
        }

        public StrategyBLL2 StrategyBLL
        {
            get { return _strategyBLL; }
        }

        public MainController(MainForm mainForm, T2SDKWrap t2SDKWrap)
        {
            this._t2SDKWrap = t2SDKWrap;
            this._strategyBLL = new StrategyBLL2(this._t2SDKWrap);

            ArbitrageBLL _arbBLL = new ArbitrageBLL(_t2SDKWrap);
            _arbBLL.QueryInstance();

            this._mainForm = mainForm;
            this._mainForm.MainController = this;
        }
    }
}

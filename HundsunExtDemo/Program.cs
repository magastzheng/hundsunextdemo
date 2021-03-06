﻿using BLL;
using Config;
using hundsun.t2sdk;
using HundsunExtDemo.Controller;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HundsunExtDemo.View;

namespace HundsunExtDemo
{
    static class Program
    {
        private static ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static MainController _s_mainfrmController = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //处理未捕获的异常
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            //处理UI线程异常
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            //处理非UI线程异常
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            //ConfigManager.Instance.GetTerminalConfig();
            //var config = new CT2Configinterface();
            //int iRet = config.Load("config/t2sdk.ini");

            //if (iRet != 0)
            //{
            //    string msg = "读取连接配置对象失败！";
            //    return;
            //}

            //LoginBLL loginBLL = new LoginBLL(config);

            T2SDKWrap t2SDKWrap = new T2SDKWrap();
            t2SDKWrap.Connect();
            //LoginBLL2 loginBLL = new LoginBLL2(t2SDKWrap);

            LoginController loginController = new LoginController(new LoginForm(), t2SDKWrap);
            Application.Run(loginController.LoginForm);
            if (_s_mainfrmController != null)
            {
                Application.Run(_s_mainfrmController.MainForm);
            }

            t2SDKWrap.Close();
            glExitApp = true;
        }

        static bool glExitApp = false;

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            logger.Info("CurrentDomain_UnhandledException: " + e.ExceptionObject.ToString());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            logger.Info("Application_ThreadException: " + e.Exception.Message);
        }

    }
}

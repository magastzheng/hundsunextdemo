﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAPIWrapperCSharp
{
    public class WindAPIWrap : IDisposable
    {
        private readonly static WindAPIWrap _instance = new WindAPIWrap();
        private WindAPI _windAPI = new WindAPI();

        public static WindAPIWrap Instance { get { return _instance; } }

        private WindAPIWrap()
        {
            int ret = _windAPI.start("", "", 5000);
            if (ret == 0)
            {
                Console.WriteLine("Login success!");
            }
            else
            {
                Console.WriteLine("Login fail!");
            }
        }

        public void Callback(ulong reqId, WindData wd)
        { 
            //Fill data here
            Console.WriteLine(reqId);
        }

        public void GetData(List<string> secuCodes, List<string> fields, Dictionary<string, string> options, bool updateAll)
        { 
            string strCodes = string.Join(",", secuCodes);
            string strFields = string.Join(",", fields);
            string strOptions = string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach(var kv in options)
            {
                sb.AppendFormat("{0}={1};", kv.Key, kv.Value);
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            strOptions = sb.ToString();

            WindCallback cb = new WindCallback(Callback);
            int errCode = -1;
            _windAPI.wsq(ref errCode, strCodes, strFields, strOptions, cb, updateAll);
        }

        public void Dispose()
        {
            _windAPI.stop();
        }
    }
}

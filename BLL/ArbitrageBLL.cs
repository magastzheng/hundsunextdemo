using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //套利模块
    public class ArbitrageBLL
    {
        private static ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private T2SDKWrap _t2SDKWrap;
        private ReceivedBizMsg _receivedBizMsg;

        public ArbitrageBLL(T2SDKWrap t2SDKWrap)
        {
            _t2SDKWrap = t2SDKWrap;

        }
    }
}

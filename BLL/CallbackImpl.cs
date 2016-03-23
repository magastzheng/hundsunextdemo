using hundsun.t2sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public unsafe class CallbackImpl : CT2CallbackInterface
    {
        private StrategyTradeApp _app = null;
        public CallbackImpl(StrategyTradeApp app)
        {
            _app = app;
        }

        #region Implement the interface CT2CallbackInterface
        public override void OnClose(CT2Connection lpConnection)
        {
            throw new NotImplementedException();
        }

        public override void OnConnect(CT2Connection lpConnection)
        {
            throw new NotImplementedException();
        }

        public override void OnReceivedBiz(CT2Connection lpConnection, int hSend, string lppStr, CT2UnPacker lppUnPacker, int nResult)
        {
            throw new NotImplementedException();
        }

        public override void OnReceivedBizEx(CT2Connection lpConnection, int hSend, CT2RespondData lpRetData, string lppStr, CT2UnPacker lppUnPacker, int nResult)
        {
            throw new NotImplementedException();
        }

        public override void OnReceivedBizMsg(CT2Connection lpConnection, int hSend, CT2BizMessage lpMsg)
        {
            throw new NotImplementedException();
        }

        public override void OnRegister(CT2Connection lpConnection)
        {
            throw new NotImplementedException();
        }

        public override void OnSafeConnect(CT2Connection lpConnection)
        {
            throw new NotImplementedException();
        }

        public override void OnSent(CT2Connection lpConnection, int hSend, void* lpData, int nLength, int nQueuingData)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

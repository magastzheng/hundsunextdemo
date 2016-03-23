using hundsun.t2sdk;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public enum ConnectionCode
    { 
        Success = 0,
        ErrorReadConf = -1,
        ErrorInitConn = -2,
        ErrorConn = -3,
    }

    public class StrategyTradeApp
    {
        private CT2Configinterface _config = null;
        private CT2Connection _conn = null;
        private uint _timeOut = 4000;

        public StrategyTradeApp()
        { 
        }

        public ConnectionCode Init()
        {
            ///新建连接
            _config = new CT2Configinterface();
            int iRet = _config.Load("config/t2sdk.ini");

            if (iRet != 0)
            {
                Console.WriteLine("读取连接配置对象失败！");
                return ConnectionCode.ErrorReadConf;
            }

            _conn = new CT2Connection(_config);
            CallbackImpl callbackImpl = new CallbackImpl(this);

            iRet = _conn.Create2BizMsg(callbackImpl);
            if (iRet != 0)
            {
                Console.WriteLine("连接对象初始化失败: {0}, {1}", iRet, _conn.GetErrorMsg(iRet));
                return ConnectionCode.ErrorInitConn;
            }

            iRet = _conn.Connect(_timeOut);
            if (iRet != 0)
            {
                Console.WriteLine("连接失败: {0}, {1}", iRet, _conn.GetErrorMsg(iRet));
                return ConnectionCode.ErrorConn;
            }
            else
            {
                Console.WriteLine("连接成功");
            }

            return ConnectionCode.Success;
        }

        public ConnectionCode Login(User user)
        {
            CT2BizMessage bizMessage = new CT2BizMessage();
            //初始化
            //bizMessage.SetFunction((int)FunctionCode.Login);
            bizMessage.SetPacketType(CT2tag_def.REQUEST_PACKET);

            //业务包
            CT2Packer packer = new CT2Packer(2);
            packer.BeginPack();
            //packer.AddField("", )

            return ConnectionCode.Success;
        }
    }
}

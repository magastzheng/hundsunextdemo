using Config;
using hundsun.t2sdk;
using log4net;
using Model;
using Model.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL2
    {
        private static ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private T2SDKWrap _t2SDKWrap;
        private ReceivedBizMsg _receivedBizMsg;

        public LoginBLL2(T2SDKWrap t2SDKWrap)
        {
            _t2SDKWrap = t2SDKWrap;
            _receivedBizMsg = OnReceivedBizMsg;
            _t2SDKWrap.Register(FunctionCode.Login, _receivedBizMsg);
            _t2SDKWrap.Register(FunctionCode.Logout, _receivedBizMsg);
            _t2SDKWrap.Register(FunctionCode.HeartBeat, _receivedBizMsg);
        }

        public ConnectionCode Login(User user)
        {
            FunctionItem functionItem = ConfigManager.Instance.GetFunctionConfig().GetFunctionItem(FunctionCode.Login);
            if (functionItem == null || functionItem.RequestFields == null || functionItem.RequestFields.Count == 0)
            {
                return ConnectionCode.ErrorLogin;
            }
            CT2BizMessage bizMessage = new CT2BizMessage();
            //初始化
            bizMessage.SetFunction((int)FunctionCode.Login);
            bizMessage.SetPacketType(CT2tag_def.REQUEST_PACKET);

            //业务包
            CT2Packer packer = new CT2Packer(2);
            packer.BeginPack();
            foreach (FieldItem item in functionItem.RequestFields)
            {
                packer.AddField(item.Name, item.Type, item.Width, item.Scale);
            }

            foreach (FieldItem item in functionItem.RequestFields)
            {
                switch (item.Name)
                {
                    case "operator_no":
                        packer.AddStr(user.Operator);
                        break;
                    case "password":
                        packer.AddStr(user.Password);
                        break;
                    case "mac_address":
                        {
                            packer.AddStr(ConfigManager.Instance.GetTerminalConfig().MacAddress);
                        }
                        break;
                    case "op_station":
                        {
                            packer.AddStr("www.htsec.com");
                        }
                        break;
                    case "ip_address":
                        {
                            packer.AddStr(ConfigManager.Instance.GetTerminalConfig().IPAddress);
                        }
                        break;
                    case "hd_volserial":
                        {
                            packer.AddStr("");
                        }
                        break;
                    case "authorization_id":
                        {
                            //TODO:
                            packer.AddStr("authorization_id");
                        }
                        break;
                    default:
                        if (item.Type == PackFieldType.IntType)
                        {
                            packer.AddInt(-1);
                        }
                        else if (item.Type == PackFieldType.StringType || item.Type == PackFieldType.CharType)
                        {
                            packer.AddStr(item.Name);
                        }
                        else
                        {
                            packer.AddStr(item.Name);
                        }
                        break;
                }
            }
            packer.EndPack();

            unsafe
            {
                bizMessage.SetContent(packer.GetPackBuf(), packer.GetPackLen());
            }

            int retCode = _t2SDKWrap.SendSync(bizMessage);
            packer.Dispose();
            bizMessage.Dispose();

            if (retCode < 0)
            {
                logger.Error("登录失败!");
                return ConnectionCode.ErrorConn;
            }

            return ConnectionCode.Success;
        }

        public ConnectionCode Logout()
        {
      
            FunctionItem functionItem = ConfigManager.Instance.GetFunctionConfig().GetFunctionItem(FunctionCode.Logout);
            if (functionItem == null || functionItem.RequestFields == null || functionItem.RequestFields.Count == 0)
            {
                return ConnectionCode.ErrorLogin;
            }

            CT2BizMessage bizMessage = new CT2BizMessage();
            //初始化
            bizMessage.SetFunction((int)FunctionCode.Logout);
            bizMessage.SetPacketType(CT2tag_def.REQUEST_PACKET);

            //业务包
            CT2Packer packer = new CT2Packer(2);
            packer.BeginPack();
            foreach (FieldItem item in functionItem.RequestFields)
            {
                packer.AddField(item.Name, item.Type, item.Width, item.Scale);
            }

            foreach (FieldItem item in functionItem.RequestFields)
            {
                switch (item.Name)
                {
                    case "user_token":
                        packer.AddStr(LoginManager.Instance.LoginUser.Token);
                        break;
                    default:
                        break;
                }
            }


            unsafe
            {
                bizMessage.SetContent(packer.GetPackBuf(), packer.GetPackLen());
            }

            int retCode = _t2SDKWrap.SendSync(bizMessage);
            packer.Dispose();
            bizMessage.Dispose();

            if (retCode < 0)
            {
                logger.Error("退出登录失败!");
                return ConnectionCode.ErrorConn;
            }

            return ConnectionCode.Success;
        }

        public ConnectionCode HeartBeat()
        {
            FunctionItem functionItem = ConfigManager.Instance.GetFunctionConfig().GetFunctionItem(FunctionCode.HeartBeat);
            if (functionItem == null || functionItem.RequestFields == null || functionItem.RequestFields.Count == 0)
            {
                return ConnectionCode.ErrorLogin;
            }

            CT2BizMessage bizMessage = new CT2BizMessage();
            //初始化
            bizMessage.SetFunction((int)FunctionCode.HeartBeat);
            bizMessage.SetPacketType(CT2tag_def.REQUEST_PACKET);

            //业务包
            CT2Packer packer = new CT2Packer(2);
            packer.BeginPack();
            foreach (FieldItem item in functionItem.RequestFields)
            {
                packer.AddField(item.Name, item.Type, item.Width, item.Scale);
            }

            foreach (FieldItem item in functionItem.RequestFields)
            {
                switch (item.Name)
                {
                    case "user_token":
                        packer.AddStr(LoginManager.Instance.LoginUser.Token);
                        break;
                    default:
                        break;
                }
            }

            unsafe
            {
                bizMessage.SetContent(packer.GetPackBuf(), packer.GetPackLen());
            }

            int retCode = _t2SDKWrap.SendSync(bizMessage);
            packer.Dispose();
            bizMessage.Dispose();

            if (retCode < 0)
            {
                logger.Error("心跳检测失败");

                return ConnectionCode.ErrorConn;
            }

            return ConnectionCode.Success;
        }

        public int OnReceivedBizMsg(CT2BizMessage bizMessage)
        {
            int iRetCode = bizMessage.GetReturnCode();
            int iErrorCode = bizMessage.GetErrorNo();
            int iFunction = bizMessage.GetFunction();
            if (iRetCode != 0)
            {
                string msg = string.Format("同步接收数据出错： {0}, {1}", iErrorCode, bizMessage.GetErrorInfo());

                return iRetCode;
            }

            CT2UnPacker unpacker = null;
            unsafe
            {
                int iLen = 0;
                void* lpdata = bizMessage.GetContent(&iLen);
                unpacker = new CT2UnPacker(lpdata, (uint)iLen);
            }

            if (unpacker != null)
            {
                _t2SDKWrap.PrintUnPack(unpacker);
                switch ((FunctionCode)iFunction)
                {
                    case FunctionCode.Login:
                        {
                            var token = unpacker.GetStr("user_token");
                            if (!string.IsNullOrEmpty(token))
                            {
                                LoginManager.Instance.LoginUser.Token = token;
                            }
                            else
                            {
                                return (int)ConnectionCode.ErrorLogin;
                            }
                        }
                        break;
                    case FunctionCode.Logout:
                        break;
                    case FunctionCode.HeartBeat:
                        break;
                    default:
                        break;
                }

                unpacker.Dispose();
            }
            //bizMessage.Dispose();

            return (int)ConnectionCode.Success;
        }
    }
}

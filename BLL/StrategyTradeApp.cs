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
    public enum ConnectionCode
    { 
        Success = 0,
        ErrorReadConf = -1,
        ErrorInitConn = -2,
        ErrorConn = -3,
        ErrorSendMsg = -4,

        ErrorLogin = -10001,
    }

    public class StrategyTradeApp
    {
        private static ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
                string msg = "读取连接配置对象失败！";
                logger.Error(msg);
                return ConnectionCode.ErrorReadConf;
            }

            _conn = new CT2Connection(_config);
            CallbackImpl callbackImpl = new CallbackImpl(this);

            iRet = _conn.Create2BizMsg(callbackImpl);
            if (iRet != 0)
            {
                string msg = string.Format("连接对象初始化失败: {0}, {1}", iRet, _conn.GetErrorMsg(iRet));
                logger.Error(msg);
                return ConnectionCode.ErrorInitConn;
            }

            iRet = _conn.Connect(_timeOut);
            if (iRet != 0)
            {
                string msg = string.Format("连接失败: {0}, {1}", iRet, _conn.GetErrorMsg(iRet));
                logger.Error(msg);
                return ConnectionCode.ErrorConn;
            }
            else
            {
                string msg = "连接成功";
                logger.Info(msg);
            }

            return ConnectionCode.Success;
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
                            packer.AddStr(LoginInfoManager.Instance.MacAddress);
                        }
                        break;
                    case "op_station":
                        { 
                            //TODO:
                        }
                        break;
                    case "ip_address":
                        {
                            packer.AddStr(LoginInfoManager.Instance.IPAddress);
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
                        }
                        break;
                    default:
                        break;
                }

                //switch (item.Type)
                //{
                //    //case PackFieldType.IntType:
                //    //    packer.AddInt();
                //    //    break;
                //    //case PackFieldType.FloatType:
                //    //    packer.AddDouble();
                //    //    break;
                //    //case PackFieldType.StringType:
                //    //    packer.AddStr();
                //    //    break;
                //    //case PackFieldType.BinaryType:
                //    //    packer.AddRaw();
                //    //    break;
                //    default:
                //        string msg = string.Format("The packer field type {0} is not support", item.Type);
                //        throw new NotSupportedException(msg);
                //}
            }

            unsafe
            {
                bizMessage.SetContent(packer.GetPackBuf(), packer.GetPackLen());
            }

            ConnectionCode retCode = SendSync(bizMessage);
            if(retCode != ConnectionCode.Success){
                logger.Error("登录失败！");
            }

            packer.Dispose();
            bizMessage.Dispose();

            return retCode;
        }

        public ConnectionCode SendAsync(CT2BizMessage message)
        {
            int iRet = _conn.SendBizMsg(message, 1);
            if(iRet < 0)
            {
                logger.Error(string.Format("异步发送数据失败！ 错误码：{0}, 错误消息：{1}",iRet, _conn.GetErrorMsg(iRet)));
                return ConnectionCode.ErrorSendMsg;
            }

            return ConnectionCode.Success;
        }

        public ConnectionCode SendSync(CT2BizMessage message)
        {
            int iRet = _conn.SendBizMsg(message, 0);
            if (iRet < 0)
            {
                logger.Error(string.Format("同步发送数据失败！ 错误码：{0}, 错误消息：{1}", iRet, _conn.GetErrorMsg(iRet)));
                return ConnectionCode.ErrorSendMsg;
            }

            return ConnectionCode.Success;
        }
    }
}

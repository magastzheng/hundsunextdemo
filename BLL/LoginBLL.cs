﻿using Config;
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
   
    public class LoginBLL : T2SDKBase
    {
        private static ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LoginBLL(CT2Configinterface config)
            :base(config)
        {

        }

        public ConnectionCode Login(User user)
        {
            if (!_isInit)
            {
                var retCon = Init();
                if (retCon != ConnectionCode.Success)
                    return retCon;
            }

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

            //CT2Packer packer = new CT2Packer(2);
            //sbyte strType = Convert.ToSByte('S');
            //sbyte intType = Convert.ToSByte('I');
            //sbyte charType = Convert.ToSByte('B');

            //packer.BeginPack();
            //packer.AddField("operator_no", strType, 16, 4);
            //packer.AddField("password", strType, 16, 4);
            //packer.AddField("mac_address", strType, 32, 4);
            //packer.AddField("ip_address", strType, 32, 4);
            //packer.AddField("op_station", strType, 255, 4);
            //packer.AddField("authorization_id", strType, 64, 4);
            //packer.AddField("login_time", intType, 6, 4);
            //packer.AddField("verification_code", strType, 32, 4);
            //packer.AddField("hd_volserial", strType, 10, 4);

            //packer.AddStr("10099");
            //packer.AddStr("0");
            //packer.AddStr("48-0F-CF-3E-41-20");
            //packer.AddStr("176.1.1.154");
            //packer.AddStr("www.htsec.com");
            //packer.AddStr("10000014");
            //packer.AddInt(-1);
            //packer.AddStr("2");
            //packer.AddStr("2ccc");


            //packer.EndPack();

            unsafe
            {
                bizMessage.SetContent(packer.GetPackBuf(), packer.GetPackLen());
            }

            int retCode = SendSync(bizMessage);
            packer.Dispose();
            bizMessage.Dispose();
            if (retCode < 0)
            {
                logger.Error("登录失败:" + _conn.GetErrorMsg(retCode));
                return ConnectionCode.ErrorConn;
            }

            return ReceivedBizMsg(retCode, FunctionCode.Login);
        }

        public ConnectionCode Logout()
        {
            if (!_isInit)
            {
                var retCon = Init();
                if (retCon != ConnectionCode.Success)
                    return retCon;
            }

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

            int retCode = SendSync(bizMessage);
            

            if (retCode < 0)
            {
                logger.Error("退出登录失败:" + _conn.GetErrorMsg(retCode));
                return ConnectionCode.ErrorConn;
            }

            var retConnCode = ReceivedBizMsg(retCode, FunctionCode.Logout);
            packer.Dispose();
            bizMessage.Dispose();

            return retConnCode;
        }

        public ConnectionCode ReceivedBizMsg(int hSend, FunctionCode functionCode)
        {
            CT2BizMessage bizMessage = null;
            int retCode = _conn.RecvBizMsg(hSend, out bizMessage, (int)_timeOut, 1);
            if (retCode < 0)
            {
                logger.Error("同步接收出错: " + _conn.GetErrorMsg(retCode));
                return ConnectionCode.ErrorConn;
            }

            int iRetCode = bizMessage.GetReturnCode();
            int iErrorCode = bizMessage.GetErrorNo();
            if (iRetCode != 0)
            {
                string msg = string.Format("同步接收数据出错： {0}, {1}", iErrorCode, bizMessage.GetErrorInfo());

                return ConnectionCode.ErrorConn;
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
                PrintUnPack(unpacker);
                switch (functionCode)
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
                                return ConnectionCode.ErrorLogin;
                            }
                        }
                        break;
                    case FunctionCode.Logout:
                        break;
                    default:
                        break;
                }

                unpacker.Dispose();
            }
            //bizMessage.Dispose();

            return ConnectionCode.Success;
        }

        public override void OnReceivedBizMsg(CT2Connection lpConnection, int hSend, CT2BizMessage lpMsg)
        {
            logger.Info("OnReceivedBizMsg: 接收业务数据！");

            //获取返回码
            int iRetCode = lpMsg.GetReturnCode();

            //获取错误码
            int iErrorCode = lpMsg.GetErrorNo();

            int iFunction = lpMsg.GetFunction();

            if (iRetCode != 0)
            {
                logger.Error("异步接收数据出错：" + lpMsg.GetErrorNo().ToString() + lpMsg.GetErrorInfo());
            }
            else
            {
                CT2UnPacker unpacker = null;
                unsafe
                {
                    int iLen = 0;
                    void* lpdata = lpMsg.GetContent(&iLen);
                    unpacker = new CT2UnPacker(lpdata, (uint)iLen);
                }

                switch (iFunction)
                {
                    case (int)FunctionCode.Login:
                        {
                            var token = unpacker.GetStr("user_token");
                            if (string.IsNullOrEmpty(token))
                            {
                                LoginManager.Instance.LoginUser.Token = token;
                            }
                        }
                        break;
                    case (int)FunctionCode.Logout:
                        break;
                    default:
                        break;
                }

                PrintUnPack(unpacker);
                unpacker.Dispose();
            }
            
            lpMsg.Dispose();
        }
    }
}

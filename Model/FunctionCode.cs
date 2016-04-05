﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum FunctionCode
    {
        //心跳
        HeartBeat = 10000,

        //登录
        Login = 10001,

        //退出登录
        Logout = 10002,

        //组合查询
        QueryPortfolio = 30003,

        //组合持仓查询
        QueryHolding = 35001,

        //沪深交易所资金查询
        QueryMoney = 35004,

        //可用期货保证金查询
        QueryFutureMargin = 35005,

        //当日委托查询
        QueryEntrust = 35006,

        //当日成交查询
        QueryDeal = 35007,

        //期权可用保证金查询
        QueryOptionMargin = 35008,

        //策略 交易实例查询
        QueryTradingInstance = 71002,

        //策略 账户组资金查询
        QueryAccountGroupMoney = 71003,


        //策略 实例篮子委托
        EntrustInstanceBasket = 71005,

        //策略 实例委托查询
        QueryEntrustInstance = 71006,

        //策略 实例成交查询
        QueryDealInstance = 71007,
        

        //沪深竞价系统委托
        Entrust = 91001,

        //沪深ETF基金申赎委托
        EntrustETF = 91003,

        //期货委托
        EntrustFutures = 91004,

        //篮子委托
        EntrustBasket = 91090,  

        //个股期权篮子委托
        EntrustStockOptionBasket = 91091,

        //委托撤销
        Withdraw = 91101,

        //撤销篮子委托
        WithdrawBasket = 91102,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.strategy
{
    public class TradingInstance
    {
        //交易实例编号
        public int InstanceNo { get; set; }

        //账户组代码
        public string AccountGroupCode { get; set; }

        //交易实例类型
        public string InstanceType { get; set; }

        //操作份数
        public int OperateNum { get; set; }

        //创建日期
        public string CreateDate { get; set; }    

        //外部方案号
        public string ExtInvestPlanNo { get; set; }
    }
}

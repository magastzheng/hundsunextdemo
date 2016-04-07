using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote
{
    public class Quote
    {
        private Dictionary<string, MarketData> _marketDatas = new Dictionary<string, MarketData>();
        public Dictionary<string, MarketData> MarketDatas { get { return _marketDatas; } }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BuySellOption
    {
        public List<BuySellItem> SpotBuy { get; set; }
        public List<BuySellItem> SpotSell { get; set; }
        public List<BuySellItem> FutureBuy { get; set; }
        public List<BuySellItem> FutureSell { get; set; }
    }
}

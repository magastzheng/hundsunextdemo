using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class BuySellConfig
    {
        private const string FileName = "uiconfig.json";

        private BuySellOption _buySellOption;
        public BuySellOption BuySellOption { get { return _buySellOption; } }

        public BuySellConfig()
        {  
        }

        public int Init()
        {
            string filePath = RuntimeEnv.Instance.GetConfigFile(FileName);
            string content = FileUtil.ReadFile(filePath);
            _buySellOption = JsonConvert.DeserializeObject<BuySellOption>(content);

            return 0;
        }
    }
}

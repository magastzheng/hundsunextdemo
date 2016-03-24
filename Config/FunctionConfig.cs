using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class FunctionConfig
    {
        private const string FileName = "function.json";
        private Functions functions = null;
        public Functions Functions { get { return functions; } }

        public FunctionConfig()
        { 
        
        }

        public int Init()
        {
            string filePath = RuntimeEnv.Instance.GetConfigFile(FileName);
            string content = FileUtil.ReadFile(filePath);
            functions = JsonConvert.DeserializeObject<Functions>(content);

            return 0;
        }
    }
}

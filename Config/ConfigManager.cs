using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class ConfigManager
    {
        private readonly static ConfigManager _instance = new ConfigManager();

        private BuySellConfig _buySellConfig;
        private FunctionConfig _functionConfig;
        private SystemConfig _systemConfig;
        private TerminalConfig _terminalConfig;
        private GridConfig _gridConfig;

        private ConfigManager()
        {
            Init();
        }

        static ConfigManager()
        { 
        
        }

        private int Init()
        {
            _buySellConfig = new BuySellConfig();
            _functionConfig = new FunctionConfig();
            _systemConfig = new SystemConfig();
            _terminalConfig = new TerminalConfig(_systemConfig);
            _gridConfig = new GridConfig();

            //_buySellConfig.Init();
            //_functionConfig.Init();

            return 0;
        }

        public static ConfigManager Instance { get { return _instance; } }

        public BuySellConfig GetBuySellConfig()
        {
            return _instance._buySellConfig;
        }

        public FunctionConfig GetFunctionConfig()
        {
            return _instance._functionConfig;
        }

        public SystemConfig GetSystemConfig()
        {
            return _instance._systemConfig;
        }

        public TerminalConfig GetTerminalConfig()
        {
            return _instance._terminalConfig;
        }

        public GridConfig GetGridConfig()
        {
            return _instance._gridConfig;
        }
    }
}

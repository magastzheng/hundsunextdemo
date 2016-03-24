using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FunctionParamItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Require { get; set; }
    }

    public class FunctionResponseItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class FunctionItem {
        public int Code { get; set; }
        public List<FunctionParamItem> Param { get; set; }
        public List<FunctionResponseItem> Response { get; set; }
    }

    public class Functions {
        public List<FunctionItem> Function { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PackFieldType
    {
        public readonly sbyte IntType = Convert.ToSByte('I');
        public readonly sbyte FloatType = Convert.ToSByte('F');
        public readonly sbyte CharType = Convert.ToSByte('C');
        public readonly sbyte StringType = Convert.ToSByte('S');
        public readonly sbyte BinaryType = Convert.ToSByte('R');
    }
}

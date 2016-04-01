using hundsun.t2sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DataParser
    {
        //private List<UICo>
        public void Parse(CT2UnPacker lpUnPack)
        {
            Console.WriteLine("记录行数： {0}", lpUnPack.GetRowCount());
            Console.WriteLine("列行数：{0}", lpUnPack.GetColCount());

            for (int i = 0; i < lpUnPack.GetDatasetCount(); i++)
            {
                //设置当前结果集
                lpUnPack.SetCurrentDatasetByIndex(i);

                //打印字段
                for (int j = 0; j < lpUnPack.GetColCount(); j++)
                {
                    Console.Write("{0,20:G}", lpUnPack.GetColName(j));
                }

                Console.WriteLine();

                //打印所有记录
                for (int k = 0; k < lpUnPack.GetRowCount(); k++)
                {
                    //打印每条记录
                    for (int t = 0; t < lpUnPack.GetColCount(); t++)
                    {
                        switch (lpUnPack.GetColType(t))
                        {
                            case (sbyte)'I':  //I 整数
                                Console.Write("{0,20:D}", lpUnPack.GetIntByIndex(t));
                                break;
                            case (sbyte)'C':  //C 
                                Console.Write("{0,20:G}", (char)lpUnPack.GetCharByIndex(t));
                                break;
                            case (sbyte)'S':   //S
                                Console.Write("{0,20:G}", lpUnPack.GetStrByIndex(t));
                                break;
                            case (sbyte)'F':  //F
                                Console.Write("{0,20:F2}", lpUnPack.GetDoubleByIndex(t));
                                break;
                            case (sbyte)'R':  //R
                                {
                                    break;
                                }
                            default:
                                // 未知数据类型
                                Console.Write("未知数据类型\n");
                                break;
                        }
                    }

                    Console.WriteLine();
                    lpUnPack.Next();
                }
            }

            Console.WriteLine();


            /*
            while (lpUnPack.IsEOF() != 1)
            {
                for (int i = 0; i < lpUnPack.GetColCount(); i++)
                {
                    String colName = lpUnPack.GetColName(i);
                    sbyte colType = lpUnPack.GetColType(i);
                    if (!colType.Equals('R'))
                    {
                        String colValue = lpUnPack.GetStrByIndex(i);
                        Console.WriteLine("{0}：{1}", colName, colValue);
                    }
                    else
                    {
                        int colLength = 0;
                        unsafe
                        {
                            void* colValue = (char*)lpUnPack.GetRawByIndex(i, &colLength);
                            string str = String.Format("{0}:[{1}]({2})", colName, Marshal.PtrToStringAuto(new IntPtr(colValue)), colLength);
                        }
                    }
                }
                lpUnPack.Next();
            }
            */

        }
    }
}

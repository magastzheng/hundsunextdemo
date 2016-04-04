using hundsun.t2sdk;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    
    public class DataParser
    {
        private List<DataSet> _dataSets = new List<DataSet>();

        public List<DataSet> DataSets
        {
            get { return _dataSets; }
        }

        public void Parse(CT2UnPacker lpUnPack)
        {
            Console.WriteLine("记录行数： {0}", lpUnPack.GetRowCount());
            Console.WriteLine("列行数：{0}", lpUnPack.GetColCount());

            for (int i = 0; i < lpUnPack.GetDatasetCount(); i++)
            {
                DataSet dataSet = new DataSet();
                dataSet.Rows = new List<DataRow>();
                //设置当前结果集
                lpUnPack.SetCurrentDatasetByIndex(i);

                Dictionary<int, string> columnDic = new Dictionary<int, string>();
                //打印字段
                for (int j = 0; j < lpUnPack.GetColCount(); j++)
                {
                    columnDic.Add(j, lpUnPack.GetColName(j));
                }

                Console.WriteLine();

                //打印所有记录
                for (int k = 0; k < lpUnPack.GetRowCount(); k++)
                {
                    DataRow row = new DataRow();
                    row.Columns = new Dictionary<string,DataValue>();

                    //打印每条记录
                    for (int t = 0; t < lpUnPack.GetColCount(); t++)
                    {
                        string colName = columnDic[t];
                        switch (lpUnPack.GetColType(t))
                        {
                            case (sbyte)'I':  //I 整数
                                {
                                    DataValue dataValue = new DataValue 
                                    {
                                        Type = DataValueType.Int,
                                        Value = lpUnPack.GetIntByIndex(t)
                                    };


                                    row.Columns.Add(colName, dataValue);
                                }
                                break;
                            case (sbyte)'C':  //C 
                                {
                                    DataValue dataValue = new DataValue
                                    {
                                        Type = DataValueType.Char,
                                        Value = lpUnPack.GetCharByIndex(t)
                                    };


                                    row.Columns.Add(colName, dataValue);
                                }
                                break;
                            case (sbyte)'S':   //S
                                {
                                    DataValue dataValue = new DataValue
                                    {
                                        Type = DataValueType.String,
                                        Value = lpUnPack.GetStrByIndex(t)
                                    };


                                    row.Columns.Add(colName, dataValue);
                                }
                                break;
                            case (sbyte)'F':  //F
                                {
                                    DataValue dataValue = new DataValue
                                    {
                                        Type = DataValueType.Float,
                                        Value = lpUnPack.GetDoubleByIndex(t)
                                    };


                                    row.Columns.Add(colName, dataValue);
                                }
                                break;
                            case (sbyte)'R':  //R
                                {
                                    break;
                                }
                            default:
                                // 未知数据类型
                                break;
                        }
                    }//end to read all column for each row

                    dataSet.Rows.Add(row);

                    Console.WriteLine();
                    lpUnPack.Next();
                }//end to read rows

                _dataSets.Add(dataSet);
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

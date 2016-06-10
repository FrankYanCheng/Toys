using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolLibrary.StringTool;
using FileReaderLibrary;

namespace FormTool.MonthSave
{
    /// <summary>
    /// 库存管理写入基类
    /// </summary>
    class MSWriter
    {
        /// <summary>
        /// 初始化库存写入基类
        /// </summary>
        /// <param name="Muru">目录</param>
        /// <param name="ProductName">产品名称</param>
        /// <param name="time">时间信息</param>
        public MSWriter(string Muru, string ProductName, string time,int Count)
        {
            GetTime g = new GetTime(time);
            string year = g.GetYear();//获取详细时间信息
            string month = g.GetMonth();
            string txt = Muru + "-" + ProductName + "-" + "库存" + "*" + Count;
            try
            {

                FileWriter write = new FileWriter("MSsystem" + @"\" + year + @"\" + month + @"\", txt, Muru+"-"+ProductName);

            }
            catch
            {

               

            }
        }

    }
}

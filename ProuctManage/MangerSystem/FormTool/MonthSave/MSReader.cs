using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileReaderLibrary;
using ToolLibrary.StringTool;
using ToolLibrary.ManagerHeart;
using System.Windows.Forms;
using FormTool.AddNew;
namespace FormTool.MonthSave
{
    /// <summary>
    /// 库存读取类
    /// </summary>
   public class MSReader
    {
      
       public int count;
       /// <summary>
       /// 基类初始化，查询时间目录对应的产品
       /// </summary>
       /// <param name="time"></param>
       /// <param name="Muru"></param>
       /// <param name="ProductName"></param>
       public MSReader(string time,string Muru,string ProductName)
       {
           try
           {
               MSFundation fun = new MSFundation(time);
               FileReader reader = new FileReader();
               GetTime timer = new GetTime(time);
               string year = timer.GetYear();
               string month = timer.GetMonth();
               string[]z=reader.SecurityReader(Muru+"-"+ProductName, "MSsystem" + @"\" + year + @"\" + month + @"\");
               KCDetective de = new KCDetective(z[0]);
               count = de.Count;
           }
           catch
           {
           }
       }
       public Dictionary<string, int> MSYearsReader = new Dictionary<string, int>();
       /// <summary>
       /// 读取年份库存信息
       /// </summary>
       /// <param name="time">时间</param>
       /// <param name="Muru">目录</param>
       /// <param name="ProductName">产品名</param>
       /// <param name="enu">枚举量，是否为年份查询</param>
       /// <param name="progressbar1">进度条</param>
       public MSReader(string time, string Muru, string ProductName, MSManagerEnum enu,ProgressBar progressbar1)
       {
           if (enu == MSManagerEnum.years)
           {
               progressbar1.Maximum = 12;
               progressbar1.Minimum = 0;
               GetTime g = new GetTime(time);
               string year = g.GetYear();//获取查询年份
               for (int i = 1; i < 13; i++)
               {
                   MSReader reader = new MSReader(year + i + "月"+i+"日", Muru, ProductName);
                    MSYearsReader.Add(Muru+"-"+ProductName+i+"月",reader.count);
                    progressbar1.Value++;
               }
           }
       }
       /// <summary>
       /// 库存量读取（目录读取模式）
       /// </summary>
       /// <param name="time">时间信息</param>
       /// <param name="Muru">目录</param>
       /// <param name="enu">年月枚举</param>
       /// <param name="progressbar1">进度条</param>
       public MSReader(string time, string Muru, MSManagerEnum enu, ProgressBar progressbar1)
       {
           try
           {
               if (enu == MSManagerEnum.years)
               {
                   ReaderFundation read = new ReaderFundation(Muru);//获取产品信息
                   string[] Pro = read.writer;//对应目录下的产品信息
                   progressbar1.Maximum = 12 * Pro.Length;
                   progressbar1.Minimum = 0;
                   GetTime g = new GetTime(time);
                   string year = g.GetYear();//获取查询年份
                   for (int i = 1; i < 13; i++)
                   {
                       for (int k = 0; k < Pro.Length; k++)
                       {
                           MSReader reader = new MSReader(year + i + "月" + i + "日", Muru, Pro[k]);
                           MSYearsReader.Add(Muru + "-" + Pro[k] + i + "月", reader.count);
                           progressbar1.Value++;
                       }
                   }

               }
           }
           catch
           {
           }
       }
    }

}

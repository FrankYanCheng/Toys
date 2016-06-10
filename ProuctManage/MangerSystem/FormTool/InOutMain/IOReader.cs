using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileReaderLibrary;
using ToolLibrary.StringTool;
using ToolLibrary.ManagerHeart;
using System.Windows.Forms;
using FormTool.AddNew;
namespace FormTool.InOutMain
{
   public class IOReader
    {
       public string []txt;
       /// <summary>
       /// 文件读取基类
       /// </summary>
       /// <param name="time">时间信息</param>
       public IOReader(string time)
      {
          try
          {
              FileReader reader = new FileReader();
              GetTime timer = new GetTime(time);
              string year = timer.GetYear();
              string day = timer.GetDay();
              string month = timer.GetMonth();
              txt = reader.SecurityReader(day, "IOSystem" + @"\" + year + @"\" + month + @"\" + day);

          }
          catch
          {
          }
      }
       /// <summary>
       /// 输出月份总进项
       /// </summary>
       public int AllIn;
       /// <summary>
       /// 输出月份总出项
       /// </summary>
       public int AllOut;

     /// <summary>
     /// 读取进销总额
     /// </summary>
     /// <param name="time">时间信息</param>
     /// <param name="IsReadAll">真读月份值，假读年份值</param>
     /// <param name="ProductName">产品名称</param>
     /// <param name="Muru">目录</param>
       public IOReader(string time, bool IsReadAll,string ProductName,string Muru)
       {
           if (IsReadAll == true)
           {
               GetTime ti = new GetTime(time);
               string year = ti.GetYear();
               string month = ti.GetMonth();
               FileNameBack g = new FileNameBack("IOSystem" + @"\" + year + @"\" + month);//根目录搜寻
               for (int i = 0; i < g.AllName.Length; i++)//搜寻所有名称
               {
                   IOReader h = new IOReader(year+month+g.AllName[i]);//遍历文件值
                   InDetective Indec = new InDetective(h.txt);//进项搜索
                   foreach (string z in Indec.DiInDetective.Keys)
                   {
                       if (z.Contains(Muru+"-"+ProductName)) 
                       AllIn += Indec.DiInDetective[z];//进项值加总
                   }
                   OutDetective Outdec = new OutDetective(h.txt);
                   foreach (string x in Outdec.DiOutDetective.Keys)
                   {
                       if (x.Contains(Muru + "-" + ProductName)) 
                       AllOut += Outdec.DiOutDetective[x];
                   }
               }
           }
           else
           {
               GetTime ti = new GetTime(time);
               string year = ti.GetYear();
               FileNameBack g = new FileNameBack("IOSystem" + @"\" + year);//根目录搜寻
               for (int i = 0; i < g.AllName.Length; i++)//搜寻所有名称
               {
                   IOReader h = new IOReader(g.AllName[i]);//遍历文件值
                   InDetective Indec = new InDetective(h.txt);//进项搜索
                   foreach (string z in Indec.DiInDetective.Keys)
                   {
                       if (z.Contains(Muru + "-" + ProductName)) 
                       AllIn += Indec.DiInDetective[z];//进项值加总
                   }
                   OutDetective Outdec = new OutDetective(h.txt);
                   foreach (string x in Outdec.DiOutDetective.Keys)
                   {
                       if (x.Contains(Muru + "-" + ProductName)) 
                       AllOut += Outdec.DiOutDetective[x];
                   }
               }
           }
       }
       /// <summary>
       /// 产品信息的读取,目录-产品搜寻模式
       /// </summary>
       /// <param name="time">时间信息</param>
       /// <param name="IsReadAll">假为年份读取信息</param>
       /// <param name="ProductName">产品名称</param>
       /// <param name="Muru">目录</param>
       /// <param name="JD">进度条</param>
       public IOReader(string time, bool IsReadAll, string ProductName, string Muru,ProgressBar JD)
       {
           try
           {
               if (IsReadAll == true)
               {
                   GetTime ti = new GetTime(time);
                   string year = ti.GetYear();
                   string month = ti.GetMonth();
                   FileNameBack g = new FileNameBack("IOSystem" + @"\" + year + @"\" + month);//根目录搜寻
                   JD.Minimum = 0;
                   JD.Maximum = g.AllName.Length;
                   JD.Value = 0;
                   for (int i = 0; i < g.AllName.Length; i++)//搜寻所有名称
                   {

                       IOReader h = new IOReader(year + month + g.AllName[i]);//遍历文件值
                       InDetective Indec = new InDetective(h.txt);//进项搜索
                       foreach (string z in Indec.DiInDetective.Keys)
                       {
                           if (z.Contains(Muru + "-" + ProductName))
                           {
                               if (Indec.DiInDetective[z] != 0)
                               {
                                   DiYearsIn.Add(year + month + g.AllName[i] + z, Indec.DiInDetective[z]);
                                   AllIn += Indec.DiInDetective[z];//进项值加总
                               }
                           }
                       }
                       OutDetective Outdec = new OutDetective(h.txt);
                       foreach (string x in Outdec.DiOutDetective.Keys)
                       {
                           if (x.Contains(Muru + "-" + ProductName))
                           {
                               if (Outdec.DiOutDetective[x] != 0)
                               {
                                   AllOut += Outdec.DiOutDetective[x];
                                   DiYearsOut.Add(year + month + g.AllName[i] + x, Outdec.DiOutDetective[x]);
                               }
                           }
                       }
                       JD.Value++;
                   }
               }
               else
               {

                   GetTime ti = new GetTime(time);
                   string year = ti.GetYear();
                   FileNameBack g = new FileNameBack("IOSystem" + @"\" + year);//根目录搜寻
                   JD.Minimum = 0;
                   JD.Maximum = g.AllName.Length * 12;
                   JD.Value = 0;
                   for (int Mo = 1; Mo < 13; Mo++)
                   {
                       string month = Mo.ToString() + "月";

                       for (int i = 0; i < g.AllName.Length; i++)//搜寻所有名称
                       {
                           IOReader h = new IOReader(year + @"\" + month + @"\" + g.AllName[i]);//遍历文件值
                           InDetective Indec = new InDetective(h.txt);//进项搜索
                           time = year + month + g.AllName[i];
                           foreach (string z in Indec.DiInDetective.Keys)
                           {
                               if (z.Contains(Muru + "-" + ProductName))
                               {
                                   try
                                   {

                                       if (Indec.DiInDetective[z] != 0)
                                       {

                                           DiYearsIn.Add(time + z, Indec.DiInDetective[z]);
                                           AllIn += Indec.DiInDetective[z];//进项值加总

                                       }
                                   }
                                   catch
                                   {
                                   }


                               }

                           }
                           OutDetective Outdec = new OutDetective(h.txt);
                           foreach (string x in Outdec.DiOutDetective.Keys)
                           {
                               if (x.Contains(Muru + "-" + ProductName))
                               {
                                   try
                                   {

                                       if (Outdec.DiOutDetective[x] != 0)
                                       {

                                           DiYearsOut.Add(time + x, Outdec.DiOutDetective[x]);
                                           AllOut += Outdec.DiOutDetective[x];
                                       }
                                   }
                                   catch
                                   {
                                   }
                               }
                           }
                           JD.Value++;
                       }

                   }

               }


           }
           catch
           {
           }
       }
      /// <summary>
      /// 产品信息读取，目录搜寻模式
      /// </summary>
      /// <param name="time">时间信息</param>
      /// <param name="IsReadAll">假为读年份信息，真为月份信息</param>
      /// <param name="Muru">目录</param>
      /// <param name="JD">进度</param>
       public IOReader(string time, bool IsReadAll, string Muru, ProgressBar JD)
       {
           if (IsReadAll == true)
           {
               GetTime ti = new GetTime(time);
               string year = ti.GetYear();
               string month = ti.GetMonth();
               FileNameBack g = new FileNameBack("IOSystem" + @"\" + year + @"\" + month);//根目录搜寻
               JD.Minimum = 0;
               JD.Maximum = g.AllName.Length;
               JD.Value = 0;
               for (int i = 0; i < g.AllName.Length; i++)//搜寻所有名称
               {
                
                       IOReader h = new IOReader(year + month + g.AllName[i]);//遍历文件值
                       InDetective Indec = new InDetective(h.txt);//进项搜索
                       foreach (string z in Indec.DiInDetective.Keys)
                       {
                           if (z.Contains(Muru))
                           {
                               if(Indec.DiInDetective[z]!=0)
                               AllIn += Indec.DiInDetective[z];//进项值加总
                           }
                       }
                       OutDetective Outdec = new OutDetective(h.txt);
                       foreach (string x in Outdec.DiOutDetective.Keys)
                       {
                           if (x.Contains(Muru))
                           {
                               AllOut += Outdec.DiOutDetective[x];
                           }
                       }
                     
                   }
                   JD.Value++;
               
           }
           else
           {

               GetTime ti = new GetTime(time);
               string year = ti.GetYear();
               FileNameBack g = new FileNameBack("IOSystem" + @"\" + year);//根目录搜寻
               JD.Minimum = 0;
               JD.Maximum = g.AllName.Length * 12;
               JD.Value = 0;
               for (int Mo = 1; Mo < 13; Mo++)
               {
                   string month = Mo.ToString() + "月";

                   for (int i = 0; i < g.AllName.Length; i++)//搜寻所有名称
                   {
                       IOReader h = new IOReader(year + @"\" + month + @"\" + g.AllName[i]);//遍历文件值
                       InDetective Indec = new InDetective(h.txt);//进项搜索
                       time = year + month + g.AllName[i];
                       foreach (string z in Indec.DiInDetective.Keys)
                       {
                           if (z.Contains(Muru))
                           {
                               try
                               {

                                   if (Indec.DiInDetective[z] != 0)
                                   {
                                       DiYearsIn.Add(time + z, Indec.DiInDetective[z]);
                                       AllIn += Indec.DiInDetective[z];//进项值加总
                                   }
                               }
                               catch
                               {
                               }
                           }

                       }
                       OutDetective Outdec = new OutDetective(h.txt);
                       foreach (string x in Outdec.DiOutDetective.Keys)
                       {
                           if (x.Contains(Muru))
                           {
                               try
                               {

                                   if (Outdec.DiOutDetective[x] != 0)
                                   {
                                       DiYearsOut.Add(time + x, Outdec.DiOutDetective[x]);
                                       AllOut += Outdec.DiOutDetective[x];
                                   }
                               }
                               catch
                               {
                               }
                           }
                       }
                       JD.Value++;
                   }

               }
           }
       }


        #region 储存数据字典
       public Dictionary<string, int> DiYearsIn = new Dictionary<string, int>();
       public Dictionary<string,int> DiYearsOut=new Dictionary<string,int>();
        #endregion
    }
}

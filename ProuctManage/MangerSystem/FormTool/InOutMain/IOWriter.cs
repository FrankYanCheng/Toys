using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using FileReaderLibrary.DirectoryCreate;
using FileReaderLibrary;
using ToolLibrary.StringTool;
using ToolLibrary;
namespace FormTool.InOutMain
{
    /// <summary>
    /// 进销额管理写入基类
    /// </summary>
   class IOWriter
    {
        /// <summary>
        /// 初始化进销额管理，向文件里增加字符串数组
        /// </summary>
        /// <param name="time">需要改的时间文件信息</param>
        /// <param name="Intxt">需要写入的字符串数组</param>
      /// <param name="manager">操作信息</param>
        public IOWriter(string time, string[] Intxt,ManagerEnum manager)
        {
            if (manager == ManagerEnum.Add)
            {
                GetTime g = new GetTime(time);
                string year = g.GetYear();//获取详细时间信息
                string day = g.GetDay();
                string month = g.GetMonth();
                try
                {
                    FileReader reader = new FileReader();
                    string[] gettxt = reader.SecurityReader(day, "IOSystem" + @"\" + year + @"\" + month + @"\" + day);//尝试读取数组
                    CombineString com = new CombineString(gettxt, Intxt);
                    string[] Alltxt = com.FinalTest;//合并字符串
                    FileWriter write = new FileWriter("IOSystem" + @"\" + year + @"\" + month + @"\" + day, Alltxt, day);
                }
                //未找到文件时
                catch
                {

                    FileWriter write = new FileWriter("IOSystem" + @"\" + year + @"\" + month + @"\" + day, Intxt, day);

                }
            }
            if (manager == ManagerEnum.Alter)
            {
                GetTime g = new GetTime(time);
                string year = g.GetYear();//获取详细时间信息
                string day = g.GetDay();
                string month = g.GetMonth();
                try
                {
                  
                    FileWriter write = new FileWriter("IOSystem" + @"\" + year + @"\" + month + @"\" + day, Intxt, day);

                }
                //未找到文件时
                catch
                {

                    FileWriter write = new FileWriter("IOSystem" + @"\" + year + @"\" + month + @"\" + day, Intxt, day);

                }
            }

        }

        /// <summary>
        /// 初始化进销额管理，向文件里增加字符串数组
        /// </summary>
        /// <param name="time">需要改的时间文件信息</param>
        /// <param name="Intxt">需要写入的字符串数组</param>
       /// <param name="manager">操作信息</param>
        public IOWriter(string time, string Intxt,ManagerEnum manager)
        {
            if (manager == ManagerEnum.Add)
            {
                GetTime g = new GetTime(time);
                string year = g.GetYear();//获取详细时间信息
                string day = g.GetDay();
                string month = g.GetMonth();
                try
                {
                    FileReader reader = new FileReader();
                    string[] gettxt = reader.SecurityReader(day, "IOSystem" + @"\" + year + @"\" + month + @"\" + day);//尝试读取数组
                    string[] Alltxt = new string[gettxt.Length + 1];
                    for (int i = 0; i < gettxt.Length; i++)
                    {
                        Alltxt[i] = gettxt[i];
                    }
                    Alltxt[gettxt.Length] = Intxt;//合并字符串
                    FileWriter write = new FileWriter("IOSystem" + @"\" + year + @"\" + month + @"\" + day, Alltxt, day);

                }

                //未找到文件时
                catch
                {

                    FileWriter write = new FileWriter("IOSystem" + @"\" + year + @"\" + month + @"\" + day, Intxt, day);

                }
            }
            if (ManagerEnum.Alter == manager)
            {
                GetTime g = new GetTime(time);
                string year = g.GetYear();//获取详细时间信息
                string day = g.GetDay();
                string month = g.GetMonth();
                try
                {

                    FileWriter write = new FileWriter("IOSystem" + @"\" + year + @"\" + month + @"\" + day, Intxt, day);

                }
                //未找到文件时
                catch
                {

                    FileWriter write = new FileWriter("IOSystem" + @"\" + year + @"\" + month + @"\" + day, Intxt, day);

                }
            }
        }
    }
}

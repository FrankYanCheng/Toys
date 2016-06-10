using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using FileReaderLibrary.DirectoryCreate;
using FileReaderLibrary.NoSecurityFile;
using FileReaderLibrary;
using ToolLibrary.StringTool;
namespace LogLibrary
{
    /// <summary>
    /// 日志记录类
    /// </summary>
    class LogWriter
    {
        /// <summary>
        /// 初始化日志记录，向文件里增加字符串数组
        /// </summary>
        /// <param name="time">需要改的时间文件信息</param>
        /// <param name="Intxt">需要写入的字符串数组</param>
        public LogWriter(string time, string[] Intxt)
        {
            GetTime g = new GetTime(time);
            string year = g.GetYear();//获取详细时间信息
            string day = g.GetDay();
            string month = g.GetMonth();
            try
            {
                FileReader reader = new FileReader();
                string[] gettxt = reader.SecurityReader(day, "LogDiary" + @"\" + year + @"\" + month + @"\" + day);//尝试读取数组
                CombineString com = new CombineString(gettxt, Intxt);
                string[] Alltxt =com.FinalTest;//合并字符串
                FileWriter write = new FileWriter("LogDiary" + @"\" + year + @"\" + month + @"\" + day, Alltxt, day);
               
            }
               //未找到文件时
            catch
            {

                FileWriter write = new FileWriter("LogDiary" + @"\" + year + @"\" + month + @"\" + day, Intxt, day);

            }

        }

        /// <summary>
        /// 初始化日志记录，向文件里增加字符串
        /// </summary>
        /// <param name="time">需要改的时间文件信息</param>
        /// <param name="Intxt">需要写入的字符串</param>
        public LogWriter(string time, string Intxt)
        {
            GetTime g = new GetTime(time);
            string year = g.GetYear();//获取详细时间信息
            string day = g.GetDay();
            string month = g.GetMonth();
            try
            {
                FileReader reader = new FileReader();
                string[] gettxt = reader.SecurityReader(day, "LogDiary" + @"\" + year + @"\" + month + @"\" + day);//尝试读取数组
                string[] Alltxt = new string[gettxt.Length+1];
                for (int i = 0; i < gettxt.Length; i++)
                {
                    Alltxt[i] = gettxt[i];
                }
                Alltxt[gettxt.Length] = Intxt;//合并字符串
                FileWriter write = new FileWriter("LogDiary" + @"\" + year + @"\" + month + @"\" + day, Alltxt, day);

            }
            //未找到文件时
            catch
            {

                FileWriter write = new FileWriter("LogDiary" + @"\" + year + @"\" + month + @"\" + day, Intxt, day);

            }

        }

    }
}

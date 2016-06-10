using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileReaderLibrary;
using ToolLibrary.StringTool;
namespace LogLibrary
{
    /// <summary>
    /// 读取日志记录信息类
    /// </summary>
  public  class LogReader
    {
      public string[] txt;
      public LogReader(string time)
      {
          FileReader reader = new FileReader();
          GetTime timer=new GetTime(time);
          string year=timer.GetYear();
          string day=timer.GetDay();
          string month=timer.GetMonth();
         txt= reader.SecurityReader(day,"LogDiary" + @"\" + year + @"\" + month + @"\" + day);         
      }
    }
}

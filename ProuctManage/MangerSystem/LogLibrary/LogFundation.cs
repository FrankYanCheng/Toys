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
    /// 日志基础类，检测是否建立了以日期为最小单位的文件夹
    /// </summary>
   public class LogFundation
    {
        string root = "LogDiary";//日志文件夹的名称
       public  LogFundation (string time)
      {
          GetTime createTime = new GetTime(time);//时间处理类   
          string year = createTime.GetYear();
          string month = createTime.GetMonth();
          string day = createTime.GetDay();
          DirectoryCreate dicreate = new DirectoryCreate(root);//判断是否创建了日志文件夹，以日期作为创建日期的标志
          DirectoryCreate diYear = new DirectoryCreate(root + @"\" + year);
          DirectoryCreate diMonth = new DirectoryCreate(root+@"\"+year+@"\"+ month);
          DirectoryCreate diDay = new DirectoryCreate(root + @"\" + year + @"\" + month+@"\"+day);
           
                
      }
    }
}

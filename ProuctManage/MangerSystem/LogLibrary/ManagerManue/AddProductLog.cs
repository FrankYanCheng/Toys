using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileReaderLibrary.DirectoryCreate;
using FileReaderLibrary;
using System.IO;
namespace LogLibrary.ManagerManue
{
    /// <summary>
    /// 添加新产品或删除产品时记录的日志类
    /// </summary>
  public  class AddProductLog
    {
     /// <summary>
     /// 初始化新产品日志类（添加字符串）
     /// </summary>
     /// <param name="txt">添加的字符串</param>
     /// <param name="time">时间信息，用于供底层辨别文件位置</param>
      public AddProductLog(string txt,string time)
      {
         
          LogFundation log = new LogFundation(time);//日志记录基类
          LogWriter writer = new LogWriter(time, txt);//数据写入
      }
      /// <summary>
      /// 初始化新产品日志类（添加字符串数组）
      /// </summary>
      /// <param name="txt">添加的字符串数组</param>
      /// <param name="time">时间信息，用于供底层辨别文件位置</param>
      public AddProductLog(string[] txt, string time)
      {

          LogFundation log = new LogFundation(time);//日志记录基类
          LogWriter writer = new LogWriter(time, txt);//数据写入
      }
    }
}

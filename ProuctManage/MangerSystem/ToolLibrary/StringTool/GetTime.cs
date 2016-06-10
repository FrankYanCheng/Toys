using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.StringTool
{
    /// <summary>
    /// 获取给定时间的年份，月份或所属日期
    /// </summary>
   public class GetTime
    {
       string time;
       int Yp;
       int Mp;
       int Dp;
       /// <summary>
       /// 初始化日期
       /// </summary>
       /// <param name="time"></param>
       public GetTime(string time)
       {
           this.time = time;
            Yp = time.IndexOf('年');
            Mp = time.IndexOf('月');
            Dp= time.IndexOf('日');
       }
       public string GetYear()
       {
         
        return time.Substring(0,Yp+1);
       }
       public string GetMonth()
       {
           return time.Substring(Yp+1,Mp-Yp);
       }
       public string GetDay()
       {
           return time.Substring(Mp + 1, Dp-Mp);
       }

    }
}

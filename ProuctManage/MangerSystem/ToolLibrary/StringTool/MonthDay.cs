using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.StringTool
{
    /// <summary>
    /// 月份日期检测类
    /// </summary>
  public  class MonthDay
    {
            int  day;
            int month;
          /// <summary>
          /// 初始化月份和年份
          /// </summary>
          /// <param name="day">日期</param>
          /// <param name="month">月份</param>
            public MonthDay(int day, int month)
            {
                this.day = day;
                this.month = month;

            }
            /// <summary>
            /// 检测是否包含所需月份和日期
            /// </summary>
            /// <param name="time">传入的时间</param>
            /// <returns>如果日期检测到则返回真，否则返回假</returns>
            public bool MonthDayDetective(string time)
            {
                if (time.Contains(month + "月" + day + "日"))
                {
                    return true;
                }
                else
                    return false;
            }
        
    }
}

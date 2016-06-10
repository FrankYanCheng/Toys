using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.StringTool
{
    /// <summary>
    /// 年月检测类
    /// </summary>
   public class YearMonth
    {
       int  year;
       int month;
       /// <summary>
       /// 初始化需要的年份和月份
       /// </summary>
       /// <param name="year">年份</param>
       /// <param name="month">月份</param>
       public YearMonth(int year, int month)
       {
           this.year = year;
           this.month = month;

       }
       /// <summary>
       /// 检测是否包含所需年月份
       /// </summary>
       /// <param name="time">传入的时间</param>
       /// <returns></returns>
       public bool YearMonthDetective(string time)
       {
           if(time.Contains(year+"年"+month+"月"))
           {
               return true;
           }
           else
               return false;
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.MonthTool
{
   public class MonthToDay
   {
      public int Day;
       /// <summary>
       /// 返回月份所对应的天数
       /// </summary>
       /// <param name="Month"></param>
       /// <param name="Year"></param>
       public MonthToDay(string Month, int  Year)
       {
          
           try
           {

               if (Month == "1" || Month == "3" || Month == "5" || Month == "7" || Month == "8" || Month == "10" || Month == "12")
               {
                   Day = 31;
               }
              else 
               {
                   if (Month == "2")
                   {
                       if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
                       {
                           Day = 29;
                       }
                       else
                       {
                           Day = 28;
                       }


                   }
                   else
                       Day = 30;
               }

           }
           catch
           {
           }
       }
    }
}

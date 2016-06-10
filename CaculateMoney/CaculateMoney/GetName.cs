using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaculateMoney
{
   public class GetName
    {
       public string Name(string name)
       {
           int x= name.IndexOf('.');
           return name.Substring(0, x);

       }
       //获取日期
       public string GetDay(string name)
       {
           string[] spart = name.Split(' ');
           return spart[0];
       }
       //获取月份日期
       public string GetMonthDay(string name)
       {
          int i= name.IndexOf('年');
        return  name = name.Substring(i + 1, name.Length - i - 1);
       }
       //获取年份以及月份
       public string GetYearMonth(string name)
       {
           int i = name.IndexOf('月');
           return name = name.Substring(0, i+1);
       }
       //获取限制数额
       public string GetLimitCost(string name)
       {
           string[] spart = name.Split(' ');
           return spart[1]=spart[1].Substring(0,spart[1].Length-1);
       }
    }
}

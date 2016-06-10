using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary
{
   public class PaiXu
    {
       public double[] cost;
     /// <summary>
     /// 排序类构造函数，返回的cost即排序后顺序
     /// </summary>
     /// <param name="Cost">给定的花费</param>
     /// <param name="isUp">是否为升序</param>
     public  PaiXu(double[] Cost,bool isUp)
       {
           double Trance;
           
           {
               for(int i=0;i<Cost.Length-1;i++)
                   for (int j = i + 1; j < Cost.Length; j++)
                   {
                       if (isUp == true)//升序
                       {
                           if (Cost[j] < Cost[i])
                           {
                               Trance = Cost[i];
                               Cost[i] = Cost[j];
                               Cost[j] = Trance;

                           }
                       }
                       else//降序
                       {
                           if (Cost[j] >Cost[i])
                           {
                               Trance = Cost[i];
                               Cost[i] = Cost[j];
                               Cost[j] = Trance;

                           }
                       }
                   }
           }
           cost = Cost;
       }
    }
}

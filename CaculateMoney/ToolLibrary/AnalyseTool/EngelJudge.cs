using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.AnalyseTool
{
   public class EngelJudge
   {
      public double X = 0;
    public  string Rank = null;//恩格尔系数阶级
       /// <summary>
       /// 恩格尔系数计算
       /// </summary>
       /// <param name="EatingCost">外出吃饭花费</param>
       /// <param name="StudentCar">学生卡花销，按0.8的比例取饭钱</param>
       /// <param name="TotalCost">总花费</param>
       public EngelJudge(double EatingCost,double StudentCar ,double TotalCost)
       { 
           
           try
           {
               X= (EatingCost + StudentCar * 0.8) / TotalCost;
            
           }
           catch
           {
              
           }
       }

     /// <summary>
       /// 恩格尔系数判断
     /// </summary>
     /// <param name="X">恩格尔系数</param>
     /// <returns></returns>
       public void JudgeRank(double X)
       {
          
         
               if (X >= 0.59)
               {
                   Rank="贫困";
               }
               if (X < 0.59 && X > 0.5)
               {
                   Rank = "温饱";
               }
               if (X <= 0.5 && X >= 0.4)
               {
                   Rank = "小康";
               }
               if (X < 0.4 && X >= 0.3)
               {
                   Rank = "富裕";
               }
           
                if(X<0.3)
                    Rank = "最富裕";
           
         
          
       }
    }
}

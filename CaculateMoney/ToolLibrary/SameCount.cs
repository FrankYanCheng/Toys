using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary
{
    /// <summary>
    /// 为解决相同的键值所带来的问题排序类
    /// </summary>
  public  class SameCount
    {
      Dictionary<double, int> DiCount = new Dictionary<double, int>();
      public int Count;
      public double[] FinalRank;
      int RankCount = 0;
    public  int Counting(double[] Cost)//原始值
      {
          for (int i = 0; i < Cost.Length; i++)
          {
              if(DiCount.Keys.Contains(Cost[i]))
              {
                  DiCount[Cost[i]]++;
              }
          }
          Count = DiCount.Count;//赋为满值
          foreach (double x in DiCount.Keys)
          {
              if (DiCount[x] != 1)
              {
                  Count = 0;//满值清0;
                  Count++;
                  
              }
              else
              {
                  FinalRank[RankCount] = DiCount[x];
                  RankCount++;
              }
          }
          return Count;
      }
    }
    
}

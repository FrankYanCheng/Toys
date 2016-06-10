using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.StringTool
{
    /// <summary>
    /// 合并数组工具类
    /// </summary>
  public  class CombineString
    {
      /// <summary>
      /// 最后的合并数组
      /// </summary>
      public string[] FinalTest;
      /// <summary>
      /// 合并数组初始化
      /// </summary>
      /// <param name="first">第一个字符串数组</param>
      /// <param name="last">第二个字符串数组</param>
      public CombineString(string[] first, string[] last)
      {
          try
          {
              int lc = first.Length + last.Length;
              FinalTest = new string[lc];
              for (int i = 0; i < first.Length; i++)
              {
                  FinalTest[i] = first[i];
              }
              for (int j = first.Length; j < lc; j++)
              {
                  FinalTest[j] = last[j - first.Length];
              }
          }
          catch
          {
              FinalTest = new string[last.Length];
              FinalTest = last;
          }
      }
      /// <summary>
      /// 合并数组，初始化
      /// </summary>
      /// <param name="first">第一个字符串数组</param>
      /// <param name="last">第二个字符串</param>
      public CombineString(string[] first, string last)
      {
          try
          {
              int lc = first.Length;
              FinalTest = new string[lc+1];
              for (int i = 0; i < first.Length; i++)
              {
                  FinalTest[i] = first[i];
              }
              FinalTest[first.Length] = last;
          }
          catch
          {
              FinalTest = new string[1];
              FinalTest[0] = last;
          }
      }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolLibrary;
namespace ToolLibrary.StringTool
{
    /// <summary>
    /// 清除字符串
    /// </summary>
  public  class StringRemove
    {
      /// <summary>
      /// 在字符串里清除字符串方法
      /// </summary>
      /// <param name="TargetString">目标字符串数组</param>
      /// <param name="Remove">清除目标字符串</param>
      /// <returns>返回实现的字符串数组</returns>
      public string[] Remove(string[] TargetString, string Remove)
      {
          string[] FinalString = new string[TargetString.Length - 1];
          for (int i = 0; i < TargetString.Length; i++)
          {
              if (TargetString[i] == Remove)
              {
                  for (int j = i; j < TargetString.Length - 1; j++)
                      TargetString[j] = TargetString[j + 1];
              }
          }
          for (int k = 0; k < FinalString.Length; k++)
          {
              FinalString[k] = TargetString[k];
          }
          return FinalString;
      }
      /// <summary>
      /// 在字符串里清除字符串的方法
      /// </summary>
      /// <param name="TargetString">目标字符串数组</param>
      /// <param name="Remove">清除字符串数组</param>
      /// <returns>返回实现的字符串数组</returns>
      public string[] Remove(string[] TargetString, string[] Remove)
      {
          SameCount count = new SameCount();
          Remove = count.SameReturn(Remove);
          string[] FinalString = new string[TargetString.Length - Remove.Length];
          for (int z = 0; z < Remove.Length; z++)
          {
              for (int i = 0; i < TargetString.Length; i++)
              {
                  if (TargetString[i] == Remove[z])
                  {
                      for (int j = i; j < TargetString.Length - 1; j++)
                          TargetString[j] = TargetString[j + 1];

                  }
              }
         
          }
          for (int k = 0; k < FinalString.Length; k++)
          {
              FinalString[k] = TargetString[k];
          }
          return FinalString;
      }


    }
}

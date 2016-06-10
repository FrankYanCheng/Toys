using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.ManagerHeart
{
     /// <summary>
    /// 出项检测类
    /// </summary>
  public  class OutDetective
    {
      /// <summary>
      /// 数据字典，添加 目录-产品——出项信息
      /// </summary>
      public Dictionary<string, int> DiOutDetective = new Dictionary<string, int>();
      string Deelstring;
      string last;
      /// <summary>
      /// 初始化出项检测类 模式为“目录-产品 进项：数量,数据字典的信息为出项值”
      /// </summary>
      /// <param name="txt">读入的字符串</param>
      public OutDetective(string[] txt)
      {
          try
          {
              for (int i = 0; i < txt.Length; i++)
              {
                  try
                  {
                      int j = txt[i].IndexOf("*");
                      Deelstring = txt[i].Substring(0, j);
                      if (Deelstring.Contains("销项"))
                      {
                          Deelstring = Deelstring.Substring(0, j - 3);
                          last = txt[i].Substring(j + 1, txt[i].Length - j - 1);
                          DiOutDetective.Add(Deelstring, Convert.ToInt32(last));
                      }
                  }
                  catch
                  {

                  }
              }
          }
          catch
          {
          }
      }
    }

}

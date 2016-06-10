using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ToolLibrary
{
  public  class TxtReader
    {
      /// <summary>
      /// 查找文件，返回内容
      /// </summary>
      /// <param name="name">文件名称</param>
        /// <param name="ParentMuru">文件根目录</param>
      /// <returns>读取的内容</returns>
      public string[] Reader(string name,string ParentMuru)
      {
          try
          {
              string[] txt;//读取的字符串
              using (FileStream fil = new FileStream(ParentMuru+ @"\" + name + ".txt", FileMode.Open))
              {

                  StreamReader reader = new StreamReader(fil, Encoding.UTF8);
                  string nativetxt = reader.ReadToEnd();
                  return txt = nativetxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);



              }
          }
          catch
          {
              return null;
          }
      }
    }
}

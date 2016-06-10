using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ToolLibrary
{
 public   class TxtWriter
    {
    
     /// <summary>
     /// 写入数据字符串模式
     /// </summary>
     /// <param name="ParentPath">存放的根目录</param>
     /// <param name="name">文件名称</param>
     /// <param name="txt">写入的字符串数组</param>
     public TxtWriter(string ParentPath,string[] txt,string name)
     {
         try
         {
             using (FileStream file = new FileStream(ParentPath + @"\" + name + ".txt", FileMode.Create, FileAccess.Write))
             {
                 using (StreamWriter sw = new StreamWriter(file, Encoding.UTF8))
                 {

                     foreach (string x in txt)
                     {
                         sw.WriteLine(x);
                     }

                 }
             }

         }
         catch
         {
         }
     }
     /// <summary>
     /// 写入数据字符模式
     /// </summary>
     /// <param name="ParentPath">存放的根目录</param>
     /// <param name="name">文件名称</param>
     /// <param name="txt">写入的字符串</param>
     public TxtWriter(string ParentPath, string txt, string name)
     {
         try
         {
             using (FileStream file = new FileStream(ParentPath + @"\" + name + ".txt", FileMode.Create, FileAccess.Write))
             {
                 using (StreamWriter sw = new StreamWriter(file, Encoding.UTF8))
                 {

                  
                    
                         sw.WriteLine(txt);
                     
                 }
             }

         }
         catch
         {
         }
     }
    }
}

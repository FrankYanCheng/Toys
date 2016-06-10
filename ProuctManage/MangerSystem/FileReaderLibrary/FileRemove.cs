using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace FileReaderLibrary
{
    /// <summary>
    /// 删除文件类
    /// </summary>
   public class FileRemove
    {
       /// <summary>
       /// 删除文件类初始化
       /// </summary>
       /// <param name="pathroot">上级目录</param>
       /// <param name="name">文件名称</param>
       public FileRemove(string pathroot,string name)
       {
           string[] Muru = Directory.GetFiles(pathroot, "*.*", SearchOption.AllDirectories);
           for (int i = 0; i < Muru.Length; i++)
           {
               if (pathroot+@"\"+name + ".txt" == Muru[i])
               {
                  File.Delete(Muru[i]);
               }
           }
       }
    }
}

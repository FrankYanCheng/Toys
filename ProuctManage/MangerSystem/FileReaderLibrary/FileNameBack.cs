using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ToolLibrary.StringTool;
namespace FileReaderLibrary
{
    /// <summary>
    /// 根目录返回文件名称类
    /// </summary>
 public   class FileNameBack
    {
     public string[] AllName;
     /// <summary>
     /// 返回所有文件名称
     /// </summary>
     /// <param name="PathRoot">根目录</param>
     public FileNameBack(string PathRoot)
     {
         try
         {

             AllName = Directory.GetFiles(PathRoot, "*.*", SearchOption.AllDirectories);
             for (int i = 0; i < AllName.Length; i++)
             {
                 AllName[i] = Path.GetFileName(AllName[i]);
                 GetFileName deel = new GetFileName(AllName[i]);
                 AllName[i] = deel.FinalName;

             }
         }
         catch
         {
         }
        
     }
    }
}

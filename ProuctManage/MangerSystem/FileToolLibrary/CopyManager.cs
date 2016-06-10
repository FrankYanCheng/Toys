using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ToolLibrary.CopyTool;
using System.Windows.Forms;
namespace FileToolLibrary
{
    /// <summary>
    /// 拷贝管理核心类
    /// </summary>
 public   class CopyManager
    {
     /// <summary>
     /// 初始化拷贝核心类，备份
     /// </summary>
     /// <param name="SourceName">资源路径</param>
     /// <param name="SelectPath">选择路径</param>
     public CopyManager(string SourceName,string SelectPath)
     {

             FileCopyFundation fundation = new FileCopyFundation(SourceName, SelectPath);
             string[] s = Directory.GetDirectories(SourceName, "*.*", SearchOption.AllDirectories);
             for (int i = 0; i < s.Length; i++)
             {
                 FileCopyFundation fun = new FileCopyFundation(s[i], SelectPath);
             }
     }
     /// <summary>
     /// 初始化拷贝核心类，还原
     /// </summary>
     /// <param name="SourceSelect">备份文件的路径</param>
     //public CopyManager(string SourceSelect)
     //{
     //    string[] s = Directory.GetDirectories(SourceSelect, "*.*", SearchOption.AllDirectories);//获得备份路径
     //    CopyString CopyOk = new CopyString();
     //     bool iSoK;
     //    for (int i = 0; i < s.Length; i++)
         //{
         //    iSoK = CopyOk.ToNativePaht(s[i]);
         //    if (iSoK == true)
         //    {
         //        Directory.CreateDirectory(Application.StartupPath+@"\"+CopyOk.ReBugPath);
         //        string[] fin = Directory.GetDirectories(s[i], "*.*", SearchOption.AllDirectories);//获得下一层的搜索备份路径

         //        for (int j = 0; j < fin.Length; j++)
         //        {
         //          Directory.CreateDirectory(Application.StartupPath+
         //        }
                 
         //    }
        
     //    }
        
         

     //}
    }
}

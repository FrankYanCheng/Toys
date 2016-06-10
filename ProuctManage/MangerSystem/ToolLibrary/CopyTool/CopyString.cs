using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.CopyTool
{
/// <summary>
/// 拷贝工具类，处理字符串
/// </summary>
   public class CopyString
    {
        /// <summary>
        /// 根据原始路径得到备份文件具体路径
        /// <param name="firstpath">原始路径</param>
        /// <param name="finalRootPath">备份文件根路径</param>
         /// <param name="AddPath">在备份数据中添加文件夹</param>
        /// <returns>备份文件具体路径</returns>
        /// </summary>
       public string ToCopyPath(string firstpath,string finalRootPath,string AddPath)
       {
           int i = firstpath.IndexOf(@":");
           int j = firstpath.LastIndexOf(@"\");
           return finalRootPath+ AddPath + @"\" + firstpath.Substring(i+ 1, firstpath.Length - i - 1);

       }
       public string ReBugPath;//备份数据的路径详细
       /// <summary>
       /// 根据备份路径还原数据
       /// </summary>
       /// <param name="SourcePath">选择的备份路径</param>
       /// <returns>真则存在值</returns>
       public bool ToNativePaht(string SourcePath)
       {
            int i=SourcePath.LastIndexOf(@"\");//分块检测文件夹名称
            SourcePath = SourcePath.Substring(i + 1, SourcePath.Length - i - 1);
            if (SourcePath.Contains("IOSystem") || SourcePath.Contains("MSsystem") ||
                SourcePath.Contains("LogDiary") || SourcePath.Contains("ProductSave"))
            {
                ReBugPath = SourcePath;
                return true;
            }
            else
                return false;
       }

    }
}

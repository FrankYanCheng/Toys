using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ToolLibrary.CopyTool;
namespace FileToolLibrary
{
    /// <summary>
    /// 文件拷贝基类
    /// </summary>
    class FileCopyFundation
    {
        /// <summary>
        ///拷贝备份基类初始化
        /// </summary>
        /// <param name="firstpath">原始路径</param>
        /// <param name="finalRoot">备份路径根目录</param>
        public FileCopyFundation(string firstpath, string finalRoot)
        {
            CopyString gf = new CopyString();
            string finalpath = gf.ToCopyPath(firstpath,finalRoot,"ManagerSystem数据备份");
            Directory.CreateDirectory(finalpath);
            DirectoryInfo search = new DirectoryInfo(firstpath);
            FileInfo[] z = search.GetFiles();
            foreach(FileInfo x in z)
            {
                
                 File.Copy(x.FullName.ToString(),finalpath+@"\"+x, true);
        }
        }
        ///// <summary>
        ///// 拷贝基类初始化，数据还原
        ///// </summary>
        ///// <param name="Path">备份路径的地址</param>
        //public FileCopyFundation(string Path)
        //{
        //    CopyString fg = new CopyString();
        //   bool IsOk=fg.ToNativePaht(Path);
        //}
    }
    
}

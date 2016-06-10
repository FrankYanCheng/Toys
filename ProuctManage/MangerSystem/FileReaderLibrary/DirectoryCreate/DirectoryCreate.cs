using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace FileReaderLibrary.DirectoryCreate
{
    /// <summary>
    /// 创建文件夹类
    /// </summary>
    public class DirectoryCreate
    {
        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="path">文件的路径名称</param>
        public DirectoryCreate(string path)
        {
            if (!Directory.Exists(path))
            { Directory.CreateDirectory(path); }
        }
    }
}

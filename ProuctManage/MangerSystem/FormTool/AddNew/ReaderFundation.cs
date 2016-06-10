using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileReaderLibrary.DirectoryCreate;
using FileReaderLibrary;
namespace FormTool.AddNew
{
    /// <summary>
    /// 添加新项读出信息基类，目录为文件
    /// </summary>
  public  class ReaderFundation
    {
        public string[] writer = null;
        /// <summary>
        /// 初始化，类里的writer数组用于返回内容
        /// </summary>
        /// <param name="Muru"></param>
        public ReaderFundation(string Muru)
         {
             
              string path = "ProductSave";
              DirectoryCreate create = new DirectoryCreate(path);//判读存放的目录存在，不存在则重新创建
              try
              {
                  FileReader read = new FileReader();
                  writer=read.SecurityReader(Muru, path);
              }
              catch
              {
                  FileWriter write = new FileWriter(path, Muru);
              }
      }
    }
}

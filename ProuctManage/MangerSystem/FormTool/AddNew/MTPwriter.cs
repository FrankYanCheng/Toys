using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileReaderLibrary;
using FileReaderLibrary.DirectoryCreate;
using ToolLibrary.StringTool;
namespace FormTool.AddNew
{
    /// <summary>
    /// 目录信息与产品信息数据写入
    /// </summary>
   public class MTPwriter
    {
       /// <summary>
       /// 产品添加数据处理初始化，单个产品模式
       /// </summary>
       /// <param name="Muru">目录信息</param>
       /// <param name="ProductName">产品信息</param>
       /// <param name="operation">操作模式</param>
       public MTPwriter(string Muru, string ProductName,ProductEnum operation)
       {
            string path = "ProductSave";
            DirectoryCreate create = new DirectoryCreate("ProductSave");
           if (operation == ProductEnum.add)
           {

               ReaderFundation read = new ReaderFundation(Muru);
               string []txt=read.writer;
               CombineString combine = new CombineString(txt,ProductName);//合并字符串数组
               WriterFundation write = new WriterFundation(Muru, combine.FinalTest);//最后写入的字符串数组

           }
           if (operation == ProductEnum.remove)
           {
               try
               {
                   ReaderFundation read = new ReaderFundation(Muru);
                   string[] txt = read.writer;
                   StringRemove remove = new StringRemove();
                   WriterFundation write = new WriterFundation(Muru, remove.Remove(txt, ProductName)); ;
               }
               catch
               {
               }
           }
           if (operation == ProductEnum.removeMuru)
           {
               FileRemove remove = new FileRemove(path + @"\" + Muru, Muru);
           }
       }
       /// <summary>
       /// 添加目录模式
       /// </summary>
       /// <param name="Muru">目录名称</param>
       public MTPwriter(string Muru)
       {
           DirectoryCreate create = new DirectoryCreate("ProductSave");
           WriterFundation writer = new WriterFundation(Muru);
       }
       /// <summary>
       /// 产品添加数据处理初始化，多产品操作模式
       /// </summary>
       /// <param name="Muru">目录信息</param>
       /// <param name="ProductName">产品组信息</param>
       /// <param name="operation">操作模式</param>
       public MTPwriter(string Muru, string[] ProductName, ProductEnum operation)
       {
           DirectoryCreate create = new DirectoryCreate("ProductSave");
           string path = "ProductSave";
           if (operation == ProductEnum.add)
           {

               ReaderFundation read = new ReaderFundation(Muru);
               string[] txt = read.writer;
               CombineString combine = new CombineString(txt, ProductName);//合并字符串数组
               WriterFundation write = new WriterFundation(Muru, combine.FinalTest);//最后写入的字符串数组

           }
           if (operation == ProductEnum.remove)
           {
               try
               {
                   ReaderFundation read = new ReaderFundation(Muru);
                   string[] txt = read.writer;
                   StringRemove remove = new StringRemove();
                  WriterFundation writer=new WriterFundation(Muru,remove.Remove(txt, ProductName));
               }
               catch
               {
               }
           }
           if (operation == ProductEnum.removeMuru)
           {
               FileRemove remove = new FileRemove(path + @"\" + Muru, Muru);
           }
       }

    }
}

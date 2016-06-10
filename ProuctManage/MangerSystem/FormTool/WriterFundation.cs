using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileReaderLibrary.DirectoryCreate;
using FileReaderLibrary;
using ToolLibrary.StringTool;
namespace FormTool
{
    /// <summary>
    /// 产品写入基类
    /// </summary>
   public class WriterFundation
    {
       /// <summary>
        ///初始化 产品写入基类
       /// </summary>
       /// <param name="Muru">目录</param>
       /// <param name="Intxt">字符串数组数据</param>
        public WriterFundation(string Muru, string[] Intxt)
        {
         
            try
            {
                FileWriter write = new FileWriter("ProductSave",Intxt,Muru);
               
            }
               //未找到文件时
            catch
            {

              

            }

        }


        /// <summary>
        ///初始化 产品写入基类
        /// </summary>
        /// <param name="Muru">目录</param>
        /// <param name="Intxt">字符串数据</param>
        public WriterFundation(string Muru, string Intxt)
        {

            try
            {
                FileWriter write = new FileWriter("ProductSave", Intxt, Muru);

            }
            //未找到文件时
            catch
            {



            }

        }
       /// <summary>
       /// 创建文件
       /// </summary>
       /// <param name="Muru">目录</param>
        public WriterFundation(string Muru)
        {

            try
            {
                FileWriter write = new FileWriter("ProductSave", Muru);

            }
            //未找到文件时
            catch
            {



            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ToolLibrary.StudentCardTool
{
    public class GetCardIn
    {
        public double CardIn;//进账信息
        public Dictionary<string, double> DirectIn = new Dictionary<string, double>();
        string SavePath = "StSave";
        double dayin;
        /// <summary>
        /// 获得该月份的学生卡进账值
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        public GetCardIn(int Month, int Year)
        {
            NameWay way = new NameWay();
            DirectoryInfo dir = new DirectoryInfo(SavePath);//遍历所有的文件
            FileInfo[] ZiMuRu = dir.GetFiles();//获取目录信息
            for (int i = 0; i < ZiMuRu.Length; i++)//遍历所搜寻的目录
            {
                if (ZiMuRu[i].ToString().Contains(Month + "月") && ZiMuRu[i].ToString().Contains(Year + "年") && ZiMuRu[i].ToString().Contains("学生卡进账"))//获取包含该月份年份的文件
                {
                    using (FileStream fil = new FileStream(SavePath + @"\" + ZiMuRu[i], FileMode.Open))
                    {
                        try
                        {
                            StreamReader reader = new StreamReader(fil, Encoding.UTF8);
                            string nativetxt = reader.ReadToEnd();
                            string[] txt = nativetxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            if (way.GetCost(txt[0]) != "0")
                            {
                              dayin=  Convert.ToDouble(way.GetCost(txt[0]));
                                CardIn += dayin;
                               DirectIn.Add(ZiMuRu[i].ToString(), dayin);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
        /// <summary>
        /// 获取年份进账信息
        /// </summary>
        /// <param name="Year"></param>
        public GetCardIn( int Year)
        {
            NameWay way = new NameWay();
            DirectoryInfo dir = new DirectoryInfo(SavePath);//遍历所有的文件
            FileInfo[] ZiMuRu = dir.GetFiles();//获取目录信息
            for (int i = 0; i < ZiMuRu.Length; i++)//遍历所搜寻的目录
            {
                if ( ZiMuRu[i].ToString().Contains(Year + "年"))//获取包含该月份年份的文件
                {
                    using (FileStream fil = new FileStream(SavePath + @"\" + ZiMuRu[i], FileMode.Open))
                    {
                        try
                        {
                            StreamReader reader = new StreamReader(fil, Encoding.UTF8);
                            string nativetxt = reader.ReadToEnd();
                            string[] txt = nativetxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            if (way.GetCost(txt[0]) != "-1")
                                CardIn += Convert.ToDouble(way.GetCost(txt[0]));

                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ToolLibrary.AnalyseTool
{
  public  class EngelJudge_Caculate
    {
      public double StudentCar;//获取本月学生卡消费
      public double EatOut;//获取本月外出吃饭钱数
      /// <summary>
      /// 恩格尔系数所需值的计算赋值
      /// </summary>
      /// <param name="year"></param>
      /// <param name="month"></param>
      /// <param name="SavePath"></param>
      public EngelJudge_Caculate(string year,string month,string SavePath)
      {
         
          DirectoryInfo dir = new DirectoryInfo(SavePath);//遍历所有的文件
          FileInfo[] ZiMuRu = dir.GetFiles();//获取目录信息
          TxtReader read = new TxtReader();
          NameWay nameOut=new NameWay();
          for (int i = 0; i < ZiMuRu.Length; i++)//遍历所搜寻的目录
          {
              if (ZiMuRu[i].ToString().Contains(month + "月") && ZiMuRu[i].ToString().Contains(year + "年"))//获取包含该月份年份的文件
              {
                  using (FileStream fil = new FileStream(SavePath + @"\" + ZiMuRu[i], FileMode.Open))
                  {
                      try
                      {
                          StreamReader reader = new StreamReader(fil, Encoding.UTF8);
                          string nativetxt = reader.ReadToEnd();
                          string[] txt = nativetxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                          foreach (string x in txt)
                          {
                              if (((x.Contains("聚餐") || x.Contains("水果")) || x.Contains("饭") || x.Contains("饮料") || x.Contains("奶茶"))
                                  || x.Contains("小吃") && !x.Contains("饭卡"))
                            EatOut+=Convert.ToDouble(nameOut.GetCost(x));
                              if (x.Contains("学生卡") || x.Contains("饭卡"))
                              {
                                  StudentCar += Convert.ToDouble(nameOut.GetCost(x));
                              }
                          }
                       
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

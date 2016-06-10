using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormTool.MonthSave
{
    /// <summary>
    /// 库存管理基类
    /// </summary>
   public class MSManager
    {
       /// <summary>
       /// 初始化库存管理
       /// </summary>
       /// <param name="time">时间</param>
       /// <param name="count">月初库存量</param>
       /// <param name="Muru">目录</param>
       /// <param name="ProductName">产品信息</param>
       public MSManager(string time, int count, string Muru, string ProductName)
       {
           MSFundation fun = new MSFundation(time);
           MSWriter writer = new MSWriter(Muru, ProductName, time, count);
           LogLibrary.ManagerManue.AddProductLog log = new LogLibrary.ManagerManue.AddProductLog(DateTime.Now.ToShortTimeString() + " " + 
               time + "修改月初库存值" + Muru + ":" + ProductName + "库存" +count,time);
       }

    }
}

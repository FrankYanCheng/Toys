using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogLibrary.ManagerManue;
using ToolLibrary.ManagerHeart;
namespace FormTool.InOutMain
{
    /// <summary>
    /// 进销项文件管理类
    /// </summary>
 public class IOManager
    {
     /// <summary>
     /// 产品管理信息写入类
     /// </summary>
     /// <param name="Incom">进项</param>
     /// <param name="outcome">销项</param>
     /// <param name="muru">目录</param>
     /// <param name="ProductName">产品名称</param>
     /// <param name="time">时间信息</param>
     /// <param name="managerenum">数据操作类型</param>
     public  IOManager(int Incom,int outcome,string muru,string ProductName,string time,ManagerEnum managerenum)
     {
         IOFundation iofun = new IOFundation(time);//文件管理类
         string[] writetxt=new string[2];
         writetxt[0]=muru+"-"+ProductName+"-进项*"+Incom;
         writetxt[1]=muru+"-"+ProductName+"-销项*"+outcome;
         if(managerenum==ManagerEnum.Add)
         {
             IOWriter write = new IOWriter(time, writetxt,ManagerEnum.Add); 
             AddProductLog log = new AddProductLog(DateTime.Now.ToShortTimeString() +"日期"+time+ " 添加 " + ProductName + "产品" + "进项" + Incom + "销项" + outcome, time);
         }
         if (managerenum == ManagerEnum.Alter)
         {
             AlterInOutInformation Inalter = new AlterInOutInformation(Incom, muru, ProductName, true, time);
             AlterInOutInformation OutAlter = new AlterInOutInformation(outcome, muru, ProductName, false, time);
             AddProductLog log = new AddProductLog(DateTime.Now.ToShortTimeString() +"日期"+time+ " 修改 " + ProductName + "产品" + "进项为" + Incom + "销项为" + outcome, time);
             
         }
      
     }
     /// <summary>
     /// 读取写入修改库存初始化
     /// </summary>
     /// <param name="Muru">目录</param>
     /// <param name="ProductName">产品名称</param>
     /// <param name="time">时间信息</param>
     public int IOOut;//销项
     public int IOInt;//进项
     public string[] txt;//销项
     public IOManager(string Muru, string ProductName, string time,ManagerEnum manager)
     {
       
         if (manager == ManagerEnum.Read)
         {
             IOFundation funder = new IOFundation(time);
             IOReader read = new IOReader(time);
             txt = read.txt;//取数据
             InDetective dec = new InDetective(txt);
             OutDetective ouec = new OutDetective(txt);
             //搜索进销项
             string name=Muru + "-" + ProductName;
             foreach (string x in dec.DiInDetective.Keys)
             {
                 if (x == name)
                 {
                     IOInt = dec.DiInDetective[x];
                 }
             }
             foreach (string z in ouec.DiOutDetective.Keys)
             {
                 if (z == name)
                 {
                     IOOut = ouec.DiOutDetective[z];
                 }
             }
         }
     }

    }
}

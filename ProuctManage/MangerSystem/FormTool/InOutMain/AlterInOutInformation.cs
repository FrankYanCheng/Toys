using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolLibrary.ManagerHeart;
using ToolLibrary;
namespace FormTool.InOutMain
{
   /// <summary>
    /// 修改进销信息类
    /// </summary>
    public class AlterInOutInformation
    {
        /// <summary>
        /// 初始化进销信息修改
        /// </summary>
        /// <param name="txt">修改值</param>
        /// <param name="Muru">产品目录</param>
        /// <param name="ProductName">产品名称</param>
        /// <param name="isIn">真为进项，假为销项</param>
     /// <param name="time">时间信息</param>
        public AlterInOutInformation(int number, string Muru, string ProductName, bool isIn,string time)
        {
            try
            {
                if (isIn == true)
                {
                    string keyfind = Muru + "-" + ProductName;
                    IOReader reader = new IOReader(time);
                    string[] txt = reader.txt;
                    InDetective det = new InDetective(txt);
                    Dictionary<string, int> UserInAlter = new Dictionary<string, int>();
                    foreach (string t in det.DiInDetective.Keys)
                    {
                        if (t == Muru + "-" + ProductName)
                        {
                            UserInAlter.Add(t, number);
                        }

                    }
                    for (int i = 0; i < txt.Length; i++)
                    {
                        if (txt[i].Contains(keyfind + "-" + "进项"))
                        {
                            txt[i] = keyfind + "-" + "进项" + "*" + UserInAlter[keyfind];
                        }
                    }
                    SameCount bug = new SameCount();//去除同类项
                   string[] FinalTxt= bug.SameReturn(txt);
                    IOWriter write = new IOWriter(time, FinalTxt,ManagerEnum.Alter);


                }
                if (isIn == false)
                {
                    string keyfind = Muru + "-" + ProductName;
                    IOReader reader = new IOReader(time);
                    string[] txt = reader.txt;
                    OutDetective det = new OutDetective(txt);
                    Dictionary<string, int> UserOutAlter = new Dictionary<string, int>();
                    foreach (string t in det.DiOutDetective.Keys)
                    {
                        if (t == Muru + "-" + ProductName)
                        {
                           UserOutAlter.Add(t,number);//修改进项信息
                        }

                    }
                    for (int i = 0; i < txt.Length; i++)
                    {
                        if (txt[i].Contains(keyfind + "-" + "销项"))
                        {
                            txt[i] = keyfind + "-" + "销项" + "*" + UserOutAlter[keyfind];
                        }
                    }
                    SameCount bug = new SameCount();//去除同类项
                    string[] FinalTxt = bug.SameReturn(txt);
                    IOWriter write = new IOWriter(time, FinalTxt, ManagerEnum.Alter);

                }
            }
            catch
            {
            }

        }

    }
}

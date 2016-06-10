using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolLibrary;
using ToolLibrary.AnalyseTool;
using ToolLibrary.MonthTool;
namespace CaculateMoney
{
    public partial class QuWei : Form
    {
        public QuWei()
        {
            InitializeComponent();
        }
        public double Cost;
        public double Limition_Month;//月度限额值
        public double LeftMoney;//剩余钱数
        public string Year;
        public string Month;
        string SavePath = "Save";
        public int  Day;
        private void QuWei_Load(object sender, EventArgs e)
        {
            MonthToDay Mtd = new MonthToDay(Month, Convert.ToInt32(Year));//获取该月天数
            EngelJudge_Caculate g = new EngelJudge_Caculate(Year, Month, SavePath);//恩格尔系数查找数据方式
            EngelJudge judge = new EngelJudge(g.EatOut, g.StudentCar, Cost);//由获取的数据载入判断值
            judge.JudgeRank(judge.X);//获取的恩格尔系数判断类型
            if (Cost <= Limition_Month)
            {
                if (g.EatOut / g.StudentCar >= 0.35)
                {
                    if (g.StudentCar != 0)
                        textBox1.Text = "鉴定状态：" + judge.Rank + "!" + "\r\n" +
                                         "本月已花销" + Cost + "元   剩余钱数" + LeftMoney + "元\r\n" +
                                         "花销限额为"+Limition_Month+"元\r\n"+
                                         "建议余下的天数每天花费至多" + Convert.ToInt32(LeftMoney / (Mtd.Day - Day)) + "元\r\n" +
                                         "在外吃饭花约" + g.EatOut + "元" + "  饭卡消费约" + g.StudentCar + "元\r\n" +
                                         "在外面吃得太多，注意身体和花销哦！";
                    else
                        textBox1.Text = "鉴定状态：" + judge.Rank + "!" + "\r\n" +
                                  "本月已花销" + Cost + "元   剩余钱数" + LeftMoney + "元\r\n" +
                                   "花销限额为" + Limition_Month + "元\r\n" +
                                  "建议余下的天数每天花费至多" + Convert.ToInt32(LeftMoney / (Mtd.Day - Day)) + "元\r\n" +
                                  "在外吃饭花约" + g.EatOut + "元" + "  饭卡消费还未到账 "+"\r\n";
                                
                }                    
                else
                {
                    if (g.StudentCar != 0)
                    {
                        textBox1.Text = "鉴定状态：" + judge.Rank + "!" + "\r\n" +
                                       "本月已花销" + Cost + "元   剩余钱数" + LeftMoney + "元\r\n" + "花销限额为" + Limition_Month + "元\r\n" +
                                       "建议余下的天数每天花费至多" + Convert.ToInt32(LeftMoney / (Mtd.Day - Day)) + "元\r\n" +
                                       "在外吃饭花约" + g.EatOut + "元" + "  饭卡消费约" + g.StudentCar + "\r\n" +
                                     "花销合理，请继续保持~";
                    }
                    else
                    {
                        textBox1.Text = "鉴定状态：" + judge.Rank + "!" + "\r\n" +
                                       "本月已花销" + Cost + "元   剩余钱数" + LeftMoney + "元\r\n" +
                                        "花销限额为" + Limition_Month + "元\r\n" +
                                       "建议余下的天数每天花费至多" + Convert.ToInt32(LeftMoney / (Mtd.Day - Day)) + "元\r\n" +
                                       "在外吃饭花约" + g.EatOut + "元" + "  饭卡消费还未到账" + "\r\n" +
                                     "花销合理，请继续保持~";
                    }
                }
            }
            else
            {
                if (g.StudentCar != 0)
                    textBox1.Text = "鉴定状态：" + judge.Rank + "!" + "\r\n" +
                                       "本月已花销" + Cost + "元   已超花销" + LeftMoney + "元\r\n" +
                                        "花销限额为" + Limition_Month + "元\r\n" +
                                       "在外吃饭花约" + g.EatOut + "元" + "  饭卡消费约" + g.StudentCar + "\r\n" +
                                     "赚钱辛苦，好好学习少花钱~学霸你好，学霸再见";
                else
                {
                    textBox1.Text = "鉴定状态：" + judge.Rank + "!" + "\r\n" +
                                       "本月已花销" + Cost + "元   已超花销" + LeftMoney + "元\r\n" +
                                        "花销限额为" + Limition_Month + "元\r\n" +
                                       "在外吃饭花约" + g.EatOut + "元" + " 饭卡未到账"+ "\r\n" +
                                     "赚钱辛苦，好好学习少花钱~学霸你好，学霸再见";
                }
            }
                             ;
        }
    }
}

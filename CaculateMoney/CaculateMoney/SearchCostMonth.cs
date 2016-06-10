using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ToolLibrary;
using System.Collections.Specialized;
namespace CaculateMoney
{
    public partial class SearchCostMonth : Form
    {
        public SearchCostMonth()
        {
            InitializeComponent();
        }
       //数据字典
        
        public Dictionary<int, double> Dispend = new Dictionary<int, double>();
        public  Dictionary<int, string> DiDay = new Dictionary<int, string>();//建立关于日期的字典
        public Dictionary<string, double> DirectIn = new Dictionary<string, double>();
      
        //属性字段
        private double coust;//花费统计
        public double Coust
        {
            get { return coust; }
            set { coust = value; }
        }
        public string GetMonth;//获取月份
        public string GetYear;
        public bool isYear = false;
        public double TotalCost;
        public double Limition_Month = 0;//月度限额值
        public double LeftMoney = 0;//该月剩余钱数
        public int day;//是月份中的第几天
        public double Start;
        public double Send;
        public double SAdd;
        /// <summary>
        /// 获取详细账目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                string[] pathway = listCost.Text.Split(' ');
                string[] txt;
                GetName getname=new GetName();
                using (FileStream fil = new FileStream("Save" + @"\" + pathway[0] + ".txt", FileMode.Open))
                {
                    try
                    {
                        StreamReader reader = new StreamReader(fil, Encoding.UTF8);
                        string nativetxt = reader.ReadToEnd();
                        txt = nativetxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                        SelectMonthDirectory month = new SelectMonthDirectory();
                        month.Direct = txt;
                        month.day = getname.GetDay(listCost.Text);
                        month.Show();

                    }
                    catch
                    {

                    }
                }
            }
            catch
            {
                MessageBox.Show("请选择日期");
            }
        

        }
        private void SearchCostMonth_Load(object sender, EventArgs e)
        {
            GetName getname = new GetName();
            try
            {
                foreach (int z in Dispend.Keys)
                {
                    if(isYear==false)
                    {
                    listCost.Items.Add(getname.Name(DiDay[z]) + " " + Dispend[z]+"元");
                    coust+= Dispend[z];
                    if (Limition_Month > 0)
                        LeftMoney=Limition_Month-coust;
                        if(LeftMoney>0)
                        label2.Text = GetYear + "年" + GetMonth+"月" + "花销限制为" + Limition_Month+"元\r\n"+"目前剩余 "+LeftMoney+"元";
                        else
                        {
                            LeftMoney=-LeftMoney;
                            label2.Text = GetYear + "年" + GetMonth + "月" + "花销限制为" + Limition_Month + "元\r\n" + "已超标" + LeftMoney + "元";
                            }
                    if((Limition_Month <0))
                        label2.Text = "未进行花销限制";
                    }
                }
                if (isYear == true)
                {

                    for (int i = 1; i < 13; i++)
                    {
                        try
                        {
                            listCost.Items.Add(GetYear + "年" + i + "月"+"    " + Dispend[i] + "元");
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch
            {
            }
            if(isYear==false)
            {
            label1.Text =GetMonth+"月\r\n已花费" + Coust+"元";
             
            
            }
            else
            {
                label1.Text = GetYear+ "年\r\n已花费" + TotalCost + "元";
                btnAll.Hide();
                btnOutAll.Hide();
                btnAnalyse.Hide();
            }
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPaiXu_Click(object sender, EventArgs e)
        {
            ReMoveSameKey same = new ReMoveSameKey();//去除相同值类
            double[] cost=new double[Dispend.Count];
            NameValueCollection C = new NameValueCollection();//特殊字典以存储相同的值
            int z=0;//coust序号
            //排序的数赋值
            foreach (int x in Dispend.Keys)
            {
                cost[z] = Dispend[x];
                z++;
                C.Add(Dispend[x].ToString(), x.ToString());
            }
            if (checkUp.Checked == true&&CheckDown.Checked==false)
            {
                cost = same.finalkey(cost);//去相同键值
                PaiXu paixu = new PaiXu(cost,true);
                cost=paixu.cost;//重新进行排序
                listCost.Items.Clear();//清空显示
                GetName get = new GetName();//修改添加的信息字符
                foreach (double x in cost)
                {
                  string[] name=  C.Get(x.ToString()).Split(',');//获取键值
                  if (isYear == false)
                  {
                      foreach (string zz in name)
                      {
                          int X = Convert.ToInt32(zz);
                        
                              listCost.Items.Add(get.Name(DiDay[X]) + " " + Dispend[X] + "元");
                        
                      }
                  }
                  else
                  {
                      foreach (string zz in name)
                      {
                          int X = Convert.ToInt32(zz);
                          listCost.Items.Add(GetYear + "年" + X + "月" + "   " + Dispend[X] + "元");
                        
                      }
                  }
                }

            }
            if (checkUp.Checked == false && CheckDown.Checked == true)
            {

                cost = same.finalkey(cost);//去相同键值
                PaiXu paixu = new PaiXu(cost, false);//降序
                cost = paixu.cost;//重新进行排序
                listCost.Items.Clear();//清空显示
                GetName get = new GetName();//修改添加的信息字符
                foreach (double x in cost)
                {
                    string[] name = C.Get(x.ToString()).Split(',');//获取键值
                    if (isYear == false)
                    {
                        foreach (string zz in name)
                        {
                            int X = Convert.ToInt32(zz);

                            listCost.Items.Add(get.Name(DiDay[X]) + " " + Dispend[X] + "元");

                        }
                    }
                    else
                    {
                        foreach (string zz in name)
                        {
                            int X = Convert.ToInt32(zz);
                            listCost.Items.Add(GetYear + "年" + X + "月" + "   " + Dispend[X] + "元");

                        }
                    }
                }
            }
            if (checkUp.Checked == false && CheckDown.Checked == false || checkUp.Checked == true && CheckDown.Checked == true)
            {
                MessageBox.Show("请正确选择排序方式");
            }

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            string path;
            FolderBrowserDialog open = new FolderBrowserDialog();//保存路径
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.SelectedPath;
                string txtname;
                if (isYear == false)
                    txtname = path + @"\" + GetYear + "年" + GetMonth + "月花销(简明).txt";
                else
                    txtname = path + @"\" + GetYear + "年花销(简明).txt";
                using (FileStream file = new FileStream(txtname, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(file, Encoding.UTF8))
                    {
                        foreach (string x in listCost.Items)
                        {
                            sw.WriteLine(x);
                        }
                    }

                }
                MessageBox.Show("保存成功");
            } 
        }

        private void btnOutAll_Click(object sender, EventArgs e)
        {
             string path;
             GetName get = new GetName();
            FolderBrowserDialog open = new FolderBrowserDialog();//保存路径
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.SelectedPath;
                using (FileStream file = new FileStream(path + @"\" + GetYear + "年" + GetMonth + "月花销(详细).txt", FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(file, Encoding.UTF8))
                    {
                        foreach (string x in listCost.Items)
                        {

                           string day= get.GetDay(x);

                            using (FileStream fil = new FileStream("Save" + @"\" + day+".txt", FileMode.Open))
                            {
                                sw.WriteLine(get.GetMonthDay(day));
                                StreamReader reader = new StreamReader(fil, Encoding.UTF8);
                                string nativetxt = reader.ReadToEnd();
                                string[] txt = nativetxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string xz in txt)
                                {
                                    sw.WriteLine(xz);
                                }
                                sw.WriteLine();

                            } 
                        }
                        sw.WriteLine("截至目前已花" + Coust + "元");
                    }

                }
                MessageBox.Show("保存成功");
            }
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            QuWei h = new QuWei();
            h.Cost = Coust;
            h.Limition_Month = Limition_Month;
            h.LeftMoney = LeftMoney;
            h.Year = GetYear;
            h.Month = GetMonth;
            h.Day = day;
            h.Show();
        }
    }
}

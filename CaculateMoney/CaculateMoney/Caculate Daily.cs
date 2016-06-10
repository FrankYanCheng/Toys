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
namespace CaculateMoney
{
    public partial class Caculate_Daily : Form
    {
        public Caculate_Daily()
        {
            InitializeComponent();
        }
        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public bool Exist;//判断文件是否存在
        public double Limition_Month = 0;//月度限额值
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string pathParent = "Save";
                string path = time + ".txt";
                DirectoryInfo dir = new DirectoryInfo(pathParent + @"\" + path);
                using (FileStream file = new FileStream(pathParent + @"\" + path, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(file, Encoding.UTF8))
                    {
                        string[] Section = txtMain.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                        if (Section[Section.Length - 1].Contains("总计花费"))
                        {
                            txtMain.Text = null;
                            for (int x = 0; x < Section.Length - 1; x++)
                            {
                                txtMain.AppendText(Section[x].ToString() + "\r\n");
                                sw.WriteLine(Section[x].ToString());
                            }

                          
                            CostCaculate Toatal_Caculate = new CostCaculate(Section);
                            if (Toatal_Caculate.TotalIn != 0)
                            {
                                label1.Text = "入账 " + Toatal_Caculate.TotalIn + "元";
                                TxtWriter t = new TxtWriter("InSave", Time + label1.Text, time + ".txt");                              
                            }
                            else
                            {
                                label1.Text = "";
                            }
                            double z = Toatal_Caculate.TotalCost;//需要写入的总花费数
                            sw.WriteLine("总计花费" + z.ToString() + "元");
                            txtMain.AppendText("总计花费" + z.ToString() + "元" + "\r\n");
                        }
                        else
                        {
                            for (int x = 0; x < Section.Length; x++)
                            {
                                sw.WriteLine(Section[x].ToString());
                            }
                            CostCaculate Toatal_Caculate = new CostCaculate(Section);
                            double z = Toatal_Caculate.TotalCost;//需要写入的总花费数
                            sw.WriteLine("总计花费" + z.ToString() + "元");
                            txtMain.AppendText("总计花费" + z.ToString() + "元" + "\r\n");
                        }
                    }
                }
                MessageBox.Show("保存成功");
            }
            catch
            {
            }
           

        }
        public double CostIn;//入账信息
        private void Caculate_Daily_Load(object sender, EventArgs e)
        {
            
            try
            {
                bool isToday=false;//判断可读性
                bool isCreate=false;
                if (DateTime.Now.ToLongDateString() == time)
                {
                    isToday = true;
                }
                else
                    isToday = false;
                if (isToday == true)
                {
                    txtMain.ReadOnly = false;
                }
                else
                    txtMain.ReadOnly = false;//测试用，最后设置为true
                

                string pathParent = "Save";
                string path = time + ".txt";
                DirectoryInfo dir = new DirectoryInfo(pathParent);
              FileInfo[] ZiMuRu= dir.GetFiles();
              foreach (FileInfo z in ZiMuRu)
              {
                  if (z.ToString() == path)
                  {
                      isCreate = true;
                      break;
                  }

              }

              if (isCreate == true)
              {

                  using (FileStream fil = new FileStream(pathParent + @"\" + path, FileMode.Open))
                  {
                      StreamReader reader = new StreamReader(fil, Encoding.UTF8);
                      string nativetxt = reader.ReadToEnd();
                      string[] txt = nativetxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                      foreach (string x in txt)
                      {
                          txtMain.AppendText(x + "\r\n");
                      }

                  }
              }
              else
              {
                  using (FileStream file = new FileStream(pathParent + @"\" + path, FileMode.Create, FileAccess.Write))
                  {
                  };
                  //创建文本文件
              }
            }
            catch
            {
                MessageBox.Show("不存在该日期的账款");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DailyHelperForm g = new DailyHelperForm();
            g.Show();
        }
    }
}

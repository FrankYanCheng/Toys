using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolLibrary.StudentCardTool;
using ToolLibrary;
using System.IO;
using EventLibrary;
namespace CaculateMoney
{
    public partial class GetInAllForm : Form
    {
        public GetInAllForm()
        {
            InitializeComponent();
        }
        public Dictionary<string, double> DirectIn = new Dictionary<string, double>();
        NameWay way = new NameWay();
        public int year;
        public int day;
        public int month;
        public double TotalCost;
        private void GetInAllForm_Load(object sender, EventArgs e)
        {
            foreach (string x in DirectIn.Keys)
            {
                

                listBox1.Items.Add(way.Name( x) + " "+DirectIn[x]+"元");
                TotalCost += DirectIn[x];
            }
            label1.Text = "合计进账" + TotalCost + "元";
        }
        public void AddEvent(object sender, StudentCarEventArgs e)
        {
            DirectIn = e.DirectIn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            FolderBrowserDialog open = new FolderBrowserDialog();//保存路径
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.SelectedPath;
                using (FileStream file = new FileStream(path + @"\" +year+"年"+month+"月"+"进账详细信息" + ".txt", FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(file, Encoding.UTF8))
                    {   
                        foreach (string x in listBox1.Items)
                        {
                            sw.WriteLine(x);    
                        }
                        sw.WriteLine();
                        sw.WriteLine(year + "年" + month + "月" + day+"导入");


                    }

                }
                MessageBox.Show("保存成功");
            } 
        }
    }
}

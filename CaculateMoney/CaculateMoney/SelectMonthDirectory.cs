using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CaculateMoney
{
    public partial class SelectMonthDirectory : Form
    {
        public SelectMonthDirectory()
        {
            InitializeComponent();
        }
        public string[] Direct;
        public string day;//选中日期的详细信息
        public double Limition_Month = 0;//月度限额值
        private void SelectMonthDirectory_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string c in Direct)
                {
                    listDirectory.Items.Add(c);
                }
            }
            catch
            {
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            string path;
            FolderBrowserDialog open = new FolderBrowserDialog();//保存路径
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.SelectedPath;
                using (FileStream file = new FileStream(path +@"\"+ day+".txt", FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(file, Encoding.UTF8))
                    {
                        foreach (string x in listDirectory.Items)
                        {
                            sw.WriteLine(x);
                        }


                    }

                }
                MessageBox.Show("保存成功"); 
            } 
                }
            }
            
        }
   

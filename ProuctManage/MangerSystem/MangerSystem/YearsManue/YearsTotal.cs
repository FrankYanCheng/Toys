using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileReaderLibrary;
using FormTool.AddNew;
using FormTool.MonthSave;
using FormTool.InOutMain;

namespace MangerSystem.YearsManue
{
    public partial class YearsTotal : Form
    {
        public YearsTotal()
        {
            InitializeComponent();
        }
        public string time;
        public string year;
        private void YearsTotal_Load(object sender, EventArgs e)
        {
            lblTitle.Text = year + "度总结算";
            try
            {
                FileNameBack back = new FileNameBack("ProductSave");
                string[] name = back.AllName;
                for (int i = 0; i < name.Length; i++)
                {
                    LiTotal.Items.Add(name[i]);
                }
            }
            catch
            {
            }
        }

        private void LiTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReaderFundation read = new ReaderFundation(LiTotal.Text);
                string[] reader = read.writer;
                LiName.Items.Clear();
                foreach (string x in reader)
                {
                    LiName.Items.Add(x);
                }
            }
            catch
            {
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            LiMain.Items.Clear();
            progressBar1.Value = 0;
            if (LiName.Text != "")
            {

                int count = 0;//库存查询
             
                MSReader read = new MSReader(time, LiTotal.Text, LiName.Text, MSManagerEnum.years, progressBar1);
                foreach (string x in read.MSYearsReader.Keys)
                {   
                    count += read.MSYearsReader[x];
                }
                LiMain.Items.Add(LiTotal.Text + "-" + LiName.Text + "年度库存总量 " + count);
    
                progressBar1.Value = 0;
            
                IOReader readerOut = new IOReader(time, false, LiName.Text, LiTotal.Text, progressBar1);
                LiMain.Items.Add(LiTotal.Text + "-" + LiName.Text + "进项" + readerOut.AllIn);
                LiMain.Items.Add(LiTotal.Text + "-" + LiName.Text + "销项" + readerOut.AllOut);
                count = count + readerOut.AllIn - readerOut.AllOut;
                if (count >= 0)
                    LiMain.Items.Add(LiTotal.Text + "-" + LiName.Text + "产品结余量" + count);
                else
                {
                    count = -count;
                    LiMain.Items.Add(LiTotal.Text + "-" + LiName.Text + "产品已超出" + count);
                }
                
            }
            else
            {
                MessageBox.Show("请选择产品！");
            }
        }
    }
}

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
namespace MangerSystem.YearsManue
{
    public partial class YearsKSaver : Form
    {
        public YearsKSaver()
        {
            InitializeComponent();
        }
        public string Years;//年份信息
        public string time;
        private void YearsKSaver_Load(object sender, EventArgs e)
        {
            label3.Text = Years + "度" + "月库存量查询";
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

        private void LiName_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            
            LiMain.Items.Clear();
            progressBar1.Value = 0;
            if (LiName.Text!="")
            {
                int count=0;//库存查询
                MSReader read = new MSReader(time, LiTotal.Text, LiName.Text, MSManagerEnum.years, progressBar1);
                foreach (string x in read.MSYearsReader.Keys)
                {
                    LiMain.Items.Add(x + "库存量  " + read.MSYearsReader[x]);
                    count += read.MSYearsReader[x];
                }
                LiMain.Items.Add("合计年度库存");
                LiMain.Items.Add(LiTotal.Text+"-"+LiName.Text+"库存总量 "+count);
            }
            else
            {
                MSReader read = new MSReader(time, LiTotal.Text, MSManagerEnum.years, progressBar1);
                foreach (string x in read.MSYearsReader.Keys)
                {
                    LiMain.Items.Add(x + "库存量  " + read.MSYearsReader[x]);
                }
            }
        }
    }
}

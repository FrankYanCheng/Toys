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

namespace MangerSystem.MonthManue
{
    public partial class MonthTotal : Form
    {
        public MonthTotal()
        {
            InitializeComponent();
        }
        public string time;
        public string month;
        private void MonthTotal_Load(object sender, EventArgs e)
        {
            try
            {
                lblTitle.Text = month + "结算";
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

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            LiMain.Items.Clear();
            progressBar1.Value = 0;
            if (LiName.Text != "")
            {

                int count = 0;//库存查询

                MSReader read = new MSReader(time, LiTotal.Text, LiName.Text);
                count = read.count;
                LiMain.Items.Add(LiTotal.Text + "-" + LiName.Text + "月度库存总量 " + count);

                progressBar1.Value = 0;

                IOReader readerOut = new IOReader(time, true, LiName.Text, LiTotal.Text, progressBar1);
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

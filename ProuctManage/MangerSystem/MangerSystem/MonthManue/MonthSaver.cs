using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormTool.InOutMain;
using FileReaderLibrary;
using FormTool.AddNew;
using FormTool.MonthSave;

namespace MangerSystem.MonthManue
{
    public partial class MonthSaver : Form
    {
        public MonthSaver()
        {
            InitializeComponent();
        }
        public string time;
        public string month;
        private void MonthSaver_Load(object sender, EventArgs e)
        {
            try
            {

                lblKC.Text = month+"库存量查询";
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

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            LiMain.Items.Clear();
            IOReader Superreader = new IOReader(time, true, LiName.Text, LiTotal.Text, progressBar1);
            MSReader reader = new MSReader(time, LiTotal.Text, LiName.Text);
            LiMain.Items.Add(LiTotal.Text + "-" + LiName.Text + month + "库存量为" + reader.count);
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

        private void LiName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

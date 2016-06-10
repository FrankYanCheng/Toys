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
using FormTool.InOutMain;
namespace MangerSystem.YearsManue
{
    public partial class YearsInOut : Form
    {
        public YearsInOut()
        {
            InitializeComponent();
        }
        public string time;
       

        private void YearsInOut_Load(object sender, EventArgs e)
        {
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

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            LiMain.Items.Clear();//清空数据
            if (CHin.Checked == true && CHout.Checked == false&&LiName.Text!=null)
            {
                IOReader readerIn = new IOReader(time, false, LiName.Text, LiTotal.Text, progressBar1);
                foreach (string z in readerIn.DiYearsIn.Keys)
                {
                    LiMain.Items.Add(z + " 进项" + readerIn.DiYearsIn[z]);
                }
                LiMain.Items.Add("合计进项");
                LiMain.Items.Add(LiTotal.Text+"—"+LiName.Text+readerIn.AllIn);
            }
            if (CHin.Checked == false && CHout.Checked == true&&LiName.Text != null)
            {
                IOReader readerOut = new IOReader(time, false, LiName.Text, LiTotal.Text, progressBar1);
                foreach (string z in readerOut.DiYearsOut.Keys)
                {
                    LiMain.Items.Add(z + " 销项" + readerOut.DiYearsOut[z]);
                }
                LiMain.Items.Add("合计销项");
                LiMain.Items.Add(LiTotal.Text + "—" + LiName.Text + readerOut.AllOut);
            }
            if (CHin.Checked == true && CHout.Checked == true && LiName.Text != null)
            {
                IOReader readerOut = new IOReader(time, false,LiName.Text, LiTotal.Text, progressBar1);
                foreach (string z in readerOut.DiYearsIn.Keys)
                {
                    try
                    {
                        LiMain.Items.Add(z + " 进项" + readerOut.DiYearsIn[z]);
                    }
                    catch
                    {
                    }
                }
                foreach (string z in readerOut.DiYearsOut.Keys)
                {
                    try
                    {
                        LiMain.Items.Add(z + " 销项" + readerOut.DiYearsOut[z]);
                    }
                    catch
                    {
                    }
                }
                LiMain.Items.Add("合计进销项");
                LiMain.Items.Add(LiTotal.Text + "—" + LiName.Text +"进项"+ readerOut.AllIn);
                LiMain.Items.Add(LiTotal.Text + "—" + LiName.Text + "销项" + readerOut.AllOut);

            }

            if (CHin.Checked == true && CHout.Checked == false && LiName.Text== null)
            {
                IOReader readerIn = new IOReader(time, false,LiTotal.Text, progressBar1);
                foreach (string z in readerIn.DiYearsIn.Keys)
                {
                    LiMain.Items.Add(z + " 进项" + readerIn.DiYearsIn[z]);
                }
                LiMain.Items.Add("合计进项");
                LiMain.Items.Add(LiTotal.Text + "—" + LiName.Text + readerIn.AllIn);
            }
            if (CHin.Checked == false && CHout.Checked == true && LiName.Text== null)
            {
                IOReader readerOut = new IOReader(time, false, LiTotal.Text, progressBar1);
                foreach (string z in readerOut.DiYearsOut.Keys)
                {
                    LiMain.Items.Add(z + " 销项" + readerOut.DiYearsOut[z]);
                }
                LiMain.Items.Add("合计销项");
                LiMain.Items.Add(LiTotal.Text + "—" + LiName.Text + readerOut.AllOut);
            }
            if (CHin.Checked == true && CHout.Checked == true && LiName.Text == null)
            {
                IOReader readerOut = new IOReader(time, false,LiTotal.Text, progressBar1);
                foreach (string z in readerOut.DiYearsIn.Keys)
                {
                    try
                    {
                        LiMain.Items.Add(z + " 进项" + readerOut.DiYearsIn[z]);
                    }
                    catch
                    {
                    }
                }
                foreach (string z in readerOut.DiYearsOut.Keys)
                {
                    try
                    {
                        LiMain.Items.Add(z + " 销项" + readerOut.DiYearsOut[z]);
                    }
                    catch
                    {
                    }
                }
                LiMain.Items.Add("合计进销项");
                LiMain.Items.Add(LiTotal.Text + "—" + LiName.Text + "进项" + readerOut.AllIn);
                LiMain.Items.Add(LiTotal.Text + "—" + LiName.Text + "销项" + readerOut.AllOut);

            }
            
        }
    }
}

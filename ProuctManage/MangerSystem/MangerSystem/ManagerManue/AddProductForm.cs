using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormTool.AddNew;
using FormTool;
using FileReaderLibrary;
using LogLibrary.ManagerManue;
namespace MangerSystem.ManagerManue
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //目录创建
            if (ChTotal.Checked == true && chName.Checked == false)
            {
                MTPwriter writer = new MTPwriter(txtMain.Text);
                //刷新
                try
                {
                    FileNameBack back = new FileNameBack("ProductSave");
                    LiTotal.Items.Clear();
                    string[] name = back.AllName;
                    for (int i = 0; i < name.Length; i++)
                    {
                        LiTotal.Items.Add(name[i]);
                    }
                    AddProductLog log = new AddProductLog(DateTime.Now.ToShortTimeString() + "创建目录" + txtMain.Text, DateTime.Now.ToLongDateString());
                    //添加日志类
                    txtMain.Text = null;
                }
                catch
                {
                }
            }
            //新建产品
            if (ChTotal.Checked == false && chName.Checked == true)
            {
                MTPwriter writer = new MTPwriter(LiTotal.Text, txtMain.Text, ProductEnum.add);
                //刷新
                try
                {
                    ReaderFundation read = new ReaderFundation(LiTotal.Text);
                    string[] reader = read.writer;
                    LiName.Items.Clear();
                    foreach (string x in reader)
                    {
                        LiName.Items.Add(x);
                    }
                    AddProductLog log = new AddProductLog(DateTime.Now.ToShortTimeString() + "在目录" + LiTotal.Text + "创建新产品" + txtMain.Text, DateTime.Now.ToLongDateString());
                    txtMain.Text = null;
                }
                catch
                {
                }
            }
            if((ChTotal.Checked==false&&chName.Checked==false)||(ChTotal.Checked==true&&chName.Checked==true))
            {
                MessageBox.Show("请正确选择添加方式");
            }
          
        }

        private void AddProductForm_Load(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (LiTotal.Text != null &&LiName.SelectedItems.Count == 1)
            {        
                AddProductLog log = new AddProductLog(DateTime.Now.ToShortTimeString() + "在目录" + LiTotal.Text + "清除产品" + LiName.Text, DateTime.Now.ToLongDateString());
                MTPwriter clear = new MTPwriter(LiTotal.Text, LiName.Text, ProductEnum.remove);
                //刷新
                try
                {
                    ReaderFundation read = new ReaderFundation(LiTotal.Text);
                    string[] reader = read.writer;
                    LiName.Items.Clear();
                    foreach (string x in reader)
                    {
                        LiName.Items.Add(x);
                    }
                 
                    txtMain.Text = null;
                }
                catch
                {
                }
            }
            if (LiTotal.Text != null && LiName.Text != null && LiName.SelectedItems.Count>1)
            {
                string[] zx=new string[LiName.SelectedItems.Count];
                for (int i = 0; i < LiName.SelectedItems.Count; i++)
                {
                    zx[i] = LiName.SelectedItems[i].ToString();
                }
                MTPwriter clear = new MTPwriter(LiTotal.Text,zx, ProductEnum.remove);
                try
                {
                    //刷新
                    ReaderFundation read = new ReaderFundation(LiTotal.Text);
                    string[] reader = read.writer;
                    LiName.Items.Clear();
                    foreach (string x in reader)
                    {
                        LiName.Items.Add(x);
                    }
                    for (int i = 0; i < zx.Length; i++)
                    {
                        AddProductLog log = new AddProductLog(DateTime.Now.ToShortTimeString() + "在目录" +
                            LiTotal.Text + "清除产品" + zx[i], DateTime.Now.ToLongDateString());
                    }
                    txtMain.Text = null;
                }
                catch
                {
                }
            }
            if (LiTotal.Text != null && ChTotal.Checked==true)
            {
                AddProductLog log = new AddProductLog(DateTime.Now.ToShortTimeString() + "清除目录" + LiTotal.Text, DateTime.Now.ToLongDateString());
                FileRemove remove = new FileRemove("ProductSave", LiTotal.Text);
                //刷新
                try
                {
                    FileNameBack back = new FileNameBack("ProductSave");
                    LiTotal.Items.Clear();
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
        }
    }
}

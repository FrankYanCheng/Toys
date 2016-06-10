using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileReaderLibrary;
using ToolLibrary.StringTool;
using ToolLibrary;
using LogLibrary;
using LogLibrary.ManagerManue;
using MangerSystem.ManagerManue;
using MangerSystem.InOutForm;
using FileReaderLibrary.DirectoryCreate;
using FileToolLibrary;
namespace MangerSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void 添加新产品类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm pro = new AddProductForm();
            pro.Show();

        }

        private void 选中日期进销记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InOutMainForm form = new InOutMainForm();
            string time = dateTimePicker1.Text;
            form.time = time;
            form.Text = time + "进销管理主页面";
            form.Show();
        }

        private void 月度操作记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Text;
            OprHistoryForm form = new OprHistoryForm();
            form.time = time;
            form.Show();
        }

        private void 年度进项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Text;
            YearsManue.YearsInOut yearsForm = new YearsManue.YearsInOut();
            GetTime t = new GetTime(time);
            string year = t.GetYear();
            yearsForm.Text = year + "度进销项查询";
            yearsForm.time = time;
            yearsForm.Show();

        }

        private void 产品库存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearsManue.YearsKSaver kc = new YearsManue.YearsKSaver();
            string time = dateTimePicker1.Text;

            GetTime t = new GetTime(time);
            string year = t.GetYear();
            kc.Text = year + "度月库存";
            kc.Years = year;
            kc.time = time;
            kc.Show();
        }

        private void 年度结算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearsManue.YearsTotal to = new YearsManue.YearsTotal();
            string time = dateTimePicker1.Text;
            GetTime t = new GetTime(time);
            string year = t.GetYear();
            to.year = year;
            to.Text = year + "度总结算";
            to.time = time;
            to.Show();
        }

        private void 月度进销项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthManue.MonthInOut mon = new MonthManue.MonthInOut();
            string time = dateTimePicker1.Text;
            GetTime g = new GetTime(time);
            string year = g.GetYear();
            string month = g.GetMonth();
            mon.Text = year + month + "进销项";
            mon.month = month;
            mon.time = time;
            mon.Show();


        }

        private void 产品库存ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MonthManue.MonthSaver gh = new MonthManue.MonthSaver();
            string time = dateTimePicker1.Text;
            GetTime g = new GetTime(time);
            string month = g.GetMonth();
            gh.time = time;
            gh.month = month;
            gh.Show();
        }

        private void 月度结算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthManue.MonthTotal tota = new MonthManue.MonthTotal();
            string time = dateTimePicker1.Text;
            GetTime g = new GetTime(time);
            string month = g.GetMonth();
            tota.time = time;
            tota.month = month;
            tota.Text = month + "结算";
            tota.Show();
        }



        private void 备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            FolderBrowserDialog open = new FolderBrowserDialog();//保存路径
            if (open.ShowDialog() == DialogResult.OK)
            {
                 path = open.SelectedPath;
                 //MessageBox.Show(Application.StartupPath + @"\" + "LogDiary");
                 CopyManager a = new CopyManager(Application.StartupPath + @"\" + "LogDiary", path+@"\");
                 CopyManager b = new CopyManager(Application.StartupPath + @"\" + "IOSystem", path + @"\");
                 CopyManager c = new CopyManager(Application.StartupPath + @"\" + "MSsystem", path + @"\");
                 CopyManager d = new CopyManager(Application.StartupPath + @"\" + "ProductSave", path + @"\");
                 MessageBox.Show("备份成功！");

            }
        

        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

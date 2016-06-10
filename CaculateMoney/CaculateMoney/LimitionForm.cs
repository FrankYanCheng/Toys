using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EventLibrary;
using ToolLibrary;
namespace CaculateMoney
{
    public delegate void delegateLimition(object sender,LimitionEventargs e);
    //public delegate void delegateCloseLimition(object sender, LimitionEventCloseArgs e);
    public partial class LimitionForm : Form
    {
        public LimitionForm()
        {
            InitializeComponent();
        }
        #region
        public string Year;
        public string Month;
        public string SavePath = "LiSave";
        public double Limition_Month=0;
        #endregion
        public event  delegateLimition limitionEvent;
        //public static event delegateCloseLimition limitionCloseEvent;
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double licost = Convert.ToInt32(txtLimition.Text);
                LimitionEventargs liargs = new LimitionEventargs(licost);
                limitionEvent(this, liargs);//注册事件
                string x = Year + "年" + Month + "月" + "限额 "+licost.ToString();;
                string path = Year + "年" + Month + "月" + "限额";
                TxtWriter t = new TxtWriter(SavePath,x,path);
                MessageBox.Show("修改成功");
                

            }
            catch
            {
                MessageBox.Show("请正确输入数字");
            }
        }

        private void LimitionForm_Load(object sender, EventArgs e)
        {
            txtLimition.Text = Limition_Month.ToString();
        }
        //protected override void OnClosed(EventArgs e)//重写关闭方法
        //{
        //    LimitionEventCloseArgs lc = new LimitionEventCloseArgs();
        //    limitionCloseEvent(this,lc);
        //    base.OnClosed(e);
        //}
       
    }
}

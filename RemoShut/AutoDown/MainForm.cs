using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDown
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        bool IsFirstStart=true;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <=23;i++ )
            {
                cmHour.Items.Add(i);
            }
            for (int j = 0; j <= 59;j++ )
            {
                cmMinute.Items.Add(j);
                cmSecond.Items.Add(j);
            }
            timer1.Interval = 1000;
            timer1.Tick+=timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            DateTime time=DateTime.Now;
            lblTime.Text = time.Hour+":"+time.Minute+":"+time.Second;
        }

        DateTime TargetTime;
        TimeSpan limiteTime;
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //第一次加载
                if (IsFirstStart == true)
                {
                    TargetTime = Convert.ToDateTime(cmHour.Text + ":" + cmMinute.Text + ":" + cmSecond.Text);
                    if (TargetTime < DateTime.Now)
                    {
                        TargetTime = TargetTime.AddHours(24);
                    }
                    timer2.Interval = 1000;
                    timer2.Tick += timer2_Tick;
                    timer2.Start();
                }
                else
                {
                    timer2.Start();
                }
            }
            catch
            {
                MessageBox.Show("输入的时间不对！","提示消息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (TargetTime >= DateTime.Now)
            {
                limiteTime=TargetTime-DateTime.Now;
                lblLimiteTime.Text = limiteTime.Hours + ":" + limiteTime.Minutes + ":" + limiteTime.Seconds;
            }
            else
            {
                timer2.Stop();
                new CloseComputer();
            }
        }
     

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
     
        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            FrmCon confrm = new FrmCon();
            confrm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Reflection;
using System.IO;
namespace AutoDown
{
    public partial class FrmCon : Form
    {
        public FrmCon()
        {

            InitializeComponent();
            btnLocalOpen.Enabled = false;
            btnTargetPause.Enabled = false;
            btnTargetStart.Enabled = false;
        }
        /// <summary>
        /// 存储密码方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocalOk_Click(object sender, EventArgs e)
        {
           
            if (txtLcPwd.Text.Trim() == txtLcPwdCon.Text.Trim())
            {
               StaticThings.Pwd = txtLcPwd.Text.Trim();
                //添加开放端口号
               new SecurityGurd(8888);
                btnLocalOpen.Enabled = true;
                btnLocalOk.Enabled = false;
            }
            else
            {
                MessageBox.Show("请正确输入密码");
            }
        }
        /// <summary>
        /// 远程时间倒计时调用
        /// </summary>
         DateTime TargetTime;
        /// <summary>
        /// 服务宿主
        /// </summary>
        ServiceHost host;
        /// <summary>
        /// 信道工厂
        /// </summary>
        ChannelFactory<ITarget> targetChannel;
        bool IsFirstStart=true;
        /// <summary>
        /// 开启服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ITarget proxy;

        private void btnLocalOpen_Click(object sender, EventArgs e)
        {
            try
            {
                BasicHttpBinding basicHttpBinding;

                basicHttpBinding = new BasicHttpBinding();
                basicHttpBinding.MaxBufferPoolSize = int.MaxValue;
                basicHttpBinding.MaxBufferSize = int.MaxValue;
                basicHttpBinding.MaxReceivedMessageSize = int.MaxValue;
                basicHttpBinding.ReaderQuotas.MaxArrayLength = int.MaxValue;
                basicHttpBinding.ReaderQuotas.MaxStringContentLength = int.MaxValue;
                basicHttpBinding.TransferMode = TransferMode.Streamed;
                basicHttpBinding.ReceiveTimeout = TimeSpan.MaxValue;
                basicHttpBinding.SendTimeout = TimeSpan.MaxValue;
                string ip = "http://" + new IpGet().Get() + ":8887" + "/" + "Target";
                host = new ServiceHost(typeof(Target));
               
                host.AddServiceEndpoint(typeof(ITarget), basicHttpBinding, ip);
                if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    behavior.HttpGetUrl = new Uri(ip);
                    host.Description.Behaviors.Add(behavior);
                    
                   
                }
                host.Opened += delegate
                {
                    lblIsOpen.Text = "本地服务开启";
                    btnLocalOpen.Enabled =false;
                };
                host.Open();
                 
            }
            catch
            {
                MessageBox.Show("本地服务开启错误！");
            }
        }
        /// <summary>
        /// 加载页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCon_Load(object sender, EventArgs e)
        {
            
            IpGet get = new IpGet();
            lblIp.Text = get.Get();
              timer1.Interval = 1000;
            timer1.Tick+=timer1_Tick;
            timer1.Start();
            for (int i = 0; i <= 23; i++)
            {
                cmHour.Items.Add(i);
            }
            for (int j = 0; j <= 59; j++)
            {
                cmMinute.Items.Add(j);
                cmSecond.Items.Add(j);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            DateTime time=DateTime.Now;
            lblTargetTime.Text = time.Hour+":"+time.Minute+":"+time.Second;
        }
         


        /// <summary>
        /// 连接远程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTargetCon_Click(object sender, EventArgs e)
        {

            try
            {
                BasicHttpBinding basicHttpBinding;

                basicHttpBinding = new BasicHttpBinding();
                basicHttpBinding.MaxBufferPoolSize = int.MaxValue;
                basicHttpBinding.MaxBufferSize = int.MaxValue;
                basicHttpBinding.MaxReceivedMessageSize = int.MaxValue;
                string ip="http://" + txtTargetIp.Text.Trim() + ":8888" + "/" + "Target";
                targetChannel = new ChannelFactory<ITarget>(basicHttpBinding,ip);
                 proxy = targetChannel.CreateChannel();
               if( proxy.IsPwd(txtTargetPwd.Text.Trim()))
               {
                   MessageBox.Show("连接成功");
                   btnTargetCon.Enabled = false;
                   btnTargetStart.Enabled = true;
                   btnTargetPause.Enabled = true;
               }
               else
               {
                   MessageBox.Show("密码错误");
               }

            }
            catch
            {
                MessageBox.Show("连接失败");
            }
            
        }

        private void btnTargetStart_Click(object sender, EventArgs e)
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
                    btnTargetStart.Enabled = false;
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
            TimeSpan limiteTime;
            if (TargetTime >= DateTime.Now)
            {
                limiteTime=TargetTime-DateTime.Now;
                  lblLimiteTime.Text = limiteTime.Hours + ":" + limiteTime.Minutes + ":" + limiteTime.Seconds;
            }
            else
            {
                timer2.Stop();
                proxy.TimeDown();
            }
        }

        private void btnTargetPause_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            btnTargetStart.Enabled = true;
        }
      
        private void lblTargetWin_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();//保存路径
            if (open.ShowDialog() == DialogResult.OK)
            {
              StaticThings.path= open.SelectedPath;
            }
            byte[] buff = proxy.Draw();
            FileStream stream = File.Create(StaticThings.path + @"\" +"远程桌面截图"+".Bmp");//生成文件
            BinaryWriter write = new BinaryWriter(stream);
            write.Write(buff, 0, buff.Length);
            stream.Close();
            MessageBox.Show("截图成功");

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      
    }
}


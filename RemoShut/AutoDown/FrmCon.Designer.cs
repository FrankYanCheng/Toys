namespace AutoDown
{
    partial class FrmCon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCon));
            this.txtTargetIp = new System.Windows.Forms.TextBox();
            this.btnLocalOpen = new System.Windows.Forms.Button();
            this.btnTargetCon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmSecond = new System.Windows.Forms.ComboBox();
            this.lblTargetTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmMinute = new System.Windows.Forms.ComboBox();
            this.cmHour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIsOpen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLcPwdCon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLocalOk = new System.Windows.Forms.Button();
            this.txtLcPwd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLimiteTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTargetPwd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTargetPause = new System.Windows.Forms.Button();
            this.btnTargetStart = new System.Windows.Forms.Button();
            this.lblTargetWin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnHide = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTargetIp
            // 
            this.txtTargetIp.Location = new System.Drawing.Point(100, 37);
            this.txtTargetIp.Name = "txtTargetIp";
            this.txtTargetIp.Size = new System.Drawing.Size(171, 21);
            this.txtTargetIp.TabIndex = 2;
            // 
            // btnLocalOpen
            // 
            this.btnLocalOpen.Location = new System.Drawing.Point(118, 58);
            this.btnLocalOpen.Name = "btnLocalOpen";
            this.btnLocalOpen.Size = new System.Drawing.Size(64, 25);
            this.btnLocalOpen.TabIndex = 4;
            this.btnLocalOpen.Text = "开启";
            this.btnLocalOpen.UseVisualStyleBackColor = true;
            this.btnLocalOpen.Click += new System.EventHandler(this.btnLocalOpen_Click);
            // 
            // btnTargetCon
            // 
            this.btnTargetCon.Location = new System.Drawing.Point(302, 34);
            this.btnTargetCon.Name = "btnTargetCon";
            this.btnTargetCon.Size = new System.Drawing.Size(64, 25);
            this.btnTargetCon.TabIndex = 5;
            this.btnTargetCon.Text = "连接";
            this.btnTargetCon.UseVisualStyleBackColor = true;
            this.btnTargetCon.Click += new System.EventHandler(this.btnTargetCon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "秒";
            // 
            // cmSecond
            // 
            this.cmSecond.FormattingEnabled = true;
            this.cmSecond.Location = new System.Drawing.Point(285, 152);
            this.cmSecond.Name = "cmSecond";
            this.cmSecond.Size = new System.Drawing.Size(54, 20);
            this.cmSecond.TabIndex = 23;
            // 
            // lblTargetTime
            // 
            this.lblTargetTime.AutoSize = true;
            this.lblTargetTime.Location = new System.Drawing.Point(115, 104);
            this.lblTargetTime.Name = "lblTargetTime";
            this.lblTargetTime.Size = new System.Drawing.Size(53, 12);
            this.lblTargetTime.TabIndex = 22;
            this.lblTargetTime.Text = "显示时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "当前时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "时";
            // 
            // cmMinute
            // 
            this.cmMinute.FormattingEnabled = true;
            this.cmMinute.Location = new System.Drawing.Point(196, 152);
            this.cmMinute.Name = "cmMinute";
            this.cmMinute.Size = new System.Drawing.Size(60, 20);
            this.cmMinute.TabIndex = 18;
            // 
            // cmHour
            // 
            this.cmHour.FormattingEnabled = true;
            this.cmHour.Location = new System.Drawing.Point(112, 152);
            this.cmHour.Name = "cmHour";
            this.cmHour.Size = new System.Drawing.Size(55, 20);
            this.cmHour.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "设定自动关机时限";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "本地服务";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "本地Ip:";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(116, 38);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(65, 12);
            this.lblIp.TabIndex = 27;
            this.lblIp.Text = "本地Ip显示";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "远程ip";
            // 
            // lblIsOpen
            // 
            this.lblIsOpen.AutoSize = true;
            this.lblIsOpen.Location = new System.Drawing.Point(289, 58);
            this.lblIsOpen.Name = "lblIsOpen";
            this.lblIsOpen.Size = new System.Drawing.Size(89, 12);
            this.lblIsOpen.TabIndex = 29;
            this.lblIsOpen.Text = "本地服务未开启";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLcPwdCon);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnLocalOk);
            this.groupBox1.Controls.Add(this.txtLcPwd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnLocalOpen);
            this.groupBox1.Controls.Add(this.lblIsOpen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblIp);
            this.groupBox1.Location = new System.Drawing.Point(73, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 151);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "本地服务";
            // 
            // txtLcPwdCon
            // 
            this.txtLcPwdCon.Location = new System.Drawing.Point(117, 116);
            this.txtLcPwdCon.Name = "txtLcPwdCon";
            this.txtLcPwdCon.PasswordChar = '*';
            this.txtLcPwdCon.Size = new System.Drawing.Size(154, 21);
            this.txtLcPwdCon.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 34;
            this.label12.Text = "确认密码";
            // 
            // btnLocalOk
            // 
            this.btnLocalOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLocalOk.Location = new System.Drawing.Point(293, 85);
            this.btnLocalOk.Name = "btnLocalOk";
            this.btnLocalOk.Size = new System.Drawing.Size(64, 25);
            this.btnLocalOk.TabIndex = 33;
            this.btnLocalOk.Text = "确定";
            this.btnLocalOk.UseVisualStyleBackColor = true;
            this.btnLocalOk.Click += new System.EventHandler(this.btnLocalOk_Click);
            // 
            // txtLcPwd
            // 
            this.txtLcPwd.Location = new System.Drawing.Point(117, 89);
            this.txtLcPwd.Name = "txtLcPwd";
            this.txtLcPwd.PasswordChar = '*';
            this.txtLcPwd.Size = new System.Drawing.Size(154, 21);
            this.txtLcPwd.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 12);
            this.label11.TabIndex = 30;
            this.label11.Text = "设置远程关机密码";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHide);
            this.groupBox2.Controls.Add(this.lblLimiteTime);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTargetPwd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnTargetPause);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnTargetStart);
            this.groupBox2.Controls.Add(this.btnTargetCon);
            this.groupBox2.Controls.Add(this.lblTargetWin);
            this.groupBox2.Controls.Add(this.txtTargetIp);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblTargetTime);
            this.groupBox2.Controls.Add(this.cmSecond);
            this.groupBox2.Controls.Add(this.cmHour);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmMinute);
            this.groupBox2.Location = new System.Drawing.Point(73, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 255);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "远程服务";
            // 
            // lblLimiteTime
            // 
            this.lblLimiteTime.AutoSize = true;
            this.lblLimiteTime.Location = new System.Drawing.Point(116, 220);
            this.lblLimiteTime.Name = "lblLimiteTime";
            this.lblLimiteTime.Size = new System.Drawing.Size(53, 12);
            this.lblLimiteTime.TabIndex = 37;
            this.lblLimiteTime.Text = "显示时间";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "剩余时间";
            // 
            // txtTargetPwd
            // 
            this.txtTargetPwd.Location = new System.Drawing.Point(100, 68);
            this.txtTargetPwd.Name = "txtTargetPwd";
            this.txtTargetPwd.PasswordChar = '*';
            this.txtTargetPwd.Size = new System.Drawing.Size(171, 21);
            this.txtTargetPwd.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "远程密码";
            // 
            // btnTargetPause
            // 
            this.btnTargetPause.Location = new System.Drawing.Point(215, 192);
            this.btnTargetPause.Name = "btnTargetPause";
            this.btnTargetPause.Size = new System.Drawing.Size(64, 25);
            this.btnTargetPause.TabIndex = 33;
            this.btnTargetPause.Text = "暂停";
            this.btnTargetPause.UseVisualStyleBackColor = true;
            this.btnTargetPause.Click += new System.EventHandler(this.btnTargetPause_Click);
            // 
            // btnTargetStart
            // 
            this.btnTargetStart.Location = new System.Drawing.Point(117, 192);
            this.btnTargetStart.Name = "btnTargetStart";
            this.btnTargetStart.Size = new System.Drawing.Size(64, 25);
            this.btnTargetStart.TabIndex = 32;
            this.btnTargetStart.Text = "开始";
            this.btnTargetStart.UseVisualStyleBackColor = true;
            this.btnTargetStart.Click += new System.EventHandler(this.btnTargetStart_Click);
            // 
            // lblTargetWin
            // 
            this.lblTargetWin.AutoSize = true;
            this.lblTargetWin.Location = new System.Drawing.Point(302, 98);
            this.lblTargetWin.Name = "lblTargetWin";
            this.lblTargetWin.Size = new System.Drawing.Size(64, 25);
            this.lblTargetWin.TabIndex = 30;
            this.lblTargetWin.Text = "远程截图";
            this.lblTargetWin.UseVisualStyleBackColor = true;
            this.lblTargetWin.Click += new System.EventHandler(this.lblTargetWin_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(309, 194);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(69, 23);
            this.btnHide.TabIndex = 36;
            this.btnHide.Text = "隐藏界面";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // FrmCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(579, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "远程关机设置";
            this.Load += new System.EventHandler(this.FrmCon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTargetIp;
        private System.Windows.Forms.Button btnLocalOpen;
        private System.Windows.Forms.Button btnTargetCon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmSecond;
        private System.Windows.Forms.Label lblTargetTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmMinute;
        private System.Windows.Forms.ComboBox cmHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIsOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button lblTargetWin;
        private System.Windows.Forms.Button btnTargetPause;
        private System.Windows.Forms.Button btnTargetStart;
        private System.Windows.Forms.TextBox txtLcPwdCon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLocalOk;
        private System.Windows.Forms.TextBox txtLcPwd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTargetPwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblLimiteTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHide;
    }
}
namespace AutoDown
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cmHour = new System.Windows.Forms.ComboBox();
            this.cmMinute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDescLi = new System.Windows.Forms.Label();
            this.lblLimiteTime = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cmSecond = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设定自动关机时限";
            // 
            // cmHour
            // 
            this.cmHour.FormattingEnabled = true;
            this.cmHour.Location = new System.Drawing.Point(136, 62);
            this.cmHour.Name = "cmHour";
            this.cmHour.Size = new System.Drawing.Size(80, 20);
            this.cmHour.TabIndex = 1;
            // 
            // cmMinute
            // 
            this.cmMinute.FormattingEnabled = true;
            this.cmMinute.Location = new System.Drawing.Point(258, 62);
            this.cmMinute.Name = "cmMinute";
            this.cmMinute.Size = new System.Drawing.Size(80, 20);
            this.cmMinute.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "时";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "分";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "当前时间";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(38, 112);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(141, 112);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 9;
            this.btnHide.Text = "隐藏";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(134, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "显示时间";
            // 
            // lblDescLi
            // 
            this.lblDescLi.AutoSize = true;
            this.lblDescLi.Location = new System.Drawing.Point(47, 166);
            this.lblDescLi.Name = "lblDescLi";
            this.lblDescLi.Size = new System.Drawing.Size(77, 12);
            this.lblDescLi.TabIndex = 11;
            this.lblDescLi.Text = "距离关机还有";
            // 
            // lblLimiteTime
            // 
            this.lblLimiteTime.AutoSize = true;
            this.lblLimiteTime.Location = new System.Drawing.Point(158, 166);
            this.lblLimiteTime.Name = "lblLimiteTime";
            this.lblLimiteTime.Size = new System.Drawing.Size(77, 12);
            this.lblLimiteTime.TabIndex = 12;
            this.lblLimiteTime.Text = "显示关机时间";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(237, 112);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // cmSecond
            // 
            this.cmSecond.FormattingEnabled = true;
            this.cmSecond.Location = new System.Drawing.Point(367, 62);
            this.cmSecond.Name = "cmSecond";
            this.cmSecond.Size = new System.Drawing.Size(80, 20);
            this.cmSecond.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "秒";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(337, 112);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(101, 23);
            this.btnConnect.TabIndex = 16;
            this.btnConnect.Text = "远程遥控关机";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(518, 221);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmSecond);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblLimiteTime);
            this.Controls.Add(this.lblDescLi);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmMinute);
            this.Controls.Add(this.cmHour);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动关机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmHour;
        private System.Windows.Forms.ComboBox cmMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDescLi;
        private System.Windows.Forms.Label lblLimiteTime;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox cmSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnect;
    }
}


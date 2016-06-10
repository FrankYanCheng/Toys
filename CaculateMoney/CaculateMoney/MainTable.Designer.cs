namespace CaculateMoney
{
    partial class MainTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTable));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.该月累计消费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.年度消费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.月度限额ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生卡设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBianJi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询ToolStripMenuItem,
            this.月度限额ToolStripMenuItem,
            this.学生卡设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.该月累计消费ToolStripMenuItem,
            this.年度消费ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 该月累计消费ToolStripMenuItem
            // 
            this.该月累计消费ToolStripMenuItem.Name = "该月累计消费ToolStripMenuItem";
            this.该月累计消费ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.该月累计消费ToolStripMenuItem.Text = "该月累计消费";
            this.该月累计消费ToolStripMenuItem.Click += new System.EventHandler(this.该月累计消费ToolStripMenuItem_Click);
            // 
            // 年度消费ToolStripMenuItem
            // 
            this.年度消费ToolStripMenuItem.Name = "年度消费ToolStripMenuItem";
            this.年度消费ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.年度消费ToolStripMenuItem.Text = "年度消费";
            this.年度消费ToolStripMenuItem.Click += new System.EventHandler(this.年度消费ToolStripMenuItem_Click);
            // 
            // 月度限额ToolStripMenuItem
            // 
            this.月度限额ToolStripMenuItem.Name = "月度限额ToolStripMenuItem";
            this.月度限额ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.月度限额ToolStripMenuItem.Text = "月度限额";
            this.月度限额ToolStripMenuItem.Click += new System.EventHandler(this.月度限额ToolStripMenuItem_Click);
            // 
            // 学生卡设置ToolStripMenuItem
            // 
            this.学生卡设置ToolStripMenuItem.Name = "学生卡设置ToolStripMenuItem";
            this.学生卡设置ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.学生卡设置ToolStripMenuItem.Text = "学生卡设置";
            this.学生卡设置ToolStripMenuItem.Click += new System.EventHandler(this.学生卡设置ToolStripMenuItem_Click);
            // 
            // btnBianJi
            // 
            this.btnBianJi.Location = new System.Drawing.Point(250, 34);
            this.btnBianJi.Name = "btnBianJi";
            this.btnBianJi.Size = new System.Drawing.Size(85, 25);
            this.btnBianJi.TabIndex = 2;
            this.btnBianJi.Text = "编辑";
            this.btnBianJi.UseVisualStyleBackColor = true;
            this.btnBianJi.Click += new System.EventHandler(this.btnBianJi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CaculateMoney.Properties.Resources._20101022093506335;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "月度限额";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(250, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 221);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBianJi);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainTable";
            this.Text = "记账主界面";
            this.Load += new System.EventHandler(this.MainTable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 该月累计消费ToolStripMenuItem;
        private System.Windows.Forms.Button btnBianJi;
        private System.Windows.Forms.ToolStripMenuItem 年度消费ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 月度限额ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem 学生卡设置ToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;

    }
}


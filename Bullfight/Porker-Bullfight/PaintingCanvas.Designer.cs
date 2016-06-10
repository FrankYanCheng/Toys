namespace Porker_Bullfight
{
    partial class PaintingCanvas
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
            this.btnShuffle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.cplayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.numLic = new System.Windows.Forms.NumericUpDown();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnPorkerNumber = new System.Windows.Forms.Button();
            this.numPorkerNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorkerNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(1268, 45);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 0;
            this.btnShuffle.Text = "洗牌";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1273, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "游戏人数";
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cplayer,
            this.cscore,
            this.cCount,
            this.cWin,
            this.cTimes});
            this.dgView.Location = new System.Drawing.Point(877, 45);
            this.dgView.Name = "dgView";
            this.dgView.RowTemplate.Height = 23;
            this.dgView.Size = new System.Drawing.Size(341, 434);
            this.dgView.TabIndex = 2;
            // 
            // cplayer
            // 
            this.cplayer.HeaderText = "游戏玩家";
            this.cplayer.Name = "cplayer";
            this.cplayer.ReadOnly = true;
            this.cplayer.Width = 80;
            // 
            // cscore
            // 
            this.cscore.HeaderText = "游戏积分";
            this.cscore.Name = "cscore";
            this.cscore.ReadOnly = true;
            this.cscore.Width = 50;
            // 
            // cCount
            // 
            this.cCount.HeaderText = "点数";
            this.cCount.Name = "cCount";
            this.cCount.ReadOnly = true;
            this.cCount.Width = 50;
            // 
            // cWin
            // 
            this.cWin.HeaderText = "本轮结果";
            this.cWin.Name = "cWin";
            this.cWin.ReadOnly = true;
            this.cWin.Width = 50;
            // 
            // cTimes
            // 
            this.cTimes.HeaderText = "押金倍数";
            this.cTimes.Name = "cTimes";
            this.cTimes.ReadOnly = true;
            this.cTimes.Width = 50;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(1268, 94);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "发牌";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1268, 145);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numLic
            // 
            this.numLic.Location = new System.Drawing.Point(1275, 198);
            this.numLic.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLic.Name = "numLic";
            this.numLic.Size = new System.Drawing.Size(68, 21);
            this.numLic.TabIndex = 6;
            // 
            // picMain
            // 
            this.picMain.Location = new System.Drawing.Point(0, -1);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(850, 750);
            this.picMain.TabIndex = 7;
            this.picMain.TabStop = false;
            this.picMain.Paint += new System.Windows.Forms.PaintEventHandler(this.picMain_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(875, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "记分板";
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(877, 562);
            this.numScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(75, 21);
            this.numScore.TabIndex = 9;
            this.numScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(875, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "游戏玩家押注";
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(877, 612);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(85, 23);
            this.btnScore.TabIndex = 11;
            this.btnScore.Text = "更改押注金额";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnPorkerNumber
            // 
            this.btnPorkerNumber.Location = new System.Drawing.Point(1010, 612);
            this.btnPorkerNumber.Name = "btnPorkerNumber";
            this.btnPorkerNumber.Size = new System.Drawing.Size(85, 23);
            this.btnPorkerNumber.TabIndex = 13;
            this.btnPorkerNumber.Text = "副数更改";
            this.btnPorkerNumber.UseVisualStyleBackColor = true;
            this.btnPorkerNumber.Click += new System.EventHandler(this.btnPorkerNumber_Click);
            // 
            // numPorkerNumber
            // 
            this.numPorkerNumber.Location = new System.Drawing.Point(1010, 562);
            this.numPorkerNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPorkerNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPorkerNumber.Name = "numPorkerNumber";
            this.numPorkerNumber.Size = new System.Drawing.Size(75, 21);
            this.numPorkerNumber.TabIndex = 12;
            this.numPorkerNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1008, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "扑克副数";
            // 
            // PaintingCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPorkerNumber);
            this.Controls.Add(this.numPorkerNumber);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.numLic);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShuffle);
            this.Name = "PaintingCanvas";
            this.Text = "MainBoss";
            this.Load += new System.EventHandler(this.PaintingCanvas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorkerNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numLic;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cplayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cWin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTimes;
        private System.Windows.Forms.Button btnPorkerNumber;
        private System.Windows.Forms.NumericUpDown numPorkerNumber;
        private System.Windows.Forms.Label label4;

    }
}


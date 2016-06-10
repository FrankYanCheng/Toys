namespace GuessNumber
{
    partial class Guess
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
            this.pl = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.Location = new System.Drawing.Point(41, 38);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(276, 306);
            this.pl.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(41, 386);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 12);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "累计分数";
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 427);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pl);
            this.Name = "Guess";
            this.Text = "GuessNumber";
            this.Load += new System.EventHandler(this.Guess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.Label lblScore;
    }
}


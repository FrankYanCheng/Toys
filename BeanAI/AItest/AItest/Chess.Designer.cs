﻿namespace AItest
{
    partial class Chess
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
            this.panGraphic = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panGraphic
            // 
            this.panGraphic.Location = new System.Drawing.Point(4, 5);
            this.panGraphic.Name = "panGraphic";
            this.panGraphic.Size = new System.Drawing.Size(800, 600);
            this.panGraphic.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(819, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 396);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panGraphic);
            this.Name = "Chess";
            this.Text = "五子棋";
            this.Load += new System.EventHandler(this.Chess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panGraphic;
        private System.Windows.Forms.Button btnStart;
    }
}


namespace MangerSystem.MonthManue
{
    partial class MonthSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthSaver));
            this.lblKC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LiMain = new System.Windows.Forms.ListBox();
            this.LiName = new System.Windows.Forms.ListBox();
            this.LiTotal = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKC
            // 
            this.lblKC.AutoSize = true;
            this.lblKC.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblKC.ForeColor = System.Drawing.Color.Red;
            this.lblKC.Location = new System.Drawing.Point(645, 9);
            this.lblKC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKC.Name = "lblKC";
            this.lblKC.Size = new System.Drawing.Size(225, 35);
            this.lblKC.TabIndex = 21;
            this.lblKC.Text = "月库存量查询";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(318, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "产品";
            // 
            // LiMain
            // 
            this.LiMain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LiMain.FormattingEnabled = true;
            this.LiMain.HorizontalScrollbar = true;
            this.LiMain.ItemHeight = 16;
            this.LiMain.Location = new System.Drawing.Point(634, 61);
            this.LiMain.Margin = new System.Windows.Forms.Padding(5);
            this.LiMain.Name = "LiMain";
            this.LiMain.ScrollAlwaysVisible = true;
            this.LiMain.Size = new System.Drawing.Size(276, 340);
            this.LiMain.TabIndex = 18;
            // 
            // LiName
            // 
            this.LiName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LiName.FormattingEnabled = true;
            this.LiName.ItemHeight = 16;
            this.LiName.Location = new System.Drawing.Point(320, 61);
            this.LiName.Margin = new System.Windows.Forms.Padding(5);
            this.LiName.Name = "LiName";
            this.LiName.ScrollAlwaysVisible = true;
            this.LiName.Size = new System.Drawing.Size(262, 340);
            this.LiName.TabIndex = 17;
            this.LiName.SelectedIndexChanged += new System.EventHandler(this.LiName_SelectedIndexChanged);
            // 
            // LiTotal
            // 
            this.LiTotal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LiTotal.FormattingEnabled = true;
            this.LiTotal.ItemHeight = 16;
            this.LiTotal.Location = new System.Drawing.Point(47, 56);
            this.LiTotal.Margin = new System.Windows.Forms.Padding(5);
            this.LiTotal.Name = "LiTotal";
            this.LiTotal.ScrollAlwaysVisible = true;
            this.LiTotal.Size = new System.Drawing.Size(223, 340);
            this.LiTotal.TabIndex = 16;
            this.LiTotal.SelectedIndexChanged += new System.EventHandler(this.LiTotal_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 422);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(870, 39);
            this.progressBar1.TabIndex = 22;
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(938, 422);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(100, 41);
            this.btnLookUp.TabIndex = 23;
            this.btnLookUp.Text = "查询";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MangerSystem.Properties.Resources.MainPicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1050, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // MonthSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 473);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblKC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LiMain);
            this.Controls.Add(this.LiName);
            this.Controls.Add(this.LiTotal);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MonthSaver";
            this.Text = "MonthSaver";
            this.Load += new System.EventHandler(this.MonthSaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LiMain;
        private System.Windows.Forms.ListBox LiName;
        private System.Windows.Forms.ListBox LiTotal;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}
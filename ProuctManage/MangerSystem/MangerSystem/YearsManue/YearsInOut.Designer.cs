namespace MangerSystem.YearsManue
{
    partial class YearsInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearsInOut));
            this.LiTotal = new System.Windows.Forms.ListBox();
            this.LiName = new System.Windows.Forms.ListBox();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LiMain = new System.Windows.Forms.ListBox();
            this.laMuru = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CHout = new System.Windows.Forms.CheckBox();
            this.CHin = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LiTotal
            // 
            this.LiTotal.FormattingEnabled = true;
            this.LiTotal.ItemHeight = 16;
            this.LiTotal.Location = new System.Drawing.Point(24, 34);
            this.LiTotal.Margin = new System.Windows.Forms.Padding(4);
            this.LiTotal.Name = "LiTotal";
            this.LiTotal.ScrollAlwaysVisible = true;
            this.LiTotal.Size = new System.Drawing.Size(168, 260);
            this.LiTotal.TabIndex = 0;
            this.LiTotal.SelectedIndexChanged += new System.EventHandler(this.LiTotal_SelectedIndexChanged);
            // 
            // LiName
            // 
            this.LiName.FormattingEnabled = true;
            this.LiName.ItemHeight = 16;
            this.LiName.Location = new System.Drawing.Point(252, 34);
            this.LiName.Margin = new System.Windows.Forms.Padding(4);
            this.LiName.Name = "LiName";
            this.LiName.ScrollAlwaysVisible = true;
            this.LiName.Size = new System.Drawing.Size(179, 260);
            this.LiName.TabIndex = 1;
            // 
            // btnLookUp
            // 
            this.btnLookUp.ForeColor = System.Drawing.Color.Black;
            this.btnLookUp.Location = new System.Drawing.Point(891, 317);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(101, 36);
            this.btnLookUp.TabIndex = 2;
            this.btnLookUp.Text = "查询";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 317);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(824, 36);
            this.progressBar1.TabIndex = 3;
            // 
            // LiMain
            // 
            this.LiMain.FormattingEnabled = true;
            this.LiMain.HorizontalScrollbar = true;
            this.LiMain.ItemHeight = 16;
            this.LiMain.Location = new System.Drawing.Point(496, 34);
            this.LiMain.Margin = new System.Windows.Forms.Padding(4);
            this.LiMain.Name = "LiMain";
            this.LiMain.ScrollAlwaysVisible = true;
            this.LiMain.Size = new System.Drawing.Size(366, 260);
            this.LiMain.TabIndex = 4;
            // 
            // laMuru
            // 
            this.laMuru.AutoSize = true;
            this.laMuru.Location = new System.Drawing.Point(35, 9);
            this.laMuru.Name = "laMuru";
            this.laMuru.Size = new System.Drawing.Size(40, 16);
            this.laMuru.TabIndex = 5;
            this.laMuru.Text = "目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "产品";
            // 
            // CHout
            // 
            this.CHout.AutoSize = true;
            this.CHout.Location = new System.Drawing.Point(903, 268);
            this.CHout.Name = "CHout";
            this.CHout.Size = new System.Drawing.Size(91, 20);
            this.CHout.TabIndex = 7;
            this.CHout.Text = "年度销项";
            this.CHout.UseVisualStyleBackColor = true;
            // 
            // CHin
            // 
            this.CHin.AutoSize = true;
            this.CHin.Location = new System.Drawing.Point(903, 228);
            this.CHin.Name = "CHin";
            this.CHin.Size = new System.Drawing.Size(91, 20);
            this.CHin.TabIndex = 8;
            this.CHin.Text = "年度进项";
            this.CHin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MangerSystem.Properties.Resources.MainPicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // YearsInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 365);
            this.Controls.Add(this.CHin);
            this.Controls.Add(this.CHout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laMuru);
            this.Controls.Add(this.LiMain);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.LiName);
            this.Controls.Add(this.LiTotal);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YearsInOut";
            this.Text = "YearsInOut";
            this.Load += new System.EventHandler(this.YearsInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LiTotal;
        private System.Windows.Forms.ListBox LiName;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox LiMain;
        private System.Windows.Forms.Label laMuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CHout;
        private System.Windows.Forms.CheckBox CHin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
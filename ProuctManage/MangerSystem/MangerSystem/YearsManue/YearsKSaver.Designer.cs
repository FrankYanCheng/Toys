namespace MangerSystem.YearsManue
{
    partial class YearsKSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearsKSaver));
            this.label2 = new System.Windows.Forms.Label();
            this.laMuru = new System.Windows.Forms.Label();
            this.LiMain = new System.Windows.Forms.ListBox();
            this.LiName = new System.Windows.Forms.ListBox();
            this.LiTotal = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "产品";
            // 
            // laMuru
            // 
            this.laMuru.AutoSize = true;
            this.laMuru.Location = new System.Drawing.Point(-47, -12);
            this.laMuru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laMuru.Name = "laMuru";
            this.laMuru.Size = new System.Drawing.Size(40, 16);
            this.laMuru.TabIndex = 10;
            this.laMuru.Text = "目录";
            // 
            // LiMain
            // 
            this.LiMain.FormattingEnabled = true;
            this.LiMain.HorizontalScrollbar = true;
            this.LiMain.ItemHeight = 16;
            this.LiMain.Location = new System.Drawing.Point(604, 73);
            this.LiMain.Margin = new System.Windows.Forms.Padding(5);
            this.LiMain.Name = "LiMain";
            this.LiMain.ScrollAlwaysVisible = true;
            this.LiMain.Size = new System.Drawing.Size(276, 324);
            this.LiMain.TabIndex = 9;
            // 
            // LiName
            // 
            this.LiName.FormattingEnabled = true;
            this.LiName.ItemHeight = 16;
            this.LiName.Location = new System.Drawing.Point(291, 68);
            this.LiName.Margin = new System.Windows.Forms.Padding(5);
            this.LiName.Name = "LiName";
            this.LiName.ScrollAlwaysVisible = true;
            this.LiName.Size = new System.Drawing.Size(262, 340);
            this.LiName.TabIndex = 8;
            this.LiName.SelectedIndexChanged += new System.EventHandler(this.LiName_SelectedIndexChanged);
            // 
            // LiTotal
            // 
            this.LiTotal.FormattingEnabled = true;
            this.LiTotal.ItemHeight = 16;
            this.LiTotal.Location = new System.Drawing.Point(17, 68);
            this.LiTotal.Margin = new System.Windows.Forms.Padding(5);
            this.LiTotal.Name = "LiTotal";
            this.LiTotal.ScrollAlwaysVisible = true;
            this.LiTotal.Size = new System.Drawing.Size(223, 340);
            this.LiTotal.TabIndex = 7;
            this.LiTotal.SelectedIndexChanged += new System.EventHandler(this.LiTotal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "目录";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 421);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(703, 36);
            this.progressBar1.TabIndex = 13;
            // 
            // btnLookUp
            // 
            this.btnLookUp.ForeColor = System.Drawing.Color.Black;
            this.btnLookUp.Location = new System.Drawing.Point(779, 421);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(101, 36);
            this.btnLookUp.TabIndex = 14;
            this.btnLookUp.Text = "查询";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(454, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "年度月库存量查询";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MangerSystem.Properties.Resources.MainPicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(967, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // YearsKSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laMuru);
            this.Controls.Add(this.LiMain);
            this.Controls.Add(this.LiName);
            this.Controls.Add(this.LiTotal);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YearsKSaver";
            this.Text = "YearsKSaver";
            this.Load += new System.EventHandler(this.YearsKSaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laMuru;
        private System.Windows.Forms.ListBox LiMain;
        private System.Windows.Forms.ListBox LiName;
        private System.Windows.Forms.ListBox LiTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
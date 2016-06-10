namespace MangerSystem.YearsManue
{
    partial class YearsTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearsTotal));
            this.label2 = new System.Windows.Forms.Label();
            this.laMuru = new System.Windows.Forms.Label();
            this.LiMain = new System.Windows.Forms.ListBox();
            this.LiName = new System.Windows.Forms.ListBox();
            this.LiTotal = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "产品";
            // 
            // laMuru
            // 
            this.laMuru.AutoSize = true;
            this.laMuru.Location = new System.Drawing.Point(55, 54);
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
            this.LiMain.Location = new System.Drawing.Point(554, 75);
            this.LiMain.Margin = new System.Windows.Forms.Padding(5);
            this.LiMain.Name = "LiMain";
            this.LiMain.ScrollAlwaysVisible = true;
            this.LiMain.Size = new System.Drawing.Size(273, 340);
            this.LiMain.TabIndex = 9;
            // 
            // LiName
            // 
            this.LiName.FormattingEnabled = true;
            this.LiName.ItemHeight = 16;
            this.LiName.Location = new System.Drawing.Point(308, 75);
            this.LiName.Margin = new System.Windows.Forms.Padding(5);
            this.LiName.Name = "LiName";
            this.LiName.ScrollAlwaysVisible = true;
            this.LiName.Size = new System.Drawing.Size(221, 340);
            this.LiName.TabIndex = 8;
            // 
            // LiTotal
            // 
            this.LiTotal.FormattingEnabled = true;
            this.LiTotal.ItemHeight = 16;
            this.LiTotal.Location = new System.Drawing.Point(38, 75);
            this.LiTotal.Margin = new System.Windows.Forms.Padding(5);
            this.LiTotal.Name = "LiTotal";
            this.LiTotal.ScrollAlwaysVisible = true;
            this.LiTotal.Size = new System.Drawing.Size(207, 340);
            this.LiTotal.TabIndex = 7;
            this.LiTotal.SelectedIndexChanged += new System.EventHandler(this.LiTotal_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(590, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 35);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "年度总结算";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(722, 428);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(105, 40);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Text = "查询";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 438);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(671, 30);
            this.progressBar1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MangerSystem.Properties.Resources.MainPicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // YearsTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 501);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laMuru);
            this.Controls.Add(this.LiMain);
            this.Controls.Add(this.LiName);
            this.Controls.Add(this.LiTotal);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YearsTotal";
            this.Text = "YearsTotal";
            this.Load += new System.EventHandler(this.YearsTotal_Load);
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
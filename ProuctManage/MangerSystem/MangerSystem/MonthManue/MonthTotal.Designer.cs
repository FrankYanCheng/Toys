namespace MangerSystem.MonthManue
{
    partial class MonthTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthTotal));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtSearch = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laMuru = new System.Windows.Forms.Label();
            this.LiMain = new System.Windows.Forms.ListBox();
            this.LiName = new System.Windows.Forms.ListBox();
            this.LiTotal = new System.Windows.Forms.ListBox();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-3, 373);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(724, 40);
            this.progressBar1.TabIndex = 23;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1287, 544);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(161, 53);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.Text = "查询";
            this.txtSearch.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(467, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 35);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "月度总结算";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "产品";
            // 
            // laMuru
            // 
            this.laMuru.AutoSize = true;
            this.laMuru.Location = new System.Drawing.Point(49, 45);
            this.laMuru.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.laMuru.Name = "laMuru";
            this.laMuru.Size = new System.Drawing.Size(40, 16);
            this.laMuru.TabIndex = 19;
            this.laMuru.Text = "目录";
            // 
            // LiMain
            // 
            this.LiMain.FormattingEnabled = true;
            this.LiMain.HorizontalScrollbar = true;
            this.LiMain.ItemHeight = 16;
            this.LiMain.Location = new System.Drawing.Point(457, 73);
            this.LiMain.Margin = new System.Windows.Forms.Padding(7);
            this.LiMain.Name = "LiMain";
            this.LiMain.ScrollAlwaysVisible = true;
            this.LiMain.Size = new System.Drawing.Size(272, 260);
            this.LiMain.TabIndex = 18;
            // 
            // LiName
            // 
            this.LiName.FormattingEnabled = true;
            this.LiName.ItemHeight = 16;
            this.LiName.Location = new System.Drawing.Point(226, 73);
            this.LiName.Margin = new System.Windows.Forms.Padding(7);
            this.LiName.Name = "LiName";
            this.LiName.ScrollAlwaysVisible = true;
            this.LiName.Size = new System.Drawing.Size(183, 260);
            this.LiName.TabIndex = 17;
            // 
            // LiTotal
            // 
            this.LiTotal.FormattingEnabled = true;
            this.LiTotal.ItemHeight = 16;
            this.LiTotal.Location = new System.Drawing.Point(27, 73);
            this.LiTotal.Margin = new System.Windows.Forms.Padding(7);
            this.LiTotal.Name = "LiTotal";
            this.LiTotal.ScrollAlwaysVisible = true;
            this.LiTotal.Size = new System.Drawing.Size(141, 260);
            this.LiTotal.TabIndex = 16;
            this.LiTotal.SelectedIndexChanged += new System.EventHandler(this.LiTotal_SelectedIndexChanged);
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(738, 373);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(95, 39);
            this.btnLookUp.TabIndex = 24;
            this.btnLookUp.Text = "查询";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MangerSystem.Properties.Resources.SecondPicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // MonthTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 441);
            this.Controls.Add(this.btnLookUp);
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
            this.MaximizeBox = false;
            this.Name = "MonthTotal";
            this.Text = "MonthTotal";
            this.Load += new System.EventHandler(this.MonthTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laMuru;
        private System.Windows.Forms.ListBox LiMain;
        private System.Windows.Forms.ListBox LiName;
        private System.Windows.Forms.ListBox LiTotal;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
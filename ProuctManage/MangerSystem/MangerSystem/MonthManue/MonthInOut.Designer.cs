namespace MangerSystem.MonthManue
{
    partial class MonthInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthInOut));
            this.CHin = new System.Windows.Forms.CheckBox();
            this.CHout = new System.Windows.Forms.CheckBox();
            this.LiMain = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.LiName = new System.Windows.Forms.ListBox();
            this.LiTotal = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.laMuru = new System.Windows.Forms.Label();
            this.lblTitile = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CHin
            // 
            this.CHin.AutoSize = true;
            this.CHin.Location = new System.Drawing.Point(1168, 339);
            this.CHin.Margin = new System.Windows.Forms.Padding(4);
            this.CHin.Name = "CHin";
            this.CHin.Size = new System.Drawing.Size(75, 20);
            this.CHin.TabIndex = 15;
            this.CHin.Text = "月进项";
            this.CHin.UseVisualStyleBackColor = true;
            // 
            // CHout
            // 
            this.CHout.AutoSize = true;
            this.CHout.Location = new System.Drawing.Point(1168, 385);
            this.CHout.Margin = new System.Windows.Forms.Padding(4);
            this.CHout.Name = "CHout";
            this.CHout.Size = new System.Drawing.Size(75, 20);
            this.CHout.TabIndex = 14;
            this.CHout.Text = "月销项";
            this.CHout.UseVisualStyleBackColor = true;
            // 
            // LiMain
            // 
            this.LiMain.FormattingEnabled = true;
            this.LiMain.HorizontalScrollbar = true;
            this.LiMain.ItemHeight = 16;
            this.LiMain.Location = new System.Drawing.Point(624, 65);
            this.LiMain.Margin = new System.Windows.Forms.Padding(5);
            this.LiMain.Name = "LiMain";
            this.LiMain.ScrollAlwaysVisible = true;
            this.LiMain.Size = new System.Drawing.Size(463, 340);
            this.LiMain.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 443);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1099, 30);
            this.progressBar1.TabIndex = 12;
            // 
            // btnLookUp
            // 
            this.btnLookUp.ForeColor = System.Drawing.Color.Black;
            this.btnLookUp.Location = new System.Drawing.Point(1141, 443);
            this.btnLookUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(135, 30);
            this.btnLookUp.TabIndex = 11;
            this.btnLookUp.Text = "查询";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // LiName
            // 
            this.LiName.FormattingEnabled = true;
            this.LiName.ItemHeight = 16;
            this.LiName.Location = new System.Drawing.Point(321, 65);
            this.LiName.Margin = new System.Windows.Forms.Padding(5);
            this.LiName.Name = "LiName";
            this.LiName.ScrollAlwaysVisible = true;
            this.LiName.Size = new System.Drawing.Size(237, 340);
            this.LiName.TabIndex = 10;
            // 
            // LiTotal
            // 
            this.LiTotal.FormattingEnabled = true;
            this.LiTotal.ItemHeight = 16;
            this.LiTotal.Location = new System.Drawing.Point(17, 65);
            this.LiTotal.Margin = new System.Windows.Forms.Padding(5);
            this.LiTotal.Name = "LiTotal";
            this.LiTotal.ScrollAlwaysVisible = true;
            this.LiTotal.Size = new System.Drawing.Size(248, 340);
            this.LiTotal.TabIndex = 9;
            this.LiTotal.SelectedIndexChanged += new System.EventHandler(this.LiTotal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "产品";
            // 
            // laMuru
            // 
            this.laMuru.AutoSize = true;
            this.laMuru.Location = new System.Drawing.Point(33, 29);
            this.laMuru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laMuru.Name = "laMuru";
            this.laMuru.Size = new System.Drawing.Size(40, 16);
            this.laMuru.TabIndex = 16;
            this.laMuru.Text = "目录";
            // 
            // lblTitile
            // 
            this.lblTitile.AutoSize = true;
            this.lblTitile.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitile.ForeColor = System.Drawing.Color.Red;
            this.lblTitile.Location = new System.Drawing.Point(620, 29);
            this.lblTitile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitile.Name = "lblTitile";
            this.lblTitile.Size = new System.Drawing.Size(130, 24);
            this.lblTitile.TabIndex = 18;
            this.lblTitile.Text = "月度进销额";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MangerSystem.Properties.Resources.MainPicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1307, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // MonthInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 502);
            this.Controls.Add(this.lblTitile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laMuru);
            this.Controls.Add(this.CHin);
            this.Controls.Add(this.CHout);
            this.Controls.Add(this.LiMain);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.LiName);
            this.Controls.Add(this.LiTotal);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MonthInOut";
            this.Text = "MonthInOut";
            this.Load += new System.EventHandler(this.MonthInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CHin;
        private System.Windows.Forms.CheckBox CHout;
        private System.Windows.Forms.ListBox LiMain;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.ListBox LiName;
        private System.Windows.Forms.ListBox LiTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laMuru;
        private System.Windows.Forms.Label lblTitile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
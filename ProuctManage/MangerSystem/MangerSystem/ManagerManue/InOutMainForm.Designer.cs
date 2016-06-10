namespace MangerSystem.InOutForm
{
    partial class InOutMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InOutMainForm));
            this.LiTotal = new System.Windows.Forms.ListBox();
            this.LiName = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbNotice = new System.Windows.Forms.Label();
            this.lbIn = new System.Windows.Forms.Label();
            this.lbOut = new System.Windows.Forms.Label();
            this.lbKucun = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.NumberIn = new System.Windows.Forms.NumericUpDown();
            this.numberOut = new System.Windows.Forms.NumericUpDown();
            this.numberKucunAlter = new System.Windows.Forms.NumericUpDown();
            this.lbKC = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbPorgress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKucunAlter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LiTotal
            // 
            this.LiTotal.FormattingEnabled = true;
            this.LiTotal.ItemHeight = 16;
            this.LiTotal.Location = new System.Drawing.Point(28, 16);
            this.LiTotal.Margin = new System.Windows.Forms.Padding(4);
            this.LiTotal.Name = "LiTotal";
            this.LiTotal.Size = new System.Drawing.Size(192, 308);
            this.LiTotal.TabIndex = 0;
            this.LiTotal.SelectedIndexChanged += new System.EventHandler(this.LiTotal_SelectedIndexChanged);
            // 
            // LiName
            // 
            this.LiName.FormattingEnabled = true;
            this.LiName.ItemHeight = 16;
            this.LiName.Location = new System.Drawing.Point(253, 16);
            this.LiName.Margin = new System.Windows.Forms.Padding(4);
            this.LiName.Name = "LiName";
            this.LiName.Size = new System.Drawing.Size(228, 308);
            this.LiName.TabIndex = 1;
            this.LiName.SelectedIndexChanged += new System.EventHandler(this.LiName_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(785, 96);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 25);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "进销额修改";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNotice.ForeColor = System.Drawing.Color.Red;
            this.lbNotice.Location = new System.Drawing.Point(552, 16);
            this.lbNotice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(106, 24);
            this.lbNotice.TabIndex = 3;
            this.lbNotice.Text = "进销管理";
            // 
            // lbIn
            // 
            this.lbIn.AutoSize = true;
            this.lbIn.Location = new System.Drawing.Point(585, 78);
            this.lbIn.Name = "lbIn";
            this.lbIn.Size = new System.Drawing.Size(40, 16);
            this.lbIn.TabIndex = 6;
            this.lbIn.Text = "进项";
            // 
            // lbOut
            // 
            this.lbOut.AutoSize = true;
            this.lbOut.Location = new System.Drawing.Point(585, 126);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(40, 16);
            this.lbOut.TabIndex = 7;
            this.lbOut.Text = "销额";
            // 
            // lbKucun
            // 
            this.lbKucun.AutoSize = true;
            this.lbKucun.Location = new System.Drawing.Point(553, 188);
            this.lbKucun.Name = "lbKucun";
            this.lbKucun.Size = new System.Drawing.Size(72, 16);
            this.lbKucun.TabIndex = 9;
            this.lbKucun.Text = "月初库存";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(785, 175);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(111, 26);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "库存修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // NumberIn
            // 
            this.NumberIn.Location = new System.Drawing.Point(643, 76);
            this.NumberIn.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumberIn.Name = "NumberIn";
            this.NumberIn.Size = new System.Drawing.Size(120, 26);
            this.NumberIn.TabIndex = 11;
            // 
            // numberOut
            // 
            this.numberOut.Location = new System.Drawing.Point(643, 124);
            this.numberOut.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numberOut.Name = "numberOut";
            this.numberOut.Size = new System.Drawing.Size(120, 26);
            this.numberOut.TabIndex = 12;
            // 
            // numberKucunAlter
            // 
            this.numberKucunAlter.Location = new System.Drawing.Point(643, 178);
            this.numberKucunAlter.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numberKucunAlter.Name = "numberKucunAlter";
            this.numberKucunAlter.Size = new System.Drawing.Size(120, 26);
            this.numberKucunAlter.TabIndex = 13;
            // 
            // lbKC
            // 
            this.lbKC.AutoSize = true;
            this.lbKC.Location = new System.Drawing.Point(640, 229);
            this.lbKC.Name = "lbKC";
            this.lbKC.Size = new System.Drawing.Size(72, 16);
            this.lbKC.TabIndex = 14;
            this.lbKC.Text = "库存剩余";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(612, 285);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(185, 27);
            this.progressBar1.TabIndex = 15;
            // 
            // lbPorgress
            // 
            this.lbPorgress.AutoSize = true;
            this.lbPorgress.Location = new System.Drawing.Point(627, 266);
            this.lbPorgress.Name = "lbPorgress";
            this.lbPorgress.Size = new System.Drawing.Size(136, 16);
            this.lbPorgress.TabIndex = 16;
            this.lbPorgress.Text = "数据读取保存进度";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MangerSystem.Properties.Resources.MainPicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(930, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // InOutMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 365);
            this.Controls.Add(this.lbPorgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbKC);
            this.Controls.Add(this.numberKucunAlter);
            this.Controls.Add(this.numberOut);
            this.Controls.Add(this.NumberIn);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lbKucun);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.lbIn);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.LiName);
            this.Controls.Add(this.LiTotal);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "InOutMainForm";
            this.Text = "进销主页面";
            this.Load += new System.EventHandler(this.InOutMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKucunAlter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LiTotal;
        private System.Windows.Forms.ListBox LiName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.Label lbIn;
        private System.Windows.Forms.Label lbOut;
        private System.Windows.Forms.Label lbKucun;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.NumericUpDown NumberIn;
        private System.Windows.Forms.NumericUpDown numberOut;
        private System.Windows.Forms.NumericUpDown numberKucunAlter;
        private System.Windows.Forms.Label lbKC;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbPorgress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
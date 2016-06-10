namespace CaculateMoney
{
    partial class SelectMonthDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectMonthDirectory));
            this.listDirectory = new System.Windows.Forms.ListBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listDirectory
            // 
            this.listDirectory.FormattingEnabled = true;
            this.listDirectory.HorizontalScrollbar = true;
            this.listDirectory.ItemHeight = 12;
            this.listDirectory.Location = new System.Drawing.Point(26, 12);
            this.listDirectory.Name = "listDirectory";
            this.listDirectory.Size = new System.Drawing.Size(220, 220);
            this.listDirectory.TabIndex = 0;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(26, 238);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(107, 26);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "导出数据";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CaculateMoney.Properties.Resources._20101022093506335;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 276);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SelectMonthDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 276);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.listDirectory);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectMonthDirectory";
            this.Text = "详细信息";
            this.Load += new System.EventHandler(this.SelectMonthDirectory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDirectory;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
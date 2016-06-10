namespace MangerSystem.ManagerManue
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.LiTotal = new System.Windows.Forms.ListBox();
            this.LiName = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.ChTotal = new System.Windows.Forms.CheckBox();
            this.chName = new System.Windows.Forms.CheckBox();
            this.lbProduct = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LiTotal
            // 
            this.LiTotal.FormattingEnabled = true;
            this.LiTotal.ItemHeight = 12;
            this.LiTotal.Location = new System.Drawing.Point(21, 12);
            this.LiTotal.Name = "LiTotal";
            this.LiTotal.ScrollAlwaysVisible = true;
            this.LiTotal.Size = new System.Drawing.Size(180, 232);
            this.LiTotal.TabIndex = 0;
            this.LiTotal.SelectedIndexChanged += new System.EventHandler(this.LiTotal_SelectedIndexChanged);
            // 
            // LiName
            // 
            this.LiName.FormattingEnabled = true;
            this.LiName.ItemHeight = 12;
            this.LiName.Location = new System.Drawing.Point(240, 12);
            this.LiName.Name = "LiName";
            this.LiName.ScrollAlwaysVisible = true;
            this.LiName.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LiName.Size = new System.Drawing.Size(202, 232);
            this.LiName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(529, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(457, 37);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(132, 21);
            this.txtMain.TabIndex = 3;
            // 
            // ChTotal
            // 
            this.ChTotal.AutoSize = true;
            this.ChTotal.Location = new System.Drawing.Point(457, 78);
            this.ChTotal.Name = "ChTotal";
            this.ChTotal.Size = new System.Drawing.Size(48, 16);
            this.ChTotal.TabIndex = 4;
            this.ChTotal.Text = "目录";
            this.ChTotal.UseVisualStyleBackColor = true;
            // 
            // chName
            // 
            this.chName.AutoSize = true;
            this.chName.Location = new System.Drawing.Point(529, 78);
            this.chName.Name = "chName";
            this.chName.Size = new System.Drawing.Size(60, 16);
            this.chName.TabIndex = 5;
            this.chName.Text = "产品名";
            this.chName.UseVisualStyleBackColor = true;
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(455, 12);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(101, 12);
            this.lbProduct.TabIndex = 6;
            this.lbProduct.Text = "目录或新产品添加";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(529, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 25);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MangerSystem.Properties.Resources.MainPicture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 262);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.chName);
            this.Controls.Add(this.ChTotal);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LiName);
            this.Controls.Add(this.LiTotal);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "添加新产品";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LiTotal;
        private System.Windows.Forms.ListBox LiName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.CheckBox ChTotal;
        private System.Windows.Forms.CheckBox chName;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
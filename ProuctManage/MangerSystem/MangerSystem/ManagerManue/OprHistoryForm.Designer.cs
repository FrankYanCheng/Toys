namespace MangerSystem.ManagerManue
{
    partial class OprHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OprHistoryForm));
            this.LiHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LiHistory
            // 
            this.LiHistory.FormattingEnabled = true;
            this.LiHistory.HorizontalScrollbar = true;
            this.LiHistory.ItemHeight = 12;
            this.LiHistory.Location = new System.Drawing.Point(12, 12);
            this.LiHistory.Name = "LiHistory";
            this.LiHistory.ScrollAlwaysVisible = true;
            this.LiHistory.Size = new System.Drawing.Size(462, 220);
            this.LiHistory.TabIndex = 0;
            // 
            // OprHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 262);
            this.Controls.Add(this.LiHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OprHistoryForm";
            this.Text = "历史记录查看";
            this.Load += new System.EventHandler(this.OprHistoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LiHistory;
    }
}
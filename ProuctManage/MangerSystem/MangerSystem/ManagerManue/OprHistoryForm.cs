using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogLibrary.ManagerManue;
using LogLibrary;
namespace MangerSystem.ManagerManue
{
    public partial class OprHistoryForm : Form
    {
        public OprHistoryForm()
        {
            InitializeComponent();
        }
        public string time;
        private void OprHistoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                LogReader reader = new LogReader(time);
                for (int i = 0; i < reader.txt.Length; i++)
                {
                    LiHistory.Items.Add(reader.txt[i]);
                }
            }
            catch
            {
                MessageBox.Show("该日期无历史记录操作");
                this.Close();
            }
        }
    }
}

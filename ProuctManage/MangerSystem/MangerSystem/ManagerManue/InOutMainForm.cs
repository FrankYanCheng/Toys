using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileReaderLibrary;
using FormTool.AddNew;
using FormTool.InOutMain;
using FormTool.MonthSave;
using ToolLibrary.ManagerHeart;
namespace MangerSystem.InOutForm
{
    public partial class InOutMainForm : Form
    {
        public InOutMainForm()
        {
            InitializeComponent();
        }

        private void txtKuCun_TextChanged(object sender, EventArgs e)
        {

        }
        public string time;
       static bool isAlter = false;
       //static bool isKCAlter = false;
        private void InOutMainForm_Load(object sender, EventArgs e)
        {
            try
            {
                FileNameBack back = new FileNameBack("ProductSave");
                string[] name = back.AllName;
                for (int i = 0; i < name.Length; i++)
                {
                    LiTotal.Items.Add(name[i]);
                }
            }
            catch
            {
                MessageBox.Show("未设置产品！");
                this.Close();
            }
          
           
        }
        
        private void LiTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReaderFundation read = new ReaderFundation(LiTotal.Text);
                string[] reader = read.writer;
                LiName.Items.Clear();
                foreach (string x in reader)
                {
                    LiName.Items.Add(x);
                }
            }
            catch
            {

            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {  
            IOManager manager;
            if(isAlter==false)
            manager = new IOManager(Convert.ToInt32(NumberIn.Value),Convert.ToInt32(numberOut.Value), LiTotal.Text, LiName.Text, time, ManagerEnum.Add);
            else
            manager = new IOManager(Convert.ToInt32(NumberIn.Value),Convert.ToInt32(numberOut.Value), LiTotal.Text, LiName.Text, time, ManagerEnum.Alter);
            MessageBox.Show("进销项修改成功");
            //刷新
            MSReader reader = new MSReader(time, LiTotal.Text, LiName.Text);
            numberKucunAlter.Value = reader.count;
            //月份读取库存信息
            IOReader Superreader = new IOReader(time, true, LiName.Text, LiTotal.Text,progressBar1);
            int left = reader.count + Superreader.AllIn - Superreader.AllOut;
            //剩余库存

            if (left >= 0)
            {
                lbKC.Text = LiName.Text + "库存剩余" + left + "件";
            }
            else
            {
                left = -left;
                lbKC.Text = LiName.Text + "库存已超标" + left + "件";
            }
            isAlter = true;
            
        }

        private void LiName_SelectedIndexChanged(object sender, EventArgs e)
        {
            isAlter = false;
            try
            {
               
                IOManager manager = new IOManager(LiTotal.Text, LiName.Text, time, ManagerEnum.Read);
                NumberIn.Value = manager.IOInt;
                numberOut.Value = manager.IOOut;
                if (Convert.ToInt32(NumberIn.Value)!=0 ||Convert.ToInt32(numberOut.Value)!=0)
                {
                    isAlter = true;
                }
                MSReader reader = new MSReader(time, LiTotal.Text, LiName.Text);
                numberKucunAlter.Value = reader.count;
              
               //月份读取库存信息
                IOReader Superreader = new IOReader(time, true, LiName.Text, LiTotal.Text,progressBar1);

               int left=reader.count + Superreader.AllIn - Superreader.AllOut;
                //剩余库存

               if (left >= 0)
               {
                   lbKC.Text = LiName.Text + "库存剩余" + left + "件";
               }
               else
               {
                   left=-left;
                   lbKC.Text = LiName.Text + "库存已超标" + left + "件";
               }
                
               
            }
            catch
            {
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MSManager MSmanager = new MSManager(time, Convert.ToInt32(numberKucunAlter.Value), LiTotal.Text, LiName.Text);
            MessageBox.Show("该产品库存值修改成功");

            //刷新
            //月份读取库存信息
            IOReader Superreader = new IOReader(time, true, LiName.Text, LiTotal.Text,progressBar1);
            MSReader reader = new MSReader(time, LiTotal.Text, LiName.Text);
            numberKucunAlter.Value = reader.count;

          
            int left = reader.count + Superreader.AllIn - Superreader.AllOut;
            //剩余库存

            if (left >= 0)
            {
                lbKC.Text = LiName.Text + "库存剩余" + left + "件";
            }
            else
            {
                left = -left;
                lbKC.Text = LiName.Text + "库存已超标" + left + "件";
            }
                
        }

     
    }
}

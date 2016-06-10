using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EventLibrary;
using ToolLibrary;
using ToolLibrary.AnalyseTool;
using ToolLibrary.StudentCardTool;
namespace CaculateMoney
{
    public delegate void StudentCardFormHandler(object sender, StudentCarEventArgs e);
    public partial class StudentCardForm : Form
    {
        public double Start;
        public double End;
        public double Add;
        public int Year;
        public int Month;
        public int Day;
        public Dictionary<string, double> DirectIn = new Dictionary<string, double>();
        public StudentCardForm()
        {
            InitializeComponent();
        }
        public  event StudentCardFormHandler StudentEvent;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Start = Convert.ToDouble(txtStart.Text);
               
               
              
            }
            catch
            {
                Start = 0;
            }
            try
            {
                End = Convert.ToDouble(txtEnd.Text);
            }
            catch
            {
                End = 0;
            }
            try
            {
             
            }
            catch
            {
                Add = 0;
            }
            try
            {
                //foreach (string x in DirectIn.Keys)
                //{
                //    if (x == Year + "年" + Month + "月" + Day + "日" + "（学生卡进账).txt")
                //    {
                //        DirectIn[x] = Convert.ToInt32(txtAdd.Text);
                //    }
                //}
            }
            catch
            {
            }
            StudentCarEventArgs w = new StudentCarEventArgs(Start, End, Add,DirectIn);
            StudentEvent(this, w);
            try
            {
                string Path = "StSave";
                string name = Year + "年" + Month + "月" + Day + "日" + "（学生卡进账）";
                string txt;
                string txt2;
                txt = Year + "年" + Month + "月" + Day + "日" + "进账额度 " + txtAdd.Text;
                TxtWriter tx = new TxtWriter(Path, txt, name);
                txt2 = Year + "年" + Month + "月" + "入度 " + txtStart.Text+"\r\n"+
                       Year + "年" + Month + "月" + "出度 " +txtEnd.Text;
 
                string name2 = Year + "年" + Month + "月" + "（学生卡出度入度）";
                TxtWriter tx2 = new TxtWriter(Path, txt2, name2);
                MessageBox.Show("写入成功");

            }
            catch
            {
                MessageBox.Show("写入失败");
            }



        }
       
        private void StudentCardForm_Load(object sender, EventArgs e)
        {
            NameWay way = new NameWay();//字符串处理类
            string Path="StSave";
            string name=Year+"年"+Month+"月"+Day+"日"+"（学生卡进账）";
            string name2 = Year + "年" + Month + "月"+ "（学生卡出度入度）";

            try
            {
                TxtReader t = new TxtReader();
                string[] tx = t.Reader(name, Path);
                txtAdd.Text = way.GetCost(tx[0]);
                string[] txs = t.Reader(name2, Path);//初度入读读取
                txtStart.Text = way.GetCost(txs[0]);
                Start =Convert.ToDouble( way.GetCost(txs[0])); 
                txtEnd.Text = way.GetCost(txs[1]);
            }
            catch
            {
            }
            try
            {
                TxtReader t = new TxtReader();
                string[] txs = t.Reader(name2, Path);//初度入读读取
                txtStart .Text = way.GetCost(txs[0]);
                txtEnd.Text = way.GetCost(txs[1]);
                End =Convert.ToDouble(way.GetCost(txs[1]));
               GetCardIn cardin = new GetCardIn(Month, Year);//月份进账信息
               DirectIn = cardin.DirectIn;
               //txtAdd.Text = cardin.CardIn.ToString();
               try
               {
                   //Add = Convert.ToDouble(cardin.CardIn.ToString());
               }
               catch
               {
               }
               double X = Start - End + cardin.CardIn;
               lblAdd.Text ="该月学生卡花销为"+X.ToString()+"元";
          
              
             
               
            }
            catch
            {
            }

           
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            GetInAllForm gf = new GetInAllForm();
            gf.DirectIn = DirectIn;
            gf.day = Day;
            gf.month = Month;
            this.StudentEvent += gf.AddEvent;
            gf.year = Year;
            gf.Show();
        }
    }
}

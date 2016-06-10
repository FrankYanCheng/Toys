using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EventLibrary;
using ToolLibrary;
using ToolLibrary.StudentCardTool;
namespace CaculateMoney
{
    public partial class MainTable : Form
    {
        public MainTable()
        {
            InitializeComponent();
        }
        #region 属性字段
        public bool isLimitionOpen=false;//判断开启窗体数量
        public double Limition_Month = 0;//月度限额值
        public double StdStart = 0;
        public double SEnd = 0;
        public double SAdd = 0;

        #endregion
        private void MainTable_Load(object sender, EventArgs e)
        {
            string path = "Save";
            if (!Directory.Exists(path))
            { Directory.CreateDirectory(path); }
            string StPath = "StSave";//学生卡信息
            if (!Directory.Exists(StPath))
            { Directory.CreateDirectory(StPath); }
            string LiPath = "LiSave";//限制数额
            if (!Directory.Exists(LiPath))
            { Directory.CreateDirectory(LiPath); }
            string InPath = "InSave";//收入
            if (!Directory.Exists(InPath))
            { Directory.CreateDirectory(InPath); }
            string month = monthCalendar1.SelectionEnd.Month.ToString();//获取查询月份
            string year = monthCalendar1.SelectionEnd.Year.ToString();//获取查询年份
            string name = year + "年" + month + "月" + "限额";
            string parentPath = "LiSave";
            try
            {
                TxtReader reader = new TxtReader();
                string[] txt = reader.Reader(name, parentPath);
                foreach (string z in txt)
                {
                    label1.Text = z + "元";
                }
                GetName g = new GetName();
                Limition_Month = Convert.ToDouble(g.GetLimitCost(label1.Text));
            }
            catch
            {
                label1.Text = year + "年" + month + "月" + "限额未设置";
                Limition_Month = 0;
            }
            try
            {
                int Month = monthCalendar1.SelectionEnd.Month;//获取查询月份
                int Year = monthCalendar1.SelectionEnd.Year;//获取查询年份
                int Day = monthCalendar1.SelectionEnd.Day;
                NameWay way = new NameWay();//字符串处理类
                string Path = "StSave";
                string name1 = Year + "年" + Month + "月" + Day + "日" + "（学生卡进账）";
                string name2 = Year + "年" + Month + "月" + "（学生卡出度入度）";

                try
                {
                    TxtReader t = new TxtReader();
                    string[] tx = t.Reader(name, Path);
                    SAdd = Convert.ToDouble(way.GetCost(tx[0]));
                    string[] txs = t.Reader(name2, Path);//初度入读读取
                    StdStart = Convert.ToDouble(way.GetCost(txs[0]));
                    SEnd = Convert.ToDouble(way.GetCost(txs[1]));
                }
                catch
                {
                }
                try
                {
                    TxtReader t = new TxtReader();
                    string[] txs = t.Reader(name2, Path);//初度入读读取
                    StdStart = Convert.ToDouble(way.GetCost(txs[0]));
                    SEnd = Convert.ToDouble(way.GetCost(txs[1]));
                    GetCardIn cardin = new GetCardIn(Month, Year);//月份进账信息

                    try
                    {
                        SAdd = Convert.ToDouble(cardin.CardIn.ToString());
                    }
                    catch
                    {
                    }



                }
                catch
                {

                }

            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
       
        }

        private void btnBianJi_Click(object sender, EventArgs e)
        {
            Caculate_Daily open = new Caculate_Daily();
            open.Time = monthCalendar1.SelectionEnd.ToLongDateString();
            open.Show();
        }
    
        private void 该月累计消费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<int, double> DiSpend = new Dictionary<int, double>();//建立关于花销的字典
            Dictionary<int, string> DiDay = new Dictionary<int, string>();//建立关于日期的字典
            string pathParent = "Save";
            string month= monthCalendar1.SelectionEnd.Month.ToString();//获取查询月份
            string year = monthCalendar1.SelectionEnd.Year.ToString();//获取查询年份
            DirectoryInfo dir = new DirectoryInfo(pathParent);
            FileInfo[] ZiMuRu = dir.GetFiles();
            for (int i = 0; i < ZiMuRu.Length; i++)//遍历所搜寻的目录
            {
                if (ZiMuRu[i].ToString().Contains(month + "月")&&ZiMuRu[i].ToString().Contains(year+"年"))//获取包含该月份年份的文件
                {
                    using (FileStream fil = new FileStream(pathParent + @"\" + ZiMuRu[i], FileMode.Open))
                    {
                        try
                        {
                            StreamReader reader = new StreamReader(fil, Encoding.UTF8);
                            string nativetxt = reader.ReadToEnd();
                            string[] txt = nativetxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            CostCaculate cacu = new CostCaculate(txt[txt.Length - 1]);//获取总计花费数目
                            DiSpend.Add(i, cacu.TotalCost);//添加键值
                            DiDay.Add(i, ZiMuRu[i].ToString());
                        }
                        catch
                        {

                        }



                    }
                }
            }
            int day = monthCalendar1.SelectionEnd.Day;//获取查询月份
            SearchCostMonth search = new SearchCostMonth();
            search.Dispend = DiSpend;//给另一个窗口的键值对赋值
            search.DiDay = DiDay;
            search.Limition_Month = Limition_Month;
            search.GetYear = year;
            search.SAdd = SAdd;
            search.Send = SEnd;
            search.Start = StdStart;
            search.GetMonth = month;//获取查询月份
            search.Show();
            search.day = day;
        }

        private void 年度消费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<int, double> DiSpend = new Dictionary<int, double>();//建立关于花销的字典
            Dictionary<int, string> DiDay = new Dictionary<int, string>();//建立关于日期的字典
            string pathParent = "Save";
            string month = monthCalendar1.SelectionEnd.Month.ToString();//获取查询月份
            string year = monthCalendar1.SelectionEnd.Year.ToString();//获取查询年份
            DirectoryInfo dir = new DirectoryInfo(pathParent);
            FileInfo[] ZiMuRu = dir.GetFiles();
            double TotalCost=0;//年度总花费
            for(int S=1;S<13;S++)
            {
                double cost=0;
            for (int i = 0; i < ZiMuRu.Length; i++)//遍历所搜寻的目录
            {
                if (ZiMuRu[i].ToString().Contains(S + "月") && ZiMuRu[i].ToString().Contains(year + "年"))//获取包含该月份年份的文件
                {
                    using (FileStream fil = new FileStream(pathParent + @"\" + ZiMuRu[i], FileMode.Open))
                    {
                        try
                        {
                            StreamReader reader = new StreamReader(fil, Encoding.UTF8);
                            string nativetxt = reader.ReadToEnd();
                            string[] txt = nativetxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            CostCaculate cacu = new CostCaculate(txt[txt.Length - 1]);//获取总计花费数目
                            cost += cacu.TotalCost;
                            TotalCost += cacu.TotalCost;
                           
                        }
                        catch
                        {

                        }


                    }
                    }
                }
            DiSpend.Add(S, cost);//添加键值

            }



            SearchCostMonth search = new SearchCostMonth();
            search.Text = "年度消费";
            search.Dispend = DiSpend;//给另一个窗口的键值对赋值
            search.GetYear = year;
            search.GetMonth = month;//获取查询月份
            search.isYear = true;
            search.Start = StdStart;
            search.Send = SEnd;
            search.SAdd = SAdd;
            search.Limition_Month = Limition_Month;//年份的应该另外设置
            search.TotalCost = TotalCost;
            search.Show();
        }

        private void 导出文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 月度限额ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isLimitionOpen==false)
            {
            LimitionForm limi = new LimitionForm();
            string month = monthCalendar1.SelectionEnd.Month.ToString();//获取查询月份
            string year = monthCalendar1.SelectionEnd.Year.ToString();//获取查询年份
            limi.Year = year;
            limi.Month = month;
            limi.Limition_Month = Limition_Month;//获取限额
            limi.Show();
            limi.limitionEvent += AddLimitionCost;//添加方法
            //isLimitionOpen = true;
            }
        }
        public void RegisterEvent()
        {

        }
        //public void CloseEventOnLimition(object sender, LimitionEventCloseArgs e)
        //{
        // isLimitionOpen= e.isOpen;
        //}
     

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string month = monthCalendar1.SelectionEnd.Month.ToString();//获取查询月份
            string year = monthCalendar1.SelectionEnd.Year.ToString();//获取查询年份
            string name = year + "年" + month + "月" + "限额";
            string parentPath = "LiSave";
            try
            {
                TxtReader reader = new TxtReader();
                string[] txt = reader.Reader(name, parentPath);
                foreach (string z in txt)
                {
                    label1.Text = z+"元";
                }
                GetName g = new GetName();
                Limition_Month = Convert.ToDouble(g.GetLimitCost(label1.Text));
            }
            catch
            {
                label1.Text = year + "年" + month + "月" + "限额未设置";
                Limition_Month = 0;
            }
        }

        private void 学生卡设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int month = monthCalendar1.SelectionEnd.Month;//获取查询月份
            int year = monthCalendar1.SelectionEnd.Year;//获取查询年份
            int day = monthCalendar1.SelectionEnd.Day;
            StudentCardForm S = new StudentCardForm();
            S.StudentEvent += AddStudentCard;
            S.Day = day;//给界面附上时间值
            S.Month = month;
            S.Year = year;
            S.Show();
            
        }
        public void AddStudentCard(object sender, StudentCarEventArgs e)
        {
            SAdd = e.Add;//给学生卡赋值
            StdStart = e.Start;
            SEnd = e.End;
          
        }
        public void AddLimitionCost(object sender, LimitionEventargs e)
        {
            try
            {
                string month = monthCalendar1.SelectionEnd.Month.ToString();//获取查询月份
                string year = monthCalendar1.SelectionEnd.Year.ToString();//获取查询年份
                label1.Text = year + "年" + month + "月限额" + e.limition.ToString() + "元";
                Limition_Month = e.limition;
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool formMove = false;//窗体是否移动   
        Point formPoint;//记录窗体的位置
        private void Form4_MouseDown(object sender, MouseEventArgs e)//鼠标按下    
        {            formPoint = new Point();      
            int xOffset;            int yOffset;    
            if (e.Button == MouseButtons.Left)       
            {                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;       
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;           
                formPoint = new Point(xOffset, yOffset);                formMove = true;//开始移动         
            }        }
        private void Form4_MouseMove(object sender, MouseEventArgs e)//鼠标移动     
            {            if (formMove == true)         
            {                Point mousePos = Control.MousePosition;         
                mousePos.Offset(formPoint.X, formPoint.Y);              
                Location = mousePos;            }        }
        private void Form4_MouseUp(object sender, MouseEventArgs e)//鼠标松开  
                {            if (e.Button == MouseButtons.Left)//按下的是鼠标左键       
                {                formMove = false;//停止移动          
                }   
                }
    }

}

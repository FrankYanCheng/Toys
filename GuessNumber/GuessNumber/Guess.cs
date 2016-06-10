using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Guess : Form
    {
        int rank = 5; int col = 6;
        int width = 50; int heigh = 50;
        int total;
        static int[] scores ;
        bool[] isWait;
        int score;//累计分数
        Button[] buttons;
        List<int> Li_Save = new List<int>();
        public Guess()
        {
            InitializeComponent();
        }
        public void Draw(ref Panel pl,int top,int left,Button button)
        {
          
            button.BackColor = Color.Silver;
            button.Top = top;
            button.Left = left;
            button.Width = width;
            button.Height = heigh;
            button.MouseClick+=MD;
            pl.Controls.Add(button);
        }
        private void Guess_Load(object sender, EventArgs e)
        {
            total=rank * col;
            buttons = new Button[total];
            Random ram=new Random();
            List<int> ram_Choose = new List<int>();
            scores = new int[rank * col];
            isWait = new bool[total];
            int half = total / 2;
            for(int i=0;i<half;i++)//使用链表实现两两分配
            {
                int ran=ram.Next(0,100);
                ram_Choose.Add(ran);
                ram_Choose.Add(ran);
            }
           int choose_int;
           for (int i = 0; i < total;i++)
           {
                choose_int=ram.Next(0,ram_Choose.Count);
                scores[i] = ram_Choose[choose_int];
                ram_Choose.RemoveAt(choose_int);
           }
            for (int r = 0; r < rank; r++)
                for (int c = 0; c < col; c++)
            {
                buttons[c*rank + r] = new Button();
                Draw(ref pl, c * width, r * heigh, buttons[c * rank + r]);
            }
            tm = new Timer();
            tm.Tick += tm_Tick;
            tm.Interval = 1500;
            tm.Start();
        }
        Timer tm; 
        private void MD(object sender,MouseEventArgs e)
        {
           
            Button bt = (Button)sender;   
            bt.ForeColor = Color.Green;
            int index = (bt.Top/heigh)*rank+(bt.Left/heigh);
            bt.Text = scores[index].ToString();
            Li_Save.Add(index);
        }
        void tm_Tick(object sender, EventArgs e)
        {
          
            
            if (Li_Save.Count > 1)
            {
                for (int i = 0; i < Li_Save.Count-1; i++)
                {
                    for (int j = i+1; j < Li_Save.Count; j++)
                    {
                        if (scores[Li_Save[i]] == scores[Li_Save[j]])
                        {

                            isWait[Li_Save[i]] = true;
                            isWait[Li_Save[j]] = true;
                            score += scores[Li_Save[i]];
                        }
                    }
                }
                lblScore.Text = score.ToString();
            } 
            bool isAllRigth = true;
            for (int i = 0; i < isWait.Length; i++)
            {
                if (isWait[i] != true)
                {
                    buttons[i].Text = "";
                    buttons[i].BackColor = Color.Silver;
                    isAllRigth = false;
                }
            }
            Li_Save.Clear();
            if (isAllRigth == true)
              {
                 MessageBox.Show("游戏结束，获得"+ score +"分");
                 tm.Stop();
              }
          
        }
    }
}

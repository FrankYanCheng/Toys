using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using AItest.Properties;
using System.Configuration;
namespace AItest
{
    public partial class Chess : Form
    {
        int chess_width = Convert.ToInt32(ConfigurationManager.ConnectionStrings["width"].ConnectionString);//棋子的长宽
        bool IsRed = Convert.ToBoolean(ConfigurationManager.ConnectionStrings["red"].ConnectionString);//红手先
        public static int counts = 0;//记录游戏回合
        int column;//记录左右棋子个数
        int rank;
        ChessRules rules;//规则类
        Button[] btnElement;//棋子按钮
        public Chess()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            draw();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public void start()
        {

            column = (panGraphic.Width / chess_width);
            rank = (panGraphic.Height / chess_width);
            int counts = (panGraphic.Height * panGraphic.Width) / (chess_width * chess_width);
            ChessRules.chess_map = new int[rank, column];
            btnElement = new Button[counts];
            ChessRules.liLeft = new List<int>();
            int judge_poistion = 0;
            for (int i = 0; i < btnElement.Length; i++)
            {
                btnElement[i] = new Button();
                btnElement[i].MouseDown += new MouseEventHandler(Mouse_Down);
                btnElement[i].BackColor = Color.White;
                btnElement[i].Width = chess_width;
                btnElement[i].Height = chess_width;
                judge_poistion = (i / column) * chess_width;
                btnElement[i].Top = judge_poistion;
                judge_poistion = (i % column) * chess_width;
                btnElement[i].Left = judge_poistion;
                this.panGraphic.Controls.Add(btnElement[i]);
                ChessRules.liLeft.Add(i);

            }
            ChessRules.column = column;
            ChessRules.rank = rank;
            rules = new ChessRules(5);
            //draw(5, 8);

        }
        /// <summary>
        /// 重新画区域，所有
        /// </summary>
        public void draw()
        {
            ChessRules.liLeft.Clear();
            for (int i = 0; i < btnElement.Length; i++)
            {
                btnElement[i].BackColor = Color.White;
                ChessRules.liLeft.Add(i);
            }
            ChessRules.chess_map = new int[rank, column];
        
            counts = 0;
        }

        /// <summary>
        /// 重画棋子
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void draw(int i, int j)
        {
          
            int index = i * column + j;
            if (ChessRules.chess_map[i, j] == 0)
            {
                ai.limit_coordinate(i, j);
                if (counts % 2 == ChessRules.first_number)
                {
                    btnElement[index].BackColor = Color.Red;
                    ChessRules.chess_map[i, j] = 1;//红方记为1
                }
                else
                {
                    btnElement[index].BackColor = Color.Black;
                    ChessRules.chess_map[i, j] = -1;//黑方记为-1
                }
                counts++;
              
            }
        }
        static string test;
        AI ai;
        private void Chess_Load(object sender, EventArgs e)
        {
            start(); 
            ai = new AI();

            if (IsRed == false)
            {
                ChessRules.first_number = 1;
            }
            else
            {
                ChessRules.first_number = 0;
            }
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {    
            Button temp_button = ((Button)sender);
            int i = (temp_button.Top) / chess_width;
            int j = (temp_button.Left) / chess_width;  
            ChessRules.liLeft.Remove(i * ChessRules.column + j);
            AICaculate ca = new AICaculate();
            draw(i, j);
            //ai1.JudgeCounts(-1);
            //draw(ai1.i_temp, ai1.j_temp);
            if (rules.Is_Win(counts))
            {
                if (counts % 2 != ChessRules.first_number)
                    test = "红色";
                else
                    test = "黑色";
                MessageBox.Show(test + "win");
                }
          
                ai.JudgeCounts(1);
                draw(ai.i_temp, ai.j_temp);
                if (rules.Is_Win(counts))
                {
                    if (counts % 2 != ChessRules.first_number)
                        test = "红色";
                    else
                        test = "黑色";
                    MessageBox.Show(test + "win");
                }
              
                  
           

            
        }
    }
}

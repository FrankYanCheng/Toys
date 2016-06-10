using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokers;
using Porker_Bullfight.Properties;
using System.Threading;
namespace Porker_Bullfight
{
    public partial class PaintingCanvas : Form
    {
        public PaintingCanvas()
        {
            InitializeComponent();
        }
        int PlayerNumber=0;
        GameCard game;
        bool IsPaint = false;
        GamePoisition poisition;
        CardsCredit credits;
        Credit[] PlayersCredit;
        static Random random=new Random();
        int porkersNumber=1;//numbers of porkers
        private void PaintingCanvas_Load(object sender, EventArgs e)
        {
           
            poisition = new GamePoisition();
            poisition.Heigth = 150;
            poisition.Width = 120;
            poisition.X_distance =20;
            poisition.Y_distance = 150;
            poisition.Original_X = 30;
            poisition.Original_Y = 30;
            game = new GameCard(1, 0, 5, poisition);
            credits = new CardsCredit(2);
           
        }

     


        private void btnPlay_Click(object sender, EventArgs e)
        {
            dgView.Rows.Clear();
            IsPaint = true;
            picMain.Invalidate();

        
           
        
        }
      
        private void picMain_Paint(object sender, PaintEventArgs e)
        {
            
           game.DrawCards(e.Graphics,IsPaint);
         
           if (IsPaint == true)
           {
               dgView.Rows.Add();
               int times = 1;
            
               for (int i = 1; i < PlayerNumber; i++)
               {
                   if (i == 1)
                       times = Convert.ToInt32(numScore.Value);
                   else
                       times = random.Next(1, 5);
                   dgView.Rows.Add();
                   dgView.Rows[i].Cells[0].Value = "玩家" + i;
                 
                   if (!credits.IsWin(ref PlayersCredit[0], ref PlayersCredit[i], times,
                       game.ListPlayer[0], game.ListPlayer[i]))
                   {
                       dgView.Rows[i].Cells[3].Value = "赢";
                   }
                   else
                   {
                       dgView.Rows[i].Cells[3].Value = "输";
                   }
                   dgView.Rows[i].Cells[1].Value = PlayersCredit[i].Score;
                   dgView.Rows[i].Cells[2].Value = credits.Credit(game.ListPlayer[i]);
                   dgView.Rows[i].Cells[4].Value = times;
                 

               }
               dgView.Rows[0].Cells[0].Value = "庄家";
               dgView.Rows[0].Cells[1].Value = PlayersCredit[0].Score;
               dgView.Rows[0].Cells[2].Value = credits.Credit(game.ListPlayer[0]);
               dgView.Rows[0].Cells[3].Value = " "; dgView.Rows[0].Cells[4].Value = " ";

              
           }
            IsPaint = false;

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            game.base_card.Shuffle();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
            PlayerNumber=Convert.ToInt32(numLic.Value);
            game = new GameCard(porkersNumber, PlayerNumber, 5, poisition);
            credits = new CardsCredit(porkersNumber);

            //游戏玩家积分初始化
            PlayersCredit = new Credit[PlayerNumber];

            for (int i = 0; i < PlayerNumber; i++)
            {
                PlayersCredit[i] = new Credit();
                if (i == 0)
                    PlayersCredit[i].Score = 3000;
                else
                {
                    PlayersCredit[i].Score = 300;
                }
            }
               
        }

        private void btnScore_Click(object sender, EventArgs e)
        {

        }

        private void btnPorkerNumber_Click(object sender, EventArgs e)
        {
            porkersNumber = Convert.ToInt32(numPorkerNumber.Value);
        }
    }
}

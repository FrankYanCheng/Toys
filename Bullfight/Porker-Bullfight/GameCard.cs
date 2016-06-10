using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokers;
using System.Drawing;
using Porker_Bullfight.Properties;
namespace Porker_Bullfight
{
    public class GameCard
    {
        GamePoisition poisition;
        int playerNumber;
        /// <summary>
        /// 游戏人数
        /// </summary>
        public int PlayerNumber
        {
            get { return playerNumber; }
            set { playerNumber = value; }
        }
        int countings;
        /// <summary>
        /// 游戏发牌数
        /// </summary>

        public int Countings
        {
            get { return countings; }
            set { countings = value; }
        }
        List<int>[] listPlayer;

        public List<int>[] ListPlayer
        {
            get { return listPlayer; }
            set { listPlayer = value; }
        }
        /// <summary>
        /// 设计规则
        /// </summary>
        /// <param name="card"></param>
        /// <param name="name"></param>
        /// <param name="packs"></param>
        void SetRules(ref  BullfightCards card, ref Card_Name name, int packs)
        {

            card = new BullfightCards(packs);
            name = new Card_Name();
            name.Big_Joker = "大王";
            name.Little_Joker = "小王";
            name.Club = "草花";
            name.Diamon = "方块";
            name.Hearts = "红桃";
            name.Peach = "黑桃";
            card.SetRules(name);

        }
        /// <summary>
        /// 游戏牌类
        /// </summary>
        public BullfightCards base_card;
        /// <summary>
        /// 游戏初始化
        /// </summary>
        /// <param name="packs">牌副数</param>
        /// <param name="PlayerNumber">游戏人数</param>
        /// <param name="Countings">发牌数量</param>
        /// <param name="poisition">游戏位置</param>
        public GameCard(int packs, int PlayerNumber, int Countings, GamePoisition poisition)
        {
            this.PlayerNumber = PlayerNumber;
            this.Countings = Countings;
            BullfightCards cards = new BullfightCards(packs);
            Card_Name name = new Card_Name();
            SetRules(ref cards, ref name, packs);
            base_card = cards;
            this.poisition = poisition;
            ListPlayer = new List<int>[PlayerNumber];
            //初始化游戏玩家
            for (int i = 0; i < PlayerNumber; i++)
            {
                ListPlayer[i] = new List<int>();
            }
         
        }
        /// <summary>
        /// 画扑克卡片
        /// </summary>
        /// <param name="e">画板</param>
        /// <param name="IsOk">是否发牌绘制</param>
        /// <returns>如果游戏人数和牌数剩余则返回真</returns>
        public bool DrawCards(Graphics e, bool IsOk)
        {

            int packs = base_card.packs;

            if ((base_card.PorkersCount() >= (PlayerNumber * Countings) && PlayerNumber > 0)||IsOk==false)
            {
                if ((base_card.PorkersCount() == (packs * 52) && IsOk == false) || IsOk == true)
                {
                    for (int i = 0; i < PlayerNumber; i++)
                    {
                        ListPlayer[i] = new List<int>();
                    }

                    //给游戏玩家发牌
                    for (int i = 0; i < Countings * PlayerNumber; i++)
                    {

                        ListPlayer[i % PlayerNumber].Add(base_card.Play());
                    }
                }

                
                Image[] p1 = new Image[Countings * PlayerNumber];
                //初始化游戏图片的宽度和长度
                Rectangle rec = new Rectangle();
                rec.Height = poisition.Heigth;
                rec.Width = poisition.Width;
                //绘制位置点
                Point p_img = new Point();
                //复制并绘制扑克图片
                for (int i = 0; i < PlayerNumber; i++)
                {
                    listPlayer[i] = base_card.DescendSort(listPlayer[i]);
                    for (int j = 0; j < Countings; j++)
                    {
                        p1[j] = ((Image)Resources.ResourceManager.GetObject("_" + (ListPlayer[i][j]) % 52));
                        p_img.X = j * (poisition.X_distance) + poisition.Original_X;
                        p_img.Y = i * (poisition.Y_distance) + poisition.Original_Y;
                        rec.Location = p_img;
                        e.DrawImage(p1[j], rec);

                    }
                   
                }
              

                return true;
            }
            else
            {
                return false;
            }






        }


    }
}

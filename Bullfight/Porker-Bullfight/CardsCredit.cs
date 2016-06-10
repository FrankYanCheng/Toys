using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokers;
namespace Porker_Bullfight
{
    /// <summary>
    /// 游戏积分类
    /// </summary>
  public  class CardsCredit
    {
      
      BullfightCards base_cards;
      public CardsCredit(int packs)
      {
        
          base_cards = new BullfightCards(packs);
         Card_Name name = new Card_Name();
          name.Big_Joker = "大王";
          name.Little_Joker = "小王";
          name.Club = "草花";
          name.Diamon = "方块";
          name.Hearts = "红桃";
          name.Peach = "黑桃";
          base_cards.SetRules(name);
      }
      public int Credit(List<int> PlayerCard)
      {
        
          return   base_cards.ResultPoint(PlayerCard);
          
      }
      public bool IsWin(ref Credit bankerCredit, ref Credit playerCredit, int times, List<int> Banker, List<int> Player)
      {
          return base_cards.IsBankerWin(Banker, Player, ref bankerCredit, ref playerCredit, times);
      }
    }
}

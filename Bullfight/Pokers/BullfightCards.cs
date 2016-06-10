using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokers
{
   public class BullfightCards:CardBase
    {
       IRules rules;
      
       public BullfightCards(int packs):base(packs)
       {
           base.Shuffle();
           rules = new Bullfight_Rule();
         
          
         
       }
       /// <summary>
       /// 设置游戏规则
       /// </summary>
       /// <param name="name"></param>
       /// <returns></returns>
       public bool SetRules(Card_Name name)
       {
           if (rules.SetRules(base.packs, name))
               return true;
           else
               return false;
       }
       /// <summary>
       /// 出牌-牌名形式
       /// </summary>
       /// <returns></returns>
       public string Play_String()
       {
           if (this.IsEmpty() == false)
               return rules.IntToPokers(this.Play());
           else
               return "Wrong";
       }
       /// <summary>
       /// 牌型排序-数字形式
       /// </summary>
       /// <param name="cards"></param>
       /// <returns></returns>
       public List<int> AscendSort(List<int> cards)
       {
           return rules.AscendSort(cards);
       }
       /// <summary>
       /// 牌型排序-降序-数字形式
       /// </summary>
       /// <param name="cards"></param>
       /// <returns></returns>
       public List<int>DescendSort(List<int> cards)
       {
           return rules.DescendSort(cards);
       }
       /// <summary>
       /// 数字转化为牌名称
       /// </summary>
       /// <param name="value"></param>
       /// <returns></returns>
      public string IntToString(int value)
       {
           return rules.IntToPokers(value);
       }
       /// <summary>
       /// 牌数组转换为点数列表-内部用
       /// </summary>
       /// <param name="cards"></param>
       /// <returns></returns>
       private List<int> ToPoint(List<int> cards)
       {
           return rules.ToPoints(cards);
       }
       /// <summary>
       /// 点数结果
       /// </summary>
       /// <param name="cards"></param>
       /// <returns></returns>
       public int ResultPoint(List<int> cards)
       {
           cards = ToPoint(cards);
          return rules.PointResult(cards);
       }
       /// <summary>
       /// 求一副牌中最大的点数值，在JQK之间的
       /// </summary>
       /// <param name="cards"></param>
       /// <returns></returns>
       private  int maxSize(List<int> cards)
       {
           int max = -1 ;
           for (int i = 0; i < cards.Count; i++)
           {
               if (max % 13 < cards[i] % 13 && ((cards[i] % 13) >= 8 && (cards[i] % 13)<=10))
              {
                  max = cards[i];
              }
           }
           return max;
       }
       /// <summary>
       /// 求一副牌中最大的点数值，在J以下的
       /// </summary>
       /// <param name="cards"></param>
       /// <returns></returns>
       private int maxSize_regular(List<int> cards)
       {
           int max = -1;
           for (int i = 0; i < cards.Count; i++)
           {
               if (max % 13 < cards[i] % 13 && ((cards[i] % 13) < 8 && (cards[i] % 13) > 10))
               {
                   max = cards[i];
               }
           }
           return max;
       }
       /// <summary>
       /// 庄家是否赢得此下家
       /// </summary>
       /// <param name="BankPoint">庄家点数</param>
       /// <param name="Point">下家点数</param>
       /// <param name="banker_credit">庄家积分</param>
       /// <param name="credit">下家积分</param>
       /// <param name="times">倍数</param>
       /// <returns></returns>
       public bool IsBankerWin(List<int> Banker, List<int> Player, ref Credit banker_credit, ref Credit credit,int times)
       {
           int BankPoint = ResultPoint(Banker);
           int Point = ResultPoint(Player);
           if(BankPoint>Point)
           {
               switch (BankPoint)
               {
                   case 6:
                       {
                           banker_credit.Score += times * 2;
                           credit.Score -= times * 2;
                       }
                       return true;
                   case 7:
                        {
                           banker_credit.Score += times * 2;
                           credit.Score -= times * 2;
                       }
                        return true;
                   case 8:
                       {
                           banker_credit.Score += times * 3;
                           credit.Score -= times * 3;
                       }
                       return true;
                   case 9:
                       {
                           banker_credit.Score += times * 3;
                           credit.Score -= times * 3;
                       }
                       return true;
                   case 10:
                        {
                           banker_credit.Score += times * 4;
                           credit.Score -= times * 4;
                       }
                        return true;
                   default:
                       {
                           banker_credit.Score += times;
                           credit.Score -= times;
                       }  return true;

               }
           }
           if(BankPoint<Point)
           {
               switch (Point)
               {
                   case 6:
                       {
                           banker_credit.Score -= times * 2;
                           credit.Score += times * 2;
                       }
                       return false;
                   case 7:
                       {
                           banker_credit.Score -= times * 2;
                           credit.Score += times * 2;
                       }
                       return false;
                   case 8:
                       {
                           banker_credit.Score -= times * 3;
                           credit.Score += times * 3;
                       }
                       return false;
                   case 9:
                       {
                           banker_credit.Score -= times * 3;
                           credit.Score += times * 3;
                       }
                       return false;
                   case 10:
                       {
                           banker_credit.Score -= times * 4;
                           credit.Score += times * 4;
                       }
                       return false;
                   default:
                       {
                        banker_credit.Score -= times ;
                           credit.Score += times ;
                       }  return false;
             

               }
           }

           //规则如下，如果是庄家是JQK10则无牛的通吃，如果玩家和庄家均小于J值，则比大小吃牌
           if(BankPoint==Point)
           {
               int banker_size=maxSize(Banker)%(13);
               int player_size=maxSize(Player) % (13);
               //JQK
               if (banker_size>=player_size)
               {
                   switch (BankPoint)
                   {
                       case 6:
                           {
                               banker_credit.Score += times * 2;
                               credit.Score -= times * 2;
                           }
                           return true;
                       case 7:
                           {
                               banker_credit.Score += times * 2;
                               credit.Score -= times * 2;
                           }
                           return true;
                       case 8:
                           {
                               banker_credit.Score += times * 3;
                               credit.Score -= times * 3;
                           }
                           return true;
                       case 9:
                           {
                               banker_credit.Score += times * 3;
                               credit.Score -= times * 3;
                           }
                           return true;
                       case 10:
                           {
                               banker_credit.Score += times * 4;
                               credit.Score -= times * 4;
                           }
                           return true;
                       case -1:
                           {
                             
                                   banker_credit.Score += times * 1;
                                   credit.Score -= times * 1;
                                   return true;
                                 
                           

                           }
                       default:
                           {
                               banker_credit.Score += times;
                               credit.Score -= times;
                           } return true;

                   }
               }
               else
               {
                   //int banker_t = maxSize_regular(Banker) % (13);
                   //int player_t = maxSize_regular(Player) % (13);
                   //if (banker_t < player_t)
                   //{
                       switch (Point)
                       {
                           case 6:
                               {
                                   banker_credit.Score -= times * 2;
                                   credit.Score += times * 2;
                               }
                               return false;
                           case 7:
                               {
                                   banker_credit.Score -= times * 2;
                                   credit.Score += times * 2;
                               }
                               return false;
                           case 8:
                               {
                                   banker_credit.Score -= times * 3;
                                   credit.Score += times * 3;
                               }
                               return false;
                           case 9:
                               {
                                   banker_credit.Score -= times * 3;
                                   credit.Score += times * 3;
                               }
                               return false;
                           case 10:
                               {
                                   banker_credit.Score -= times * 4;
                                   credit.Score += times * 4;
                               }
                               return false;
                           case -1:
                               {

                                   banker_credit.Score -= times * 1;
                                   credit.Score += times * 1;
                                   return false;



                               }
                           default:
                               {
                                   banker_credit.Score -= times;
                                   credit.Score += times;
                               } return false;


                       }
                   //}
                   //else
                   //{
                   //    switch (BankPoint)
                   //    {
                   //        case 6:
                   //            {
                   //                banker_credit.Score += times * 2;
                   //                credit.Score -= times * 2;
                   //            }
                   //            return true;
                   //        case 7:
                   //            {
                   //                banker_credit.Score += times * 2;
                   //                credit.Score -= times * 2;
                   //            }
                   //            return true;
                   //        case 8:
                   //            {
                   //                banker_credit.Score += times * 3;
                   //                credit.Score -= times * 3;
                   //            }
                   //            return true;
                   //        case 9:
                   //            {
                   //                banker_credit.Score += times * 3;
                   //                credit.Score -= times * 3;
                   //            }
                   //            return true;
                   //        case 10:
                   //            {
                   //                banker_credit.Score += times * 4;
                   //                credit.Score -= times * 4;
                   //            }
                   //            return true;
                   //        case -1:
                   //            {

                   //                banker_credit.Score += times * 1;
                   //                credit.Score -= times * 1;
                   //                return true;



                   //            }
                   //        default:
                   //            {
                   //                banker_credit.Score += times;
                   //                credit.Score -= times;
                   //            } return true;

                   //    }
                   //}
               }
           }
           return false;
       }
    }
}

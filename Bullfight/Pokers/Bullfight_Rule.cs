using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokers
{
   public class Bullfight_Rule:IRules
    {
       Card_Name name;
       
       //设计失误
       int packs;
       /// <summary>
       /// 规则排序的存储
       /// </summary>
       int[] Rules_Save;
       /// <summary>
       /// 存储筛选过后的数组链表
       /// </summary>
       List<int[]> Select_Save_List;
       /// <summary>
       /// 确定游戏规则的被除数
       /// </summary>
       int DividedNumber;
       /// <summary>
       /// 普通牌的数字代换牌的方法
       /// </summary>
       /// <param name="cardName">牌型名称</param>
       /// <param name="temp">暂存数字</param>
       /// <returns>扑克牌名</returns>
       string switchReturn(string cardName, int temp)
       {
           switch ((temp) % (13))
           {

               case 1:
                   return cardName + "4";
               case 2:
                   return cardName + "5";
               case 3:
                   return cardName + "6";
               case 4:
                   return cardName + "7";
               case 5:
                   return cardName + "8";
               case 6:
                   return cardName + "9";
               case 7:
                   return cardName + "10";
               case 8:
                   return cardName + "J";
               case 9:
                   return cardName + "Q";
               case 10:
                   return cardName + "K";
               case 11:
                   return cardName + "A";
               case 12:
                   return cardName + "2";
               case 0:
                   return cardName + "3";
               default:
                   return "Wrong";


           }

       }
       public string IntToPokers(int value)
        {
            switch ((value) / (13 * packs))
            {
                case 0:
                    return switchReturn(name.Club, value);
                case 1:
                    return switchReturn(name.Diamon, value);
                case 2:
                    return switchReturn(name.Peach, value);
                case 3:
                    return switchReturn(name.Hearts, value);
                case 4:
                    switch ((value) % 2)
                    {
                        case 1:
                            return  name.Big_Joker;
                        case 0:
                            return name.Little_Joker;
                        default:
                            return "wrong";

                    }
                default:
                    return "wrong";

            }
        }

       public List<int> AscendSort(List<int> coreCards)
        {
          DescendSort(coreCards).Reverse();
          return coreCards;
        }

       public List<int> DescendSort(List<int> coreCards)
        {
           //逆天的渣算法
            int temp = -1;
            coreCards.Sort();
            List<int> ListLittle_Joker = new List<int>();
            List<int> ListBig_Joker = new List<int>();
            for (int i = 0; i < coreCards.Count - 1; i++)
            {
                temp = coreCards[i];
                for (int j = i + 1; j < coreCards.Count; j++)
                {
                    if ((temp % 13) <= coreCards[j] % 13)
                    {
                        temp = coreCards[j];
                        coreCards[j] = coreCards[i];
                        coreCards[i] = temp;
                    }
                }
            }
            for (int i = 0; i < coreCards.Count; i++)
            {
                if (coreCards[i] / (13 * packs) == 4)
                {
                    if (coreCards[i] % 2 == 0)
                    {
                        ListLittle_Joker.Add(coreCards[i]);
                    }
                    if(coreCards[i]%2==1)
                    {
                        ListBig_Joker.Add(coreCards[i]);
                    }
                }

            }
            for (int i = 0; i < ListLittle_Joker.Count; i++)
            {
                coreCards.Remove(ListLittle_Joker[i]);
            }
            for (int i = 0; i <ListLittle_Joker.Count; i++)
            {
                coreCards.Insert(0, ListLittle_Joker[i]);
            }

            for (int i = 0; i < ListBig_Joker.Count; i++)
            {
                coreCards.Remove(ListBig_Joker[i]);
            }
            for (int i = 0; i < ListBig_Joker.Count; i++)
            {
                coreCards.Insert(0, ListBig_Joker[i]);
            }
              
            return coreCards;
        }

        public bool IsBiger(int CompareValue, int OriginalValue)
        {
            throw new NotImplementedException();
        }

        public List<int> ToPoints(List<int> cards)
        {
            List<int>card=new List<int>(cards.ToArray());
          
            for(int i=0;i<card.Count;i++)
            {
                if (card[i]/(13 * packs) == 4)
                    card[i] = 10;
                else
                {
                    switch(card[i]%13)
                    {
                        case 0:
                            card[i] = 3;
                            break;
                        case 1:
                            card[i] = 4;
                            break;
                        case 2:
                            card[i] = 5;
                            break;
                        case 3:
                            card[i] = 6;
                            break;
                        case 4:
                            card[i]=7;
                            break;
                        case 5:
                            card[i]=8;
                            break;
                        case 6:
                            card[i]=9;
                            break;
                        case 11:
                            card[i] = 1;
                            break;
                        case 12:
                            card[i] = 2;
                            break;
                        default:
                            card[i] = 10;
                            break;
                     
                    }
                }
            }
            return card;
        }
  
        public bool SetRules(int Packs, Card_Name name)
        {
            if (name.Big_Joker != "" && name.Club != "" && name.Diamon != "" && name.Hearts != "" && name.Little_Joker != ""
    && name.Peach != "")
            {
              
                packs = Packs;
                this.name = name;
                return true;
            }
            else
            {
                return false;
            }
        }
         /// <summary>
         /// 游戏规则计算递归方法
         /// </summary>
         /// <param name="Point"></param>
         /// <param name="n">选中的数量</param>
         /// <param name="startIndex">起始位置</param>
        public void Caculatings(List<int>Point,int n,int startIndex)
        {
            if (n >0)
            {
                for (int i = startIndex; i < Point.Count - n + 1; i++)
                {
                    Rules_Save[Rules_Save.Length-n]=Point[i];
                    Caculatings(Point, n - 1, ++startIndex);
               
                }
            }
            else
            {
                int counter=0;
                for (int i = 0; i < Rules_Save.Length; i++)
                  counter+=Rules_Save[i];
               
                if(counter%DividedNumber==0)
                {
               
                    Select_Save_List.Add((int[])Rules_Save.Clone());
                }     
            }
        }
       /// <summary>
       /// 设置游戏规则
       /// </summary>
       /// <param name="selectNumber">选中的数量</param>
       /// <param name="divideNumber">被除数</param>
       /// <returns></returns>
        public bool CaculateSet(int selectNumber,int divideNumber)
        {
            if (selectNumber > 0)
            {
                Rules_Save = new int[selectNumber];
                DividedNumber = divideNumber;
              Select_Save_List  =new List<int[]>();
                return true;
            }
            else
                return false;


        }
         
        ///<summary>
        //斗牛游戏规则
        ///</summary>
        ///<param name="Point"></param>
        ///<returns></returns>
        public int PointResult(List<int> Point)
        {
            int max = 0;
            if (CaculateSet(3, 10) == true)
            {
                Caculatings(Point, 3,0);
            }
            if (Select_Save_List.Count == 0)
                return -1;
            else
            {
                List<int> runsPoint;
                int temp = 0;
                for (int i = 0; i < Select_Save_List.Count; i++)
                {
                    temp = 0;
                    runsPoint = Point;
                    for (int j = 0; j < Select_Save_List[i].Length; j++)
                    {
                        runsPoint.Remove(Select_Save_List[i][j]);
                    }
                    for (int k = 0; k < runsPoint.Count; k++)
                        temp += runsPoint[k];
                    if (max < temp)
                        max = temp;

                }
            }
            if(max%10==0)
            {
                return 10;
            }
            else
            return max % 10;
            
        }

       
    }
}

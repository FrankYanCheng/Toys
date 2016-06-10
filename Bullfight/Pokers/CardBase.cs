using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokers
{
    /// <summary>
    /// 基准牌类
    /// </summary>
   public  class CardBase
    {
       static Random r=new Random();
       /// <summary>
       /// 牌堆
       /// </summary>
     protected  Stack<int> CardStack;
       List<int> listIndex;
       int[] porkers;
     public  int packs;
       public CardBase(int packs)
       {
           this.packs = packs;
           porkers = new int[packs * 52];
           listIndex = new List<int>();
           CardStack = new Stack<int>();
       }
       /// <summary>
       /// 洗牌
       /// </summary>
       public void Shuffle()
       {
           int temp;
           listIndex.Clear();
           CardStack.Clear();
           //重新添加牌
           for(int i=0;i<52*packs;i++)
           {
               listIndex.Add(i);
           }
           while(listIndex.Count!=0)
           {
               //产生的随机序号
             temp=r.Next(0, listIndex.Count);
             CardStack.Push(listIndex[temp]);
             listIndex.Remove(listIndex[temp]);
           
           }
           
       }
       /// <summary>
       /// 检测牌是否发完
       /// </summary>
       /// <returns></returns>
       public bool IsEmpty()
       {
           if (CardStack.Count != 0)
           {
               return false;
           }
           else
           {
               return true;
           }
       }
       public int PorkersCount()
       {
           return CardStack.Count;
       }
       /// <summary>
       /// 发牌
       /// </summary>
       /// <returns></returns>
       public int Play()
       {
       
           return  CardStack.Pop();
       }
    }
}

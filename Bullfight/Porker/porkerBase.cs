using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
namespace Porker
{
    /// <summary>
    /// 普通扑克类
    /// </summary>
  public  abstract  class porkerBase
    {
      public string PorkerStyle;
      public Stack<int> PorkerStack;
     protected static Random cardIndex=new Random();
      //为洗牌效率设计
     protected List<int> RandomList;
     protected int index;
      public porkerBase(string porkerStyle)
      {
          PorkerStyle = porkerStyle;
          PorkerStack = new Stack<int>();
          Shuffle();
      }
      /// <summary>
      /// 洗牌
      /// </summary>
      public abstract void Shuffle();
      /// <summary>
      /// 出牌
      /// </summary>
      /// <returns>返回牌型</returns>
      public abstract string Play();


    }
}

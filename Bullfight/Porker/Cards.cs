using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porker
{
   public class Cards:porkerBase
    {
       public Cards(string style):base(style)
       {
           base.PorkerStyle = style;
       }
       public override void Shuffle()
       {
           PorkerStack.Clear();
           RandomList = new List<int>();
           for (int i = 1; i < 14; i++)
               RandomList.Add(i);

           while (RandomList.Count != 0)
           {
               index = cardIndex.Next(0, RandomList.Count);
               PorkerStack.Push(RandomList[index]);
               RandomList.Remove(RandomList[index]);
           }
        
       }
       public override string Play()
       { 
           if (PorkerStack.Count != 0)
          {
              switch (PorkerStack.Peek())
              {
                  case 11:
                      PorkerStack.Pop();
                      return PorkerStyle+"J";
                  case 1:
                      PorkerStack.Pop();
                      return PorkerStyle + "A";
                  case 12:
                      PorkerStack.Pop();
                      return PorkerStyle + "Q";
                  case 13:
                      PorkerStack.Pop();
                      return PorkerStyle + "k";
                  default:
                      return PorkerStyle + PorkerStack.Pop().ToString();

              }

          }
          else
          {
              return null;
          }  
       }
    }
}

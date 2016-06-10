using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porker
{
  public  class Jokers:porkerBase
    {
         public Jokers(string style):base(style)
       {
           base.PorkerStyle = style;
       }
        public override void Shuffle()
        {
            PorkerStack.Clear();
            RandomList = new List<int>();
            for (int i = 1; i < 3; i++)
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
                    case 1:
                        PorkerStack.Pop();
                        return "大王";
                    case 2:
                        PorkerStack.Pop();
                        return "小王";
                    default:
                        return "wrong";

                }

            }
            else
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventLibrary
{
   public class LimitionEventargs:EventArgs
    {
      public double limition=0;
       public LimitionEventargs(double limition)
       {
           this.limition = limition;
       }
       public LimitionEventargs()
       {
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventLibrary
{
   public class LimitionEventCloseArgs:EventArgs
    {
       public bool isOpen = false;
       public LimitionEventCloseArgs()
       {
       }
    }
}

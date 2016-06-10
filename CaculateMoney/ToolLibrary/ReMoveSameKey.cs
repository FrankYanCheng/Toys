using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary
{
   public class ReMoveSameKey
    {
       Dictionary<double, int> DiCount = new Dictionary<double, int>();
       int c = 0;
       int x = 0;
       public double[] finalkey(double[] Cost)
       {
          
           for(int i =0;i<Cost.Length;i++)
           {
               if (!DiCount.Keys.Contains(Cost[i]))
               {
                   DiCount.Add(Cost[i], 1);
                    c++;
                   
               }
           }
           DiCount.Clear();
           double[] z = new double[c];
           for (int i = 0; i < Cost.Length; i++)
           {
               if (!DiCount.Keys.Contains(Cost[i]))
               {
                   DiCount.Add(Cost[i], 1);
                   z[x] = Cost[i];
                   x++;

               }
           }
          
      
           return z;
       }
    }
}

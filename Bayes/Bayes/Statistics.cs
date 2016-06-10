using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayes
{
    /// <summary>
    /// 统计次数类
    /// </summary>
   public class Statistics
    {
     public  Dictionary<string, int> di_text; 
       public Statistics(List<string> Li_text)
      {
          di_text = new Dictionary<string, int>();
           foreach(string word in Li_text)
           {
                if(di_text.Keys.Contains(word))
                {
                    di_text[word]++;
                }
                else
                {
                    di_text.Add(word, 1);
                }
           }
           //var result = (from pair in di_text orderby pair.Value descending select pair).ToList();
           //const double rate=0.2;
           //int counts_text = Convert.ToInt32(result.Count*(rate));
           //int percent_counts=0;int total_counts=0;
           //for (int i = 0; i < result.Count; i++)
           //{
           //    if(i==counts_text)
           //    {
           //        percent_counts = total_counts;
           //    }
           //    total_counts += result[i].Value;
           //}
          
           //Console.WriteLine((double)percent_counts/total_counts);
          
      }

       
    }
}

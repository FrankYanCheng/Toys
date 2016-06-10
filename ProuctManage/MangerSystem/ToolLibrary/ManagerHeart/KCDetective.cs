using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.ManagerHeart
{
   public class KCDetective
    {
      public  int Count;
        /// <summary>
        /// 库存监测
        /// </summary>
        /// <param name="txt"></param>
        public KCDetective(string txt)
        {
            try
            {
                int j = txt.IndexOf("*"); 
               Count =Convert.ToInt32(txt.Substring(j + 1, txt.Length - j - 1));
                
                }
            
            catch
            {

            }
            {
            }
        }
    }
}

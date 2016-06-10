using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokers
{
    /// <summary>
    /// 牌名数据项
    /// </summary>
   public  struct Card_Name
    {
      
       string diamond;    
      /// <summary>
      /// 方块
      /// </summary>
    public string Diamon{
   get { return diamond; }
   set { diamond = value; }
      }
     
      string  club;
        /// <summary>
       /// 梅花
       /// </summary>
     public string Club
    {
      get { return club; }
      set { club = value; }
    }
          string  peach;
       /// <summary>
       /// 桃花
       /// </summary>
       public string Peach
     {
  get { return peach; }
  set { peach = value; }
    }
        string  hearts;

       /// <summary>
       /// 红桃
       /// </summary>
       public string Hearts
{
  get { return hearts; }
  set { hearts = value; }
}

     
      string big_Joker;
        /// <summary>
       /// 大王
       /// </summary>
       public string Big_Joker
{
  get { return big_Joker; }
  set { big_Joker = value; }
}

   
     
       string little_Joker;
       /// <summary>
       /// 小王
       /// </summary>
       public string Little_Joker
       {
           get { return little_Joker; }
           set { little_Joker = value; }
       }

   

}
}

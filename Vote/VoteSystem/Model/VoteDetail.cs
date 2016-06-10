using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 投票细节属性类
    /// </summary>
   public class VoteDetail
    {
        string ip;
       /// <summary>
       /// 投票的Ip
       /// </summary>
        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        string sno;
       /// <summary>
       /// 给投票的学号
       /// </summary>
        public string Sno
        {
            get { return sno; }
            set { sno = value; }
        }
    }
}

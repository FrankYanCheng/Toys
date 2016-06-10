using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 主题属性类
    /// </summary>
   public  class Titles
    {
        int id;
       /// <summary>
       /// 唯一编号
       /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string title;
       /// <summary>
       /// 主题名称
       /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        string summary;
       /// <summary>
       /// 主题简介
       /// </summary>

        public string Summary
        {
            get { return summary; }
            set { summary = value; }
        }
    }
}

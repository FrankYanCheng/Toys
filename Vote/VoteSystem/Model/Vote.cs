using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 投票属性类
    /// </summary>
  public  class Vote
    {
        string title;
      /// <summary>
      /// 参与投票的主题
      /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        string sno;
      /// <summary>
      /// 参投学号
      /// </summary>
        public string Sno
        {
            get { return sno; }
            set { sno = value; }
        }
        string name;
      /// <summary>
      /// 参与投票人姓名
      /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string picPath;
      /// <summary>
      /// 参与投票人头像地址
      /// </summary>
        public string PicPath
        {
            get { return picPath; }
            set { picPath = value; }
        }
        string className;
      /// <summary>
      /// 参与投票人班级
      /// </summary>
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
        string introduce;
      /// <summary>
      /// 参与投票人简介
      /// </summary>
        public string Introduce
        {
            get { return introduce; }
            set { introduce = value; }
        }
        bool isPermission;
      /// <summary>
      /// 是否通过审核
      /// </summary>
        public bool IsPermission
        {
            get { return isPermission; }
            set { isPermission = value; }
        }
        int count;
      /// <summary>
      /// 票数
      /// </summary>
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        int id;
      /// <summary>
      /// 投票主题Id
      /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}

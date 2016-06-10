using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    /// <summary>
    /// 主题数据库类
    /// </summary>
  public  class TitleDAO
    {
      SqlHelper sqlHelper;
      public TitleDAO()
      {
          sqlHelper = new SqlHelper();
      }
      /// <summary>
      /// 根据标题找id
      /// </summary>
      /// <returns></returns>
      public DataTable TitleToId(Titles title)
      {
          string cmd = "select Id from Title Where Title=@title";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@title",title.Title)
    

         };
          DataTable result = sqlHelper.ExcuteQuery(cmd, spr, CommandType.Text);
          return result;
      }
      /// <summary>
      /// 根据Id寻找标题
      /// </summary>
      /// <param name="title"></param>
      /// <returns></returns>
      public DataTable IdToTitle(Titles title)
      {
          string cmd = "select Title from Title Where Id=@id";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@id",title.Id)
    

         };
          DataTable result = sqlHelper.ExcuteQuery(cmd, spr, CommandType.Text);
          return result;
      }
      /// <summary>
      /// 查看所有主题和简介
      /// </summary>
      /// <returns></returns>
      public DataTable  SelectTitles()
      {
          string pro = "ProSelectTitles";
          DataTable result = sqlHelper.ExcuteQuery(pro, CommandType.StoredProcedure);
          return result;
      
      }

      /// <summary>
      /// 添加主题
      /// </summary>
      /// <param name="titles">主题及简介</param>
      /// <returns>是否添加成功</returns>
        public bool InsertTitle(Titles titles)
        {
            string pro = "ProInsertTitle";
            SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@Title",titles.Title),
             new SqlParameter("@Summary",titles.Summary)
         };
         int i= sqlHelper.ExecuteNoQuery(pro, spr, CommandType.StoredProcedure);
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
         }
      /// <summary>
      /// 删除主题及简介
      /// </summary>
      /// <param name="titles"></param>
      /// <returns>是否正确删除</returns>
      public bool DeleteTitle(Titles titles)
        {
            string pro = "ProDeleteTitle";
            SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@title",titles.Title),
                new SqlParameter("@id",titles.Id)
         };
            int i = sqlHelper.ExecuteNoQuery(pro, spr, CommandType.StoredProcedure);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      /// <summary>
      /// 修改主题及简介
      /// </summary>
      /// <param name="titles"></param>
      /// <returns></returns>
      public bool AlterTitle(Titles titles)
      {
          string pro = "ProAlterTitle";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@title",titles.Title),
             new SqlParameter("@summary",titles.Summary),
             new SqlParameter("@id",titles.Id)
         };
          int i = sqlHelper.ExecuteNoQuery(pro, spr, CommandType.StoredProcedure);
          if (i > 0)
          {
              return true;
          }
          else
          {
              return false;
          }
      }

    }
}

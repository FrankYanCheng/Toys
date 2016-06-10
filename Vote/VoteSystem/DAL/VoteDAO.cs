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
    /// 投票管理
    /// </summary>
  public  class VoteDAO
    {
      SqlHelper sqlHelper;
      public  VoteDAO()
      {
          sqlHelper = new SqlHelper();
      }
        /// <summary>
        /// 投票参与人添加
        /// </summary>
        /// <param name="vote">投票人属性类</param>
       /// <returns></returns>
       public bool  InsertVote(Vote vote)
      {
          string pro = "ProInsertVote";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@Introduce",vote.Introduce),
             new SqlParameter("@ClassName",vote.ClassName),
             new SqlParameter("@Id",vote.Id),
             new SqlParameter("@Name",vote.Name),
             new SqlParameter("@PicPath",vote.PicPath),
             new SqlParameter("@Sno",vote.Sno),

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
      /// 根据学号删除投票人信息
      /// </summary>
      /// <param name="vote">投票人属性</param>
      /// <returns></returns>
      public bool DeleteVote(Vote vote)
       {
           string pro = "ProDeleteVote";
           SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@Sno",vote.Sno),

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
      /// 修改投票人信息
      /// </summary>
      /// <param name="vote"></param>
      /// <returns></returns>
      public bool AlterVote(Vote vote)
      {
          string pro = "ProAlterVote";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@introduce",vote.Introduce),
             new SqlParameter("@className",vote.ClassName),
             new SqlParameter("@id",vote.Id),
             new SqlParameter("@name",vote.Name),
             new SqlParameter("@picPath",vote.PicPath),
             new SqlParameter("@sno",vote.Sno),

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
      
       #region 查找方法


      /// <summary>
      /// 显示所有投票者信息,按降序排列
      /// </summary>
      /// <returns></returns>
      public DataTable selectAll()
      {
          string pro = "ProSelectVotes";
          DataTable result = sqlHelper.ExcuteQuery(pro, CommandType.StoredProcedure);
          return result;
      }
      /// <summary>
      /// 根据参与投票者学号查找已投票数和姓名
      /// </summary>
      /// <param name="vote">参与投票人学号</param>
      /// <returns></returns>
      public DataTable selectBySno(Vote vote)
      {
          string pro = "ProSelectVote";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@sno",vote.Sno)
    

         };
          DataTable result = sqlHelper.ExcuteQuery(pro,spr, CommandType.StoredProcedure);
          return result;
      }
      /// <summary>
      /// 显示所有已通过投票者信息
      /// </summary>
      /// <returns></returns>
      public DataTable selectAllRight()
      {
          string pro = "ProSelectVotesRight";
          DataTable result = sqlHelper.ExcuteQuery(pro, CommandType.StoredProcedure);
          return result;
      }
      /// <summary>
      /// 如果该学生通过验证，则成功显示信息
      /// </summary>
      /// <param name="vote"></param>
      /// <returns></returns>
      public DataTable selectBySnoRight(Vote vote)
      {
          string pro = "ProSelectVoteRight";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@sno",vote.Sno)
    

         };
          DataTable result = sqlHelper.ExcuteQuery(pro, spr,CommandType.StoredProcedure);
          return result;
      }

      //分类查找


      /// <summary>
      /// 根据主题信息查找目录下的学生信息
      /// </summary>
      /// <param name="title"></param>
      /// <returns></returns>
      public DataTable selectByTitle(Titles title)
      {
          string pro = "ProSelectByTitle";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@title",title.Title)
    

         };
          DataTable result = sqlHelper.ExcuteQuery(pro, spr, CommandType.StoredProcedure);
          return result;
      }
      /// <summary>
      /// 查找所有已通过审核的主题下目录学生信息
      /// </summary>
      /// <param name="title"></param>
      /// <returns></returns>
      public DataTable selectByTitleRight(Titles title)
      {
          string pro = "ProSelectByTitleRight";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@title",title.Title)
    

         };
          DataTable result = sqlHelper.ExcuteQuery(pro, spr, CommandType.StoredProcedure);
          return result;
      }
      /// <summary>
      /// 查找未通过审核下的主题目录学生信息
      /// </summary>
      /// <param name="title"></param>
      /// <returns></returns>

      public DataTable selectByTitleWrong(Titles title)
      {
          string pro = "ProSelectByTitleWrong";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@title",title.Title)
    

         };
          DataTable result = sqlHelper.ExcuteQuery(pro, spr, CommandType.StoredProcedure);
          return result;
      }

        #endregion
      /// <summary>
      /// 通过审核
      /// </summary>
      /// <param name="vote">参与投票人</param>
      /// <returns></returns>
      public bool Permisson(Vote vote)
      {
          string pro = "ProPermission";
          SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@sno",vote.Sno),

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

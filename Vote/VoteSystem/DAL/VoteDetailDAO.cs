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
   public class VoteDetailDAO
    {
       SqlHelper sqlHelper;
       public VoteDetailDAO()
       {
           sqlHelper = new SqlHelper();
       }
       /// <summary>
       /// 投票记录
       /// </summary>
       /// <param name="detail">投票详细信息属性</param>
       /// <returns></returns>
       public bool Insert(VoteDetail detail)
       {
           string pro = "ProInsertDetail";
           SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@sno",detail.Sno),
             new SqlParameter("@ip",detail.Ip)

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
       /// 显示所有已通过成员票数信息
       /// </summary>
       /// <returns></returns>
       public DataTable CountSelectAll()
       {
           string pro = "ProCountSelectAll";
           return sqlHelper.ExcuteQuery(pro, CommandType.StoredProcedure);
       }
 
       /// <summary>
       /// 根据主题选择显示票数信息
       /// </summary>
       /// <param name="title"></param>
       /// <returns></returns>
       public DataTable CountSelectByTitle(Titles title)
       {
           string pro = "ProCountSelectByTitle";
           SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@title",title.Title),
         };
           return sqlHelper.ExcuteQuery(pro, spr, CommandType.StoredProcedure);
          
       }

    }
}

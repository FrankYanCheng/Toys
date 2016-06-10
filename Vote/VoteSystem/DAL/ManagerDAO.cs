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
    ///后台登录管理 
    /// </summary>
   public class ManagerDAO
    {
       SqlHelper sqlHelper = null;
       /// <summary>
       /// 初始化
       /// </summary>
      public ManagerDAO()
      {
          sqlHelper = new SqlHelper();
      }
       /// <summary>
       /// 判断是否为管理员
       /// </summary>
       /// <param name="manager"></param>
       /// <returns></returns>
       public bool IsAdministrator(Manager manager)
       {
           string pro = "ProManager";
           SqlParameter[] spr = new SqlParameter[]
         {
             new SqlParameter("@User",manager.User)
         };
          DataTable  result= sqlHelper.ExcuteQuery(pro, spr, CommandType.StoredProcedure);
          if(result.Rows[0]["Pwd"].ToString()==manager.Pwd)
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

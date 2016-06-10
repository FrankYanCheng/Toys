using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DAL
{
    /// <summary>
    /// 数据库基类
    /// </summary>
    public class SqlHelper
    {
        SqlConnection con = null;
        SqlCommand com = null;

        public SqlHelper()
        {
            con = new SqlConnection();
            com = new SqlCommand();
            string connStr = ConfigurationManager.ConnectionStrings["Connstr"].ConnectionString;
            con = new SqlConnection(connStr);
        }
        private SqlConnection GetConn()
        {
            if (ConnectionState.Closed == con.State)
            {
                con.Open();
            }
            return con;

        }
        /// <summary>
        /// 插入方法
        /// </summary>
        /// <param name="sqlcom">传入的Sql命令</param>
        /// <param name="ct">命令类型</param>
        /// <returns>返回受影响行数</returns>
        public int ExecuteNoQuery(string sqlcom, CommandType ct)
        {

            using (SqlCommand com = new SqlCommand(sqlcom, GetConn()))
            {
                com.CommandType = ct;
                int i =
                                com.ExecuteNonQuery();
                return i;
            }

        }
        /// <summary>
        /// 带参数的插入方法
        /// </summary>
        /// <param name="sqlcom">SQL命令语句</param>
        /// <param name="paras">传入的参数</param>
        /// <param name="ct">命令类型</param>
        /// <returns></returns>
        public int ExecuteNoQuery(string sqlcom, SqlParameter[] paras, CommandType ct)
        {

            using (SqlCommand com = new SqlCommand(sqlcom, GetConn()))
            {
                com.CommandType = ct;
                com.Parameters.AddRange(paras);

                int i =
                               com.ExecuteNonQuery();

                return i;
            }

        }
        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sqlcom">执行语句</param>
        /// <param name="ct">命令类型</param>
        /// <returns>返回数据表</returns>
        public DataTable ExcuteQuery(string sqlcom, CommandType ct)
        {


            using (SqlCommand com = new SqlCommand(sqlcom, GetConn()))
            {
                com.CommandType = ct;
                SqlDataReader reader = com.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                reader.Close();

                return table;
            }


        }
        /// <summary>
        /// 带参数的查询方法
        /// </summary>
        /// <param name="sqlcom">存储过程名称或命令参数</param>
        /// <param name="paras">带传参数</param>
        /// <param name="ct">命令类型</param>
        /// <returns></returns>
        public DataTable ExcuteQuery(string sqlcom, SqlParameter[] paras, CommandType ct)
        {

            using (SqlCommand com = new SqlCommand(sqlcom, GetConn()))
            {
                com.CommandType = ct;
                com.Parameters.AddRange(paras);
                SqlDataReader reader = com.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                reader.Close();

                return table;
            }
        }


    }
}

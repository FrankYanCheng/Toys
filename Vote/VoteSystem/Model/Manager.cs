using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 后台用户管理
    /// </summary>
    public class Manager
    {
        string user;
        /// <summary>
        /// 用户名
        /// </summary>
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        string pwd;
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace AutoDown
{
    
    [ServiceContract]
   public interface ITarget
    {
        /// <summary>
        /// 截图方法
        /// </summary>
        [OperationContract]
       byte[] Draw();
        /// <summary>
        /// 关机倒计时方法
        /// </summary>
        [OperationContract]
        void TimeDown();
        /// <summary>
        /// 验证密码方法
        /// </summary>
        /// <param name="pwd">远程密码</param>
        /// <returns></returns>
        [OperationContract]
        bool IsPwd(string pwd);
    }
}

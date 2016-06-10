using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoDown
{
    public class SecurityGurd
    {
        /// <summary>
        /// 添加开放端口
        /// </summary>
        /// <param name="numberType">开放端口号</param>
        public SecurityGurd(int numberType)
        {
            try
            {
                //创建firewall管理类的实例
                INetFwMgr netFwMgr = (INetFwMgr)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwMgr"));
                INetFwOpenPort objPort = (INetFwOpenPort)Activator.CreateInstance(
                   Type.GetTypeFromProgID("HNetCfg.FwOpenPort"));
                objPort.Name = "TransPort";
                objPort.Port =numberType;
                objPort.Protocol = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
                objPort.Scope = NET_FW_SCOPE_.NET_FW_SCOPE_ALL;
                objPort.Enabled = true;
                bool exist = false;
                //加入到防火墙的管理策略
                foreach (INetFwOpenPort mPort in netFwMgr.LocalPolicy.CurrentProfile.GloballyOpenPorts)
                {
                    if (objPort == mPort)
                    {
                        exist = true;
                        break;
                    }
                }
                if (!exist) netFwMgr.LocalPolicy.CurrentProfile.GloballyOpenPorts.Add(objPort);
            }
            catch
            {

            }
        }
    }
}

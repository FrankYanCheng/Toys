using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace AutoDown
{
   public class IpGet
    {
       /// <summary>
       /// 获取本地Ip
       /// </summary>
       /// <returns></returns>
       public string Get()
       {
           string k = null;
           string AddressIP = string.Empty;
           foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
           {
               if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
               {
                   AddressIP = _IPAddress.ToString();
               }
           }
           return k = AddressIP;
       }
    }
}

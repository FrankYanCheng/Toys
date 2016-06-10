using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace FileReaderLibrary
{
   public class FileReader
    {
        /// <summary>
        /// 查找文件，返回内容（安全模式）
        /// </summary>
        /// <param name="name">文件名称</param>
        /// <param name="ParentMuru">文件根目录</param>
        /// <returns>读取的内容</returns>
        public string[] SecurityReader(string name, string ParentMuru)
        {
            SecurityGuard securityReader = new SecurityGuard();//文件解密
            try
            {
                string[] txt;//读取的字符串
                using (FileStream fil = new FileStream(ParentMuru + @"\" + name + ".txt", FileMode.Open))
                {

                    StreamReader reader = new StreamReader(fil, Encoding.UTF8);
                    string nativetxt = reader.ReadToEnd();

                    return txt =securityReader.SecurityReader(nativetxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));



                }
            }
            catch
            {
                return null;
            }
        }
    }
}

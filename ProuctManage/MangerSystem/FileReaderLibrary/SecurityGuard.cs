using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace FileReaderLibrary
{
    /// <summary>
    /// 安全工具类
    /// </summary>
   class SecurityGuard
    {
       /// <summary>
       /// 加密工具
       /// </summary>
       /// <param name="NativeTxt">写入的字符串数组</param>
       /// <returns>返回加密字符串数组</returns>
       public string[] SecurityWriter(string [] NativeTxt)
       {
            StringBuilder changestring = new StringBuilder();
           for(int i=0;i<NativeTxt.Length;i++)
           {
               changestring.Clear();
               char[] PartChar = NativeTxt[i].ToCharArray();
               for (int j = 0; j <PartChar.Length; j++)
               {
                   
                 changestring.Append((((Char)((((int)(((Char)PartChar[j])))+27)))));

               }
               NativeTxt[i] = changestring.ToString();
              

           }
           return NativeTxt;
       }
       /// <summary>
       /// 加密工具
       /// </summary>
       /// <param name="NativeTxt">写入的字符串</param>
       /// <returns>返回加密字符串</returns>
       public string SecurityWriter(string NativeTxt)
       {
           StringBuilder changestring = new StringBuilder();
           changestring.Clear();
           char[] PartChar = NativeTxt.ToCharArray();
           for (int j = 0; j < PartChar.Length; j++)
           {

               changestring.Append((((Char)((((int)(((Char)PartChar[j])))+27)))));

           }
           NativeTxt = changestring.ToString();
           return NativeTxt;
       }
       /// <summary>
       /// 解密工具
       /// </summary>
       /// <param name="ComplexTxt">加密过的字符串数组</param>
       /// <returns>返回原文件</returns>
       public string[] SecurityReader(string[] ComplexTxt)
       {
           StringBuilder changestring = new StringBuilder();
           for (int i = 0; i < ComplexTxt.Length; i++)
           {
               changestring.Clear();
               char[] PartChar = ComplexTxt[i].ToCharArray();
               for (int j = 0; j < PartChar.Length; j++)
               {

                   changestring.Append(((Char)((((int)((Char)PartChar[j]))-27))));

               }
               ComplexTxt[i] = changestring.ToString();


           }
           return ComplexTxt;
       }
    }
}

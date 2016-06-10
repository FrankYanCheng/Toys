using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary
{
    /// <summary>
    /// 带有相同字符串数组去相同项类
    /// </summary>
    public class SameCount
    {
        int CountFinal = 0;
        public Dictionary<string, int> DiSameRemove = new Dictionary<string, int>();
        /// <summary>
        /// 去相同值方法
        /// </summary>
        /// <param name="txt">原值</param>
        /// <returns>返回数组</returns>
        public string[] SameReturn(string[] txt)
        {

            for (int i = 0; i < txt.Length; i++)
            {
                if (DiSameRemove.ContainsKey(txt[i]))
                {
                    DiSameRemove[txt[i]]++;
                }
                else
                {
                    DiSameRemove.Add(txt[i], 0);
                }
            }
            string[] finaltxt = new string[DiSameRemove.Count];
            foreach (string x in DiSameRemove.Keys)
            {

                finaltxt[CountFinal] = x;
                CountFinal++;
            }
            ;

            return finaltxt;
        }
    }
}

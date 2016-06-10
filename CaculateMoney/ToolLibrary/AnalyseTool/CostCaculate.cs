using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.AnalyseTool
{
    class CostCaculate
    {
        public double TotalCost;//当日总花费
        /// <summary>
        /// 编辑计算总花费
        /// </summary>
        /// <param name="TodayCaculate">总花费</param>
        public CostCaculate(string[] TodayCaculate)
        {
            for (int x = 0; x < TodayCaculate.Length; x++)
            {
                string[] part = TodayCaculate[x].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    TotalCost += Convert.ToDouble(part[part.Length - 1]);

                }

                catch
                {
                }
            }
        }
        /// <summary>
        /// 从给定的文件中取出最后的总花费
        /// </summary>
        /// <param name="LastCaculate">总计花费</param>
        public CostCaculate(string LastCaculate)
        {

            try
            {
                if (LastCaculate.Contains("总计花费"))
                {
                    int Count = LastCaculate.IndexOf('费');
                    TotalCost = Convert.ToDouble(LastCaculate.Substring(Count + 1, LastCaculate.Length - 2 - Count));

                }

            }

            catch
            {
            }
        }
    }
}

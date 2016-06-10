using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolLibrary.StringTool
{
    /// <summary>
    /// 年份检测类
    /// </summary>
  public  class Years
    {
            int year;
          /// <summary>
          /// 初始化年份检测类
          /// </summary>
          /// <param name=" year">年份</param>
            public Years(int year)
            {
                this.year = year;
                

            }
            /// <summary>
            /// 检测是否包含所需年份
            /// </summary>
            /// <param name="time">传入的时间</param>
            /// <returns>如果年份检测到则返回真，否则返回假</returns>
            public bool YearDetective(string time)
            {
                if (time.Contains(year+"年"))
                {
                    return true;
                }
                else
                    return false;
            }
    }
}

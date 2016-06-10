using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolLibrary.StringTool;
using FileReaderLibrary.DirectoryCreate;

namespace FormTool.MonthSave
{
    /// <summary>
    /// 以月份为基本文件夹的库存创建基类
    /// </summary>
   public class MSFundation
    {
          string root = "MSsystem";//日志文件夹的名称
          public MSFundation(string time)
      {
          GetTime createTime = new GetTime(time);//时间处理类   
          string year = createTime.GetYear();
          string month = createTime.GetMonth();
          string day = createTime.GetDay();
          DirectoryCreate dicreate = new DirectoryCreate(root);//判断是否创建了日志文件夹，以日期作为创建日期的标志
          DirectoryCreate diYear = new DirectoryCreate(root + @"\" + year);
          DirectoryCreate diMonth = new DirectoryCreate(root + @"\" + year + @"\" + month);
                        
      }
    }
}

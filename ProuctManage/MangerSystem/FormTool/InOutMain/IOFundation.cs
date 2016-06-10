using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolLibrary.StringTool;
using FileReaderLibrary.DirectoryCreate;

namespace FormTool.InOutMain
{
    /// <summary>
    /// 管理系统文件基类
    /// </summary>
 public   class IOFundation
    {
       string root = "IOSystem";//日志文件夹的名称
        public IOFundation(string time)
      {
          GetTime createTime = new GetTime(time);//时间处理类   
          string year = createTime.GetYear();
          string month = createTime.GetMonth();
          string day = createTime.GetDay();
          DirectoryCreate dicreate = new DirectoryCreate(root);//判断是否创建了日志文件夹，以日期作为创建日期的标志
          DirectoryCreate diYear = new DirectoryCreate(root + @"\" + year);
          DirectoryCreate diMonth = new DirectoryCreate(root + @"\" + year + @"\" + month);
          DirectoryCreate diDay = new DirectoryCreate(root + @"\" + year + @"\" + month + @"\" + day);

                        
      }
    }
}

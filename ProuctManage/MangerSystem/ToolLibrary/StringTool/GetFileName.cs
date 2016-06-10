using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ToolLibrary.StringTool
{
    /// <summary>
    /// 文件名称获得类
    /// </summary>
  public  class GetFileName
    {
      public string FinalName;
      public GetFileName(string name)
      {
        int z=  name.IndexOf(".");
     FinalName= name.Substring(0, z);
      }
    }
}

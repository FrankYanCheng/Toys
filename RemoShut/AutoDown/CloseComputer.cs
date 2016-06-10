using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AutoDown
{
    /// <summary>
    /// 实现关机类
    /// </summary>
 public   class CloseComputer
    {
     [DllImport("user32.dll", EntryPoint = "ExitWindowsEx", CharSet = CharSet.Ansi)]
     private static extern int ExitWindowsEx(int uFlags, int dwReserved); 
     /// <summary>
     /// 实现远程关机
     /// </summary>
     public CloseComputer()
     {
         System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
         myProcess.StartInfo.FileName = "cmd.exe";
         myProcess.StartInfo.UseShellExecute = false;
         myProcess.StartInfo.RedirectStandardInput = true;
         myProcess.StartInfo.RedirectStandardOutput = true;
         myProcess.StartInfo.RedirectStandardError = true;
         myProcess.StartInfo.CreateNoWindow = true;
         myProcess.Start();
         myProcess.StandardInput.WriteLine("shutdown -s -t 0"); 
     }

    }
}

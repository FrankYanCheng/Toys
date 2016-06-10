using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace AutoDown
{
    /// <summary>
    /// 实现远程方法
    /// </summary>
  public  class Target:ITarget
    {
        //声明一个API函数
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]

        private static extern bool BitBlt(

            IntPtr hdcDest, // 目标 DC的句柄
            int nXDest,
            int nYDest,
            int nWidth,
            int nHeight,
            IntPtr hdcSrc,  // 源DC的句柄
            int nXSrc,
            int nYSrc,
            System.Int32 dwRop  // 光栅的处理数值

            );
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr CreateDC(
        string lpszDriver, // 驱动名称
        string lpszDevice, // 设备名称
        string lpszOutput, // 无用，可以设定位"NULL"
        IntPtr lpInitData); // 任意的打印机数据
    
        public byte[] Draw()
        {
            //获得当前屏幕的大小
            Rectangle rect = new Rectangle();
            rect = Screen.GetWorkingArea(new Point(0, 0));
            IntPtr dc = CreateDC("DISPLAY", null, null, (IntPtr)null);
            //创建一个以当前屏幕为模板的图象
            Graphics g1 = Graphics.FromHdc(dc);
            //创建以屏幕大小为标准的位图 
            Image MyImage = new Bitmap(rect.Width, rect.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            //得到屏幕的DC
            IntPtr dc1 = g1.GetHdc();
            //得到Bitmap的DC 
            IntPtr dc2 = g2.GetHdc();
            //调用此API函数，实现屏幕捕获
            BitBlt(dc2, 0, 0, rect.Width, rect.Height, dc1, 0, 0, 13369376);
            //释放掉屏幕的DC
            g1.ReleaseHdc(dc1);
            //释放掉Bitmap的DC 
            g2.ReleaseHdc(dc2);
            MyImage.Save("截图.Bmp", ImageFormat.Bmp);
            FileStream fileStream = new FileStream("截图.Bmp", FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] buff;
            buff = binaryReader.ReadBytes((Int32)fileStream.Length);
            return buff;
        }

        public void TimeDown()
        {
            new CloseComputer();
        }

        public bool IsPwd(string pwd)
        {
            if (pwd == StaticThings.Pwd)
            {
                return true;
            }
            else
                return false;
        }
    }
}

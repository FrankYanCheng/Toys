using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porker_Bullfight
{
    /// <summary>
    /// 游戏位置结构体
    /// </summary>
   public struct GamePoisition
    {
        int original_X;
       /// <summary>
       /// 初始位置的X坐标
       /// </summary>

        public int Original_X
        {
            get { return original_X; }
            set { original_X = value; }
        }
        int original_Y;
       /// <summary>
       /// 初始位置的Y坐标
       /// </summary>
        public int Original_Y
        {
            get { return original_Y; }
            set { original_Y = value; }
        }
    
        int width;
        /// <summary>
        /// 宽度
        /// </summary>

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
     
        int heigth;
        /// <summary>
        /// 高度
        /// </summary>
        public int Heigth
        {
            get { return heigth; }
            set { heigth = value; }
        }
      
        int y_distance;
        /// <summary>
        /// 上下间距
        /// </summary>
        public int Y_distance
        {
            get { return y_distance; }
            set { y_distance = value; }
        }
      
        int x_distance;
        /// <summary>
        /// 左右间距
        /// </summary>

        public int X_distance
        {
            get { return x_distance; }
            set { x_distance = value; }
        }
    }
}

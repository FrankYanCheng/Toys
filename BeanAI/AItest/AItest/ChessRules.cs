using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AItest
{
    //棋子五连珠的游戏规则类
    class ChessRules
    {
        public  static  int[,] chess_map;//棋谱
       public static  int rank,column;
        public static int first_number;//余数，为0则是红色先,为1则是黑色先
        public static int combine_counts=5;//连子个数
        /// <summary>
        /// 盘上剩余棋子
        /// </summary>
        public static List<int> liLeft;
        int nusce_numbers;
        public ChessRules(int numbers)
        {
           
            this.nusce_numbers = numbers;
             
        }
        /// <summary>
        /// 五子连珠，-
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private bool column_combine(int i,int j,bool IsRed)
        {
            int chess_value=0;
            if (IsRed == true)
            {
                chess_value = 1;
            }
            else
                chess_value = -1;
             if(j+5<column)
             {
                 int temp = 0;
                 for (int k = j; k <j + nusce_numbers; k++)
                 {
                     if(chess_map[i,k]==chess_value)
                     temp++;
                 }
                 if (temp == nusce_numbers)
                     return true;
                 else
                     return false;
             }
             else
             return false;
        }
        private bool rank_combine(int i,int j,bool IsRed)
        {
            int chess_value = 0;
            if (IsRed == true)
            {
                chess_value = 1;
            }
            else
                chess_value = -1;
            if (i + nusce_numbers < rank)
            {
                int temp = 0;
                for (int k = i; k <i + nusce_numbers; k++)
                {
                    if (chess_map[k,j] == chess_value)
                        temp++;
                }
                if (temp == nusce_numbers)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        /// <summary>
        /// 斜加
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="IsRed"></param>
        /// <returns></returns>
        private bool cline_c_combine(int i, int j, bool IsRed)
        {
            int chess_value = 0;
            if (IsRed == true)
            {
                chess_value = 1;
            }
            else
                chess_value = -1;
            if (i + nusce_numbers<=rank && j + nusce_numbers <= column)
            {
                int temp = 0;
                for (int k = i; k < i + nusce_numbers; k++)
                {
                    if (chess_map[k, j++] == chess_value)
                        temp++;
                }
                if (temp == nusce_numbers)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        /// <summary>
        /// 斜减
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="IsRed"></param>
        /// <returns></returns>
        private bool cline_r_combine(int i, int j, bool IsRed)
        {
            int chess_value = 0;
            if (IsRed == true)
            {
                chess_value = 1;
            }
            else
                chess_value = -1;
            if (i + nusce_numbers <= rank && j - nusce_numbers + 1 >= 0)
            {
                int temp = 0;
                for (int k = i; k < i + nusce_numbers; k++)
                {
                    if (chess_map[k, j--] == chess_value)
                        temp++;
                }
                if (temp == nusce_numbers)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        //判断该执棋手是否赢得比赛，红的为偶数
        public bool Is_Win(int counts)
        {
               bool judgeterm=false;
               if (counts % 2 != first_number)
               {
                   judgeterm = true;

               }
               else
                   judgeterm = false;
                for (int i = 0; i < rank; ++i)
                {
                  
                    for (int j = 0; j < column; ++j)
                    {

                      
                        if (column_combine(i, j, judgeterm) || rank_combine(i, j, judgeterm) ||
                               cline_c_combine(i, j, judgeterm) || cline_r_combine(i, j, judgeterm))
                            return true;
                    }
                
              
            }
                return false;
        }




    }
}

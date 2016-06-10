//边界值还未解决
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AItest
{
    /// <summary>
    /// AI规则积分计算，默认人先走
    /// </summary>
   public class AICaculate
    {
       bool isEdge;//是否是边界以及勾勒边界的冲值判断
       bool judge;//判断是活冲
       int bean_judgeValueUp;//边界棋子上判断
       int bean_judge_ValueDown;//边界棋子下判断
        /// <summary>
        /// 用于判断为空的情况
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="limit"></param>
         /// <returns></returns>      
       bool judge_0(bool a, bool b, int limit)
       {
           if (limit == 0)
           {
               if (a && b)
                   return true;
               else
                   return false;
           }
           else
           {
               return (a ^ b);
           }
       }
       int machineAI;//判断机器所属的颜色 -1为黑色 1为红色
       /// <summary>
       /// “/”
       /// </summary>
       /// <param name="limit">限制棋子码数</param>
       /// <param name="machineAI">暂且默认为机器数</param>
       /// <param name="counts">连子个数</param>
       /// <param name="i">坐标</param>
      /// <param name="j"></param>
       /// <returns></returns>
     public  bool left_cline(int limit,int machineAI,int counts,int i,int j)
       {
           if ((i <ChessRules.rank && j<ChessRules.column&&(j>=0 &&i>=0))&&ChessRules.chess_map[i,j]==machineAI)
           {
               int temp = 0;
            
                   for (int k = i; k < i + counts; k++)
                   {
                       if (j>=0&&k<ChessRules.rank&&ChessRules.chess_map[k, j--] == machineAI)
                           temp++;
                   }
               
                j = j + counts;
                isEdge = (((i + counts)>=ChessRules.rank || (j + 1) == ChessRules.column || i == 0 ||j == 0||j<=counts));
                if (!isEdge)
                {
                    bean_judgeValueUp = ChessRules.chess_map[i - 1, j + 1];
                    bean_judge_ValueDown = ChessRules.chess_map[i + counts, j - counts];
                    if (limit == 0)
                        judge = judge_0(bean_judgeValueUp == Math.Abs(limit),
                            bean_judge_ValueDown == Math.Abs(limit), limit);
                    else
                    {
                     
                        judge = judge_0(bean_judgeValueUp == limit && bean_judge_ValueDown != -limit,
                        bean_judge_ValueDown == limit && bean_judgeValueUp != -limit, limit);
                    }
                }
                else
                {
                    if (limit != 0 && temp > 1)
                    {
                        //判断边界点的冲值
                        if (i + counts <ChessRules.rank && j - counts >= 0)
                          if( ChessRules.chess_map[i + counts, j - counts] != 0)
                            return false;
                        if (i >=1&&j+1<ChessRules.column)
                            if (ChessRules.chess_map[i-1, j +1] != 0)
                                return false;
                        if ((j < counts) && (i <ChessRules.rank- counts)|| ((i >= ChessRules.rank - counts) && j >= (ChessRules.column - counts)))
                            return false;
                        judge = true;
                    }
                    else
                    {
                      
                        judge = false;
                    }
                }
                if (temp == counts&&judge)
                {
                   
                    return true;
                }
                else
                    return false;
               }
           
             return false;
       }

     /// <summary>
     /// “\”
     /// </summary>
     /// <param name="limit">限制棋子码数</param>
     /// <param name="machineAI">暂且默认为机器数</param>
     /// <param name="counts">连子个数</param>
     /// <param name="i">坐标</param>
     /// <param name="j"></param>
     /// <returns></returns>
     public bool right_cline(int limit, int machineAI, int counts, int i, int j)
     {
         if ((i <ChessRules.rank && j  < ChessRules.column && (i >=0&&j>=0)
             ) && ChessRules.chess_map[i, j] == machineAI)
         {
             int temp = 0;
             for (int k = i; k < i + counts; k++)
             {
                 if (j<ChessRules.column && k < ChessRules.rank && ChessRules.chess_map[k, j++] == machineAI)
                     temp++;
             }
             j = j - counts; 
             isEdge = ((i + counts)>= ChessRules.rank || (j + counts)>= ChessRules.column||i==0||j==0);
          
             if (!isEdge)
             {
                 bean_judgeValueUp = ChessRules.chess_map[i - 1, j - 1];
                 bean_judge_ValueDown = ChessRules.chess_map[i + counts, j + counts];
                 if (limit == 0)
                     judge = judge_0(bean_judgeValueUp == Math.Abs(limit),
                         bean_judge_ValueDown == Math.Abs(limit), limit);
                 else
                     judge = judge_0(bean_judgeValueUp == limit && bean_judge_ValueDown != -limit,
                  bean_judge_ValueDown == limit && bean_judgeValueUp != -limit, limit);
             }
                
             else
             {
                 if (limit != 0 && temp > 1)
                 {
                     //判断边界点的冲值
                     if (i + counts < ChessRules.rank && j +counts<ChessRules.column)
                         if (ChessRules.chess_map[i + counts, j+counts] != 0)
                             return false;
                     if (i >= 1 && j >=1)
                         if (ChessRules.chess_map[i - 1, j - 1] != 0)
                             return false;
                     if ((j >= (ChessRules.column - counts)) && (i < ChessRules.rank - counts) || ((i >= ChessRules.rank - counts) && j < counts))
                         return false;
                     judge = true;
                 }
                 else
                     judge = false;
             }
             if (temp == counts && judge)
             {
                 return true;
             }
             else
                 return false;
         }

         return false;
     }
     /// <summary>
     /// “|”
     /// </summary>
     /// <param name="limit">限制棋子码数</param>
     /// <param name="machineAI">暂且默认为机器数</param>
     /// <param name="counts">连子个数</param>
     /// <param name="i">坐标</param>
     /// <param name="j"></param>
     /// <returns></returns>
     public bool endway_cline(int limit, int machineAI, int counts, int i, int j)
     {
         if ((i<ChessRules.rank && j <ChessRules.column && (j >= 0 && i>= 0)
             ) && ChessRules.chess_map[i, j] == machineAI)
         {
             int temp = 0;
             for (int k = i; k < i + counts; k++)
             {
                 if (k<ChessRules.rank&& ChessRules.chess_map[k, j] == machineAI)
                     temp++;
             }

             isEdge = (i == 0 || j == 0 || j+1 == ChessRules.column || i + counts >= ChessRules.rank);
         
             if (!isEdge)
             {
                 bean_judgeValueUp = ChessRules.chess_map[i - 1, j];
                 bean_judge_ValueDown = ChessRules.chess_map[i + counts, j];
                 if (limit == 0)
                     judge = judge_0(bean_judgeValueUp == Math.Abs(limit),
                         bean_judge_ValueDown == Math.Abs(limit), limit);
                 else
                     judge = judge_0(bean_judgeValueUp == limit && bean_judge_ValueDown != -limit,
                  bean_judge_ValueDown == limit && bean_judgeValueUp != -limit, limit);
             }
             else
             {
                 if (limit != 0 && temp > 1)
                 {
                     //判断边界点的冲值
                     if (i>=1)
                         if (ChessRules.chess_map[i-1, j] != 0)
                             return false;
                     if (i+counts<ChessRules.rank)
                         if (ChessRules.chess_map[i +counts, j] != 0)
                             return false;
                     judge = true;
                 }
                 else
                     judge = false;
             }
             if (temp == counts && judge)
             {
                 return true;
             }
             else
                 return false;
         }

         return false;
     }
     /// <summary>
     /// “—”
     /// </summary>
     /// <param name="limit">限制棋子码数</param>
     /// <param name="machineAI">暂且默认为机器数</param>
     /// <param name="counts">连子个数</param>
     /// <param name="i">坐标</param>
     /// <param name="j"></param>
     /// <returns></returns>
     public bool sideway_cline(int limit, int machineAI, int counts, int i, int j)
     {
         if ((i <ChessRules.rank && j <ChessRules.column && (i>= 0 && j >=0)
             ) && ChessRules.chess_map[i, j] == machineAI)
         {
             int temp = 0;
             for (int k = j; k < j + counts; k++)
             {
                 if (k<ChessRules.column&&ChessRules.chess_map[i, k] == machineAI)
                     temp++;
             }
             isEdge = (i == 0 || j == 0 || j + counts>=ChessRules.column || i + 1 == ChessRules.rank);
            
             if (!isEdge)
             {
                 bean_judgeValueUp = ChessRules.chess_map[i, j - 1];
                 bean_judge_ValueDown = ChessRules.chess_map[i, j + counts];
                 if (limit == 0)
                     judge = judge_0(bean_judgeValueUp == Math.Abs(limit),
                         bean_judge_ValueDown == Math.Abs(limit), limit);
                 else
                     judge = judge_0(bean_judgeValueUp == limit && bean_judge_ValueDown != -limit,
                  bean_judge_ValueDown == limit && bean_judgeValueUp != -limit, limit);
             }
             else
             {
                 if (limit != 0&&temp>1)
                 {
                     //判断边界点的冲值
                     if (j- 1 > 0)
                         if (ChessRules.chess_map[i, j-1] != 0)
                             return false;
                     if (j+ counts < ChessRules.column)
                         if (ChessRules.chess_map[i, j + counts] != 0)
                             return false;
                     judge = true;
                 }
                 else
                     judge = false;
             }

             if (temp == counts && judge)
             {
                 return true;
             }
             else
                 return false;
         }
         return false;
     }
     public bool Judge(int limit, int machineAI, int counts, int i, int j)
     {
         if (sideway_cline(limit, machineAI, counts, i, j) ||
             endway_cline(limit, machineAI, counts, i, j) ||
             right_cline(limit, machineAI, counts, i, j) ||
             left_cline(limit, machineAI, counts, i, j))
             return true;
         else
             return false;

     }
    }
}

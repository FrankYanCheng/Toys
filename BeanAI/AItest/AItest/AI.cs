////1.棋子落至最边上的棋子五个范围之内
////2.采用递归方式，判断有利位置，并附上分值
////3.棋谱变为树的分支
////4.取分值最高的
////要求可以选择递归次数
//采用九种判别积分方式
//1.先考虑自己落子时所得的积分，选择自身积分增加最多的方式。并考虑对方下的位置，判别对方的位置，选择自身减分最少的方式。
//以上如果存在多个相同分数的，则随机选择。将分数低的抛弃。




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AItest
{
    /// <summary>luo
    /// AI测试
    /// </summary>
    public class AI
    {
        int machine_score = -100000;//机器分数
        int man_score = -1000000;
        int temp_man_score;//人类分数
        AICaculate caculate;
        int target_i, target_j;//判断的坐标
        ChessRules rules;
        //int limit;
        int machine_score_temp;//分数暂存变量，用于比较
        public int i_temp, j_temp; int temp_keys;
        int man_temp_i, man_temp_j, man_keys;
        score_struct counts;
        score_struct man_counts;
        public int first_i, last_i, first_j, last_j;
        static int temp_x_min = ChessRules.rank, temp_y_min = ChessRules.column, temp_x_max = -1, temp_y_max = -1;
        public AI()
        {
            caculate = new AICaculate();
            rules = new ChessRules(5);

        }
        /// <summary>
        /// 缩小落子范围函数
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        int validateMin(int values)
        {
            if (values >= 1)
                return values - 1;
            else
                return 0;
        }
        int validateMax(int values, bool isRank)
        {
            if (isRank == true)
            {
                if (values + 1 < ChessRules.rank)
                    return values + 1;
                else
                    return values;
            }
            else
            {
                if (values + 1 < ChessRules.column)
                    return values + 1;
                else
                    return values;
            }


        }
        public void limit_coordinate(int i, int j)
        {

            if (temp_x_min > i)
                temp_x_min = i;
            if (temp_x_max < i)
                temp_x_max = i;
            if (temp_y_min > j)
                temp_y_min = j;
            if (temp_y_max < j)
                temp_y_max = j;
            first_i = validateMin(temp_x_min); first_j = validateMin(temp_y_min);
            last_i = validateMax(temp_x_max, true); last_j = validateMax(temp_y_max, false);
        }
        public void AI_coordinate(ref MapsNode node)
        {
            MapsNode pre_node = node.PreNode;
            if (node.PreNode != null)
            {
                if (pre_node.First_i > node.I)
                    node.First_i = pre_node.First_i;
                if (pre_node.Last_i < node.I)
                    node.Last_i = pre_node.Last_i;
                if (pre_node.First_j > node.J)
                    node.First_j = pre_node.First_i;
                if (pre_node.Last_j < node.J)
                    node.Last_j = pre_node.Last_j;
            }
            else
            {
                node.First_i = node.I;
                node.Last_i = node.I;
                node.First_j = node.J;
                node.Last_j = node.J;
            }
            first_i = validateMin(node.First_i); first_j = validateMin(node.First_j);
            last_i = validateMax(node.Last_i, true); last_j = validateMax(node.Last_j, false);
        }
       //void limit_coordinate()
     //   {
     //       temp_x_min = ChessRules.rank; temp_y_min = ChessRules.column; temp_x_max = -1; temp_y_max = -1;
     //       for (int i = 0; i < ChessRules.rank; i++)
     //       {
     //           for (int j = 0; j < ChessRules.column; j++)
     //               if (ChessRules.chess_map[i, j] != 0)
     //               {
     //                   if (temp_x_min > i)
     //                       temp_x_min = i;
     //                   if (temp_x_max < i)
     //                       temp_x_max = i;
     //                   if (temp_y_min > j)
     //                       temp_y_min = j;
     //                   if (temp_y_max < j)
     //                       temp_y_max = j;
     //               }
     //       }
     //       first_i = validateMin(temp_x_min); first_j = validateMin(temp_y_min);
     //       last_i = validateMax(temp_x_max, true); last_j = validateMax(temp_y_max, false);
     //   }

        public void JudgeCounts(int limit)
        {
            machine_score = -100000;//机器分数
            man_score = -1000000;
            //暂且默认后手是ai
            if (ChessRules.first_number == 0)
            {
                limit = 1;
            }
            else
                limit = -1;

            for (int k = 0; k < ChessRules.liLeft.Count; k++)
            {

                target_i = (ChessRules.liLeft[k]) / ChessRules.column;
                target_j = (ChessRules.liLeft[k]) % ChessRules.column;
                //limit_coordinate(target_i,target_j);
                if ((target_i > last_i && target_j > last_j))
                    break;

                if (target_i >= first_i && target_j >= first_j)
                {

                    for (int i = first_i - 1; i <= last_i; i++)
                        for (int j = first_j - 1; j <= last_j; j++)
                        {

                            counts = new score_struct();
                            man_counts = new score_struct();
                            {
                                machine_score_temp = 0;
                                temp_man_score = 0;

                                ChessRules.chess_map[target_i, target_j] = -limit;

                                #region 机器得分
                                //冲一
                                if (caculate.Judge(limit, -limit,1, i, j))
                                {
                                    counts.con_11++;
                                }
                                //冲二
                                if (caculate.Judge(limit, -limit, 2, i, j))
                                {
                                    counts.con_12++;
                                }

                                //冲三
                                if (caculate.Judge(limit, -limit, 3, i, j))
                                {
                                    counts.con_13++;
                                }
                                //冲四
                                if (caculate.Judge(limit, -limit, 4, i, j))
                                {
                                    counts.con_14++;
                                }

                                //活一
                                if (caculate.Judge(0, -limit, 1, i, j))
                                {
                                    counts.con_01++;
                                }
                                //活二
                                if (caculate.Judge(0, -limit, 2, i, j))
                                {
                                    counts.con_02++;
                                }

                                //活三
                                if (caculate.Judge(0, -limit, 3, i, j))
                                {
                                    counts.con_03++;
                                }
                                //活四
                                if (caculate.Judge(0, -limit, 4, i, j))
                                {
                                    counts.con_04++;
                                }
                                //得到

                                if (rules.Is_Win(ChessRules.first_number))
                                    counts.con_05++;

                                if (counts.con_11 > 0)
                                    machine_score_temp = 1;
                                if (counts.con_12 > 0)
                                    machine_score_temp = 3;
                                if (counts.con_02 == 1)
                                    machine_score_temp = 5;
                                if (counts.con_02 == 2)
                                    machine_score_temp = 10;
                                if (counts.con_03 == 1)
                                    machine_score_temp = 20;
                                if (counts.con_14 == 1)
                                    machine_score_temp = 50;
                                if (counts.con_13 > 0 && counts.con_03 > 0)
                                    machine_score_temp = 100;
                                if (counts.con_03 > 1)
                                    machine_score_temp = 500;
                                if (counts.con_14 >= 2)
                                    machine_score_temp = 1000;
                                if (counts.con_14 >= 1 && counts.con_03 >= 1)
                                    machine_score_temp = 2000;
                                if (counts.con_04 > 0)
                                    machine_score_temp = 3000;
                                if (counts.con_05 > 0 || counts.con_15 > 0)
                                    machine_score_temp = 10000;

                                #endregion
                                ChessRules.chess_map[target_i, target_j] = limit;
                                #region 模拟人走得分

                                //冲一
                                if (caculate.Judge(-limit, limit, 1, i, j))
                                {
                                    man_counts.con_11++;
                                }
                                //冲二
                                if (caculate.Judge(-limit, limit, 2, i, j))
                                {
                                    man_counts.con_12++;
                                }

                                //冲三
                                if (caculate.Judge(-limit, limit, 3, i, j))
                                {
                                    man_counts.con_13++;
                                }
                                //冲四
                                if (caculate.Judge(-limit, limit, 4, i, j))
                                {
                                    man_counts.con_14++;
                                }

                                //活一
                                if (caculate.Judge(0, limit, 1, i, j))
                                {
                                    man_counts.con_01++;
                                }
                                //活二
                                if (caculate.Judge(0, limit, 2, i, j))
                                {
                                    man_counts.con_02++;
                                }

                                //活三
                                if (caculate.Judge(0, limit, 3, i, j))
                                {
                                    man_counts.con_03++;
                                }
                                //活四
                                if (caculate.Judge(0, limit, 4, i, j))
                                {
                                    man_counts.con_04++;
                                }
                                //得到
                                if (rules.Is_Win(ChessRules.first_number + 1))
                                    man_counts.con_05++;

                                if (man_counts.con_11 > 0)
                                    temp_man_score = 1;
                                if (man_counts.con_12 > 0)
                                    temp_man_score = 3;
                                if (man_counts.con_02 == 1)
                                    temp_man_score = 5;
                                if (man_counts.con_02 == 2)
                                    temp_man_score = 10;
                                if (man_counts.con_03 == 1)
                                    temp_man_score = 20;
                                if (man_counts.con_14 == 1)
                                    temp_man_score = 50;
                                if (man_counts.con_13 > 0 && man_counts.con_03 > 0)
                                    temp_man_score = 100;
                                if (man_counts.con_03 > 1)
                                    temp_man_score = 500;
                                if (man_counts.con_14 >= 2)
                                    temp_man_score = 1000;
                                if (man_counts.con_14 == 1 && man_counts.con_03 == 1)
                                    temp_man_score = 2000;
                                if (man_counts.con_04 > 0)
                                    temp_man_score = 3000;
                                if (man_counts.con_05 > 0 || man_counts.con_15 > 0)
                                    temp_man_score = 10000;

                                #endregion
                                ChessRules.chess_map[target_i, target_j] = 0;
                                if (machine_score < machine_score_temp)
                                {
                                    machine_score = machine_score_temp;
                                    i_temp = target_i;
                                    j_temp = target_j;
                                    temp_keys = k;
                                }
                                if (man_score < temp_man_score)
                                {
                                    man_score = temp_man_score;
                                    man_temp_i = target_i;
                                    man_temp_j = target_j;
                                    man_keys = k;
                                }

                            }


                        }
                }
            }
            if (man_score > machine_score)
            {
                i_temp = man_temp_i;
                temp_keys = man_keys;
                j_temp = man_temp_j;
            }
            ChessRules.liLeft.RemoveAt(temp_keys);
        }


        //public void ab_JudgeCounts(int limit,int n,MapsNode node)
        //{
        //    //暂且默认后手是ai
        //    if (ChessRules.first_number == 0)
        //    {
        //        limit = 1;
        //    }
        //    else
        //        limit = -1;
        //    limit_coordinate();
        //    for (int k = 0; k <node.Li_map.Count; k++)
        //    {

        //        target_i = (node.Li_map[k]) / ChessRules.column;
        //        target_j = (node.Li_map[k]) % ChessRules.column;
        //        if ((target_i > last_i && target_j > last_j))
        //            break;

        //        if (target_i >= first_i && target_j >= first_j)
        //        {

        //            for (int i = first_i - 1; i <= last_i; i++)
        //                for (int j = first_j - 1; j <= last_j; j++)
        //                {

        //                    counts = new score_struct();
        //                    man_counts = new score_struct();
        //                    {
        //                        machine_score_temp = 0;
        //                        temp_man_score = 0;

        //                        ChessRules.chess_map[target_i, target_j] = -limit;

        //                        #region 机器得分
        //                        //冲一
        //                        if (caculate.Judge(limit, -limit, 1, i, j))
        //                        {
        //                            counts.con_11++;
        //                        }
        //                        //冲二
        //                        if (caculate.Judge(limit, -limit, 2, i, j))
        //                        {
        //                            counts.con_12++;
        //                        }

        //                        //冲三
        //                        if (caculate.Judge(limit, -limit, 3, i, j))
        //                        {
        //                            counts.con_13++;
        //                        }
        //                        //冲四
        //                        if (caculate.Judge(limit, -limit, 4, i, j))
        //                        {
        //                            counts.con_14++;
        //                        }

        //                        //活一
        //                        if (caculate.Judge(0, -limit, 1, i, j))
        //                        {
        //                            counts.con_01++;
        //                        }
        //                        //活二
        //                        if (caculate.Judge(0, -limit, 2, i, j))
        //                        {
        //                            counts.con_02++;
        //                        }

        //                        //活三
        //                        if (caculate.Judge(0, -limit, 3, i, j))
        //                        {
        //                            counts.con_03++;
        //                        }
        //                        //活四
        //                        if (caculate.Judge(0, -limit, 4, i, j))
        //                        {
        //                            counts.con_04++;
        //                        }
        //                        //得到

        //                        if (rules.Is_Win(ChessRules.first_number))
        //                            counts.con_05++;

        //                        if (counts.con_11 > 0)
        //                            machine_score_temp = 1;
        //                        if (counts.con_12 > 0)
        //                            machine_score_temp = 3;
        //                        if (counts.con_02 == 1)
        //                            machine_score_temp = 5;
        //                        if (counts.con_02 == 2)
        //                            machine_score_temp = 10;
        //                        if (counts.con_03 == 1)
        //                            machine_score_temp = 20;
        //                        if (counts.con_14 == 1)
        //                            machine_score_temp = 50;
        //                        if (counts.con_13 > 0 && counts.con_03 > 0)
        //                            machine_score_temp = 100;
        //                        if (counts.con_03 > 1)
        //                            machine_score_temp = 500;
        //                        if (counts.con_14 >= 2)
        //                            machine_score_temp = 1000;
        //                        if (counts.con_14 >= 1 && counts.con_03 >= 1)
        //                            machine_score_temp = 2000;
        //                        if (counts.con_04 > 0)
        //                            machine_score_temp = 3000;
        //                        if (counts.con_05 > 0 || counts.con_15 > 0)
        //                            machine_score_temp = 10000;

        //                        #endregion
        //                      node.Chess_map[target_i, target_j] = limit;
        //                        #region 模拟人走得分

        //                        //冲一
        //                        if (caculate.Judge(-limit, limit, 1, i, j))
        //                        {
        //                            man_counts.con_11++;
        //                        }
        //                        //冲二
        //                        if (caculate.Judge(-limit, limit, 2, i, j))
        //                        {
        //                            man_counts.con_12++;
        //                        }

        //                        //冲三
        //                        if (caculate.Judge(-limit, limit, 3, i, j))
        //                        {
        //                            man_counts.con_13++;
        //                        }
        //                        //冲四
        //                        if (caculate.Judge(-limit, limit, 4, i, j))
        //                        {
        //                            man_counts.con_14++;
        //                        }

        //                        //活一
        //                        if (caculate.Judge(0, limit, 1, i, j))
        //                        {
        //                            man_counts.con_01++;
        //                        }
        //                        //活二
        //                        if (caculate.Judge(0, limit, 2, i, j))
        //                        {
        //                            man_counts.con_02++;
        //                        }

        //                        //活三
        //                        if (caculate.Judge(0, limit, 3, i, j))
        //                        {
        //                            man_counts.con_03++;
        //                        }
        //                        //活四
        //                        if (caculate.Judge(0, limit, 4, i, j))
        //                        {
        //                            man_counts.con_04++;
        //                        }
        //                        //得到
        //                        if (rules.Is_Win(ChessRules.first_number + 1))
        //                            man_counts.con_05++;

        //                        if (man_counts.con_11 > 0)
        //                            temp_man_score = 1;
        //                        if (man_counts.con_12 > 0)
        //                            temp_man_score = 3;
        //                        if (man_counts.con_02 == 1)
        //                            temp_man_score = 5;
        //                        if (man_counts.con_02 == 2)
        //                            temp_man_score = 10;
        //                        if (man_counts.con_03 == 1)
        //                            temp_man_score = 20;
        //                        if (man_counts.con_14 == 1)
        //                            temp_man_score = 50;
        //                        if (man_counts.con_13 > 0 && man_counts.con_03 > 0)
        //                            temp_man_score = 100;
        //                        if (man_counts.con_03 > 1)
        //                            temp_man_score = 500;
        //                        if (man_counts.con_14 >= 2)
        //                            temp_man_score = 1000;
        //                        if (man_counts.con_14 == 1 && man_counts.con_03 == 1)
        //                            temp_man_score = 2000;
        //                        if (man_counts.con_04 > 0)
        //                            temp_man_score = 3000;
        //                        if (man_counts.con_05 > 0 || man_counts.con_15 > 0)
        //                            temp_man_score = 10000;

        //                        #endregion
        //                        ChessRules.chess_map[target_i, target_j] = 0;
        //                        if (machine_score < machine_score_temp)
        //                        {
        //                            machine_score = machine_score_temp;
        //                            i_temp = target_i;
        //                            j_temp = target_j;
        //                            temp_keys = k;
        //                        }
        //                        if (man_score < temp_man_score)
        //                        {
        //                            man_score = temp_man_score;
        //                            man_temp_i = target_i;
        //                            man_temp_j = target_j;
        //                            man_keys = k;
        //                        }

        //                    }


        //                }
        //        }
        //    }
        //    if (man_score > machine_score)
        //    {
        //        i_temp = man_temp_i;
        //        temp_keys = man_keys;
        //        j_temp = man_temp_j;
        //    }
        //    ChessRules.liLeft.RemoveAt(temp_keys);
        //}

        public void AI_Judge(ref MapsNode node, int limit, int times)
        {
            //递归次数
            if (times > 0)
            {
                node.First_i = ChessRules.rank;
                node.First_j= ChessRules.column;
                node.Last_i = -1;
                node.Last_j = -1;
                //先假设为红色先手，ai为黑色 
                machine_score = -100000;//机器分数
                man_score = -1000000;
                node.LiLeft = new List<int>();
                for (int k = 0; k < node.LiLeft.Count; k++)
                {

                    target_i = (node.LiLeft[k]) / ChessRules.column;
                    target_j = (node.LiLeft[k]) % ChessRules.column;
                    node.I = target_i;
                    node.J = target_j;
                    AI_coordinate(ref node);
                    if ((target_i > last_i && target_j > last_j))
                        break;
                    if (target_i >= first_i && target_j >= first_j)
                    {
                        for (int i = first_i - 1; i <= last_i; i++)
                            for (int j = first_j - 1; j <= last_j; j++)
                            {

                                counts = new score_struct();
                                man_counts = new score_struct();
                                {
                                    machine_score_temp = 0;
                                    temp_man_score = 0;
                                    node.Chess_map[target_i, target_j] = -limit;
                                    #region 机器得分
                                    //冲一
                                    if (caculate.Judge(limit, -limit, 1, i, j))
                                    {
                                        counts.con_11++;
                                    }
                                    //冲二
                                    if (caculate.Judge(limit, -limit, 2, i, j))
                                    {
                                        counts.con_12++;
                                    }

                                    //冲三
                                    if (caculate.Judge(limit, -limit, 3, i, j))
                                    {
                                        counts.con_13++;
                                    }
                                    //冲四
                                    if (caculate.Judge(limit, -limit, 4, i, j))
                                    {
                                        counts.con_14++;
                                    }

                                    //活一
                                    if (caculate.Judge(0, -limit, 1, i, j))
                                    {
                                        counts.con_01++;
                                    }
                                    //活二
                                    if (caculate.Judge(0, -limit, 2, i, j))
                                    {
                                        counts.con_02++;
                                    }

                                    //活三
                                    if (caculate.Judge(0, -limit, 3, i, j))
                                    {
                                        counts.con_03++;

                                    }
                                    //活四
                                    if (caculate.Judge(0, -limit, 4, i, j))
                                    {
                                        counts.con_04++;
                                    }
                                    //得到

                                    if (rules.Is_Win(ChessRules.first_number))
                                        counts.con_05++;

                                    if (counts.con_11 > 0)
                                        machine_score_temp = 1;
                                    if (counts.con_12 > 0)
                                        machine_score_temp = 3;
                                    if (counts.con_02 == 1)
                                        machine_score_temp = 5;
                                    if (counts.con_02 == 2)
                                        machine_score_temp = 10;
                                    if (counts.con_03 == 1)
                                    {
                                        machine_score_temp = 20;

                                    }
                                    if (counts.con_14 == 1)
                                    {
                                        machine_score_temp = 50;

                                    }
                                    if (counts.con_13 > 0 && counts.con_03 > 0)
                                    {
                                        machine_score_temp = 100;

                                    }
                                    if (counts.con_03 > 1)
                                    {
                                        machine_score_temp = 500;
                                        MapsNode child_node = new MapsNode();
                                        child_node.Chess_map = node.Chess_map;
                                        child_node.I = i;
                                        child_node.J = j;
                                        child_node.PreNode = node;
                                        node.NextNode.Add(child_node);
                                        child_node.LiLeft = node.LiLeft;
                                        child_node.Score = 500;
                                        child_node.LiLeft.Remove(i * ChessRules.column + j);
                                        machine_score_temp = 500;
                                        AI_Judge(ref child_node, -limit, times - 1);

                                    }
                                    if (counts.con_14 >= 2)
                                    {
                                        MapsNode child_node = new MapsNode();
                                        child_node.Chess_map = node.Chess_map;
                                        child_node.I = i;
                                        child_node.J = j;
                                        child_node.PreNode = node;
                                        node.NextNode.Add(child_node);
                                        child_node.LiLeft = node.LiLeft;
                                        child_node.Score = 1000;
                                        child_node.LiLeft.Remove(i * ChessRules.column + j);
                                        machine_score_temp = 1000;
                                        AI_Judge(ref child_node, -limit, times - 1);
                                    }
                                    if (counts.con_14 >= 1 && counts.con_03 >= 1)
                                    {
                                        MapsNode child_node = new MapsNode();
                                        child_node.Chess_map = node.Chess_map;
                                        child_node.I = i;
                                        child_node.J = j;
                                        child_node.PreNode = node;
                                        node.NextNode.Add(child_node);
                                        child_node.LiLeft = node.LiLeft;
                                        child_node.Score = 2000;
                                        child_node.LiLeft.Remove(i * ChessRules.column + j);
                                        machine_score_temp = 2000;
                                        AI_Judge(ref child_node, -limit, times - 1);
                                    }
                                    if (counts.con_04 > 0)
                                    {
                                        machine_score_temp = 3000;
                                        MapsNode child_node = new MapsNode();
                                        child_node.Chess_map = node.Chess_map;
                                        child_node.I = i;
                                        child_node.J = j;
                                        child_node.PreNode = node;
                                        node.NextNode.Add(child_node);
                                        child_node.LiLeft = node.LiLeft;
                                        child_node.Score = 3000;
                                        child_node.LiLeft.Remove(i * ChessRules.column + j);
                                        AI_Judge(ref child_node, -limit, times - 1);
                                    }
                                    if (counts.con_05 > 0 || counts.con_15 > 0)
                                    {
                                        machine_score_temp = 10000;
                                        MapsNode child_node = new MapsNode();
                                        child_node.Chess_map = node.Chess_map;
                                        child_node.I = i;
                                        child_node.J = j;
                                        child_node.PreNode = node;
                                        node.NextNode.Add(child_node);
                                        child_node.LiLeft = node.LiLeft;
                                        child_node.Score = 10000;
                                        child_node.LiLeft.Remove(i * ChessRules.column + j);
                                        AI_Judge(ref child_node, -limit, times - 1);
                                    }

                                    #endregion


                                }
                            }
                    }
                }


            }
        }
        
    }
}

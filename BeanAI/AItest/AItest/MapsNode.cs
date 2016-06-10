//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AItest
{
    /// <summary>
    /// 记录节点类
    /// </summary>
   public class MapsNode
    {
        
        MapsNode preNode;

       /// <summary>
       /// 前驱节点
       /// </summary>
        public MapsNode PreNode
        {
            get { return preNode; }
            set { preNode = value; }
        }
        List<MapsNode> nextNode;
       /// <summary>
       /// 后继节点链表
       /// </summary>
        public List<MapsNode> NextNode
        {
            get { return nextNode; }
            set { nextNode = value; }
        }
        int i;
        int j;

        public int J
        {
            get { return j; }
            set { j = value; }
        }
        int score;
       /// <summary>
       /// 目前阶段所处的分数
       /// </summary>
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public int I
        {
            get { return i; }
            set { i = value; }
        }
     
        int[,] chess_map;
        
       /// <summary>
       /// 棋谱
       /// </summary>
        public int[,] Chess_map
        {
            get { return chess_map; }
            set { chess_map = value; }
        }
        int first_i;
        List<int> liLeft;
       /// <summary>
       /// 剩余棋子数
       /// </summary>
        public List<int> LiLeft
        {
            get { return liLeft; }
            set { liLeft = value; }
        }
        public int First_i
        {
            get { return first_i; }
            set { first_i = value; }
        }
        int first_j;

        public int First_j
        {
            get { return first_j; }
            set { first_j = value; }
        }
        int last_i;

        public int Last_i
        {
            get { return last_i; }
            set { last_i = value; }
        }
        int last_j;

        public int Last_j
        {
            get { return last_j; }
            set { last_j = value; }
        }

    }
}

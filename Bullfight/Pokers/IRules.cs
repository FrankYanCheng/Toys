using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokers
{
    /// <summary>
    /// 牌规则接口类
    /// </summary>
   public interface IRules
    {
     /// <summary>
     /// 初始化牌规则类
     /// </summary>
     /// <param name="Packs">牌副数</param>

     /// <param name="name">牌名集合</param>
     /// <returns></returns>
       bool SetRules(int Packs,Card_Name name);
       /// <summary>
       /// 数值至牌名称的转换
       /// </summary>
       /// <param name="value"></param>
       /// <returns></returns>
       string IntToPokers(int value);
       /// <summary>
       /// 牌排序(升序）
       /// </summary>
       /// <param name="cards">牌数组</param>
       /// <returns></returns>
     List<int> AscendSort(List<int> cards);
       /// <summary>
       /// 牌排序（降序）
       /// </summary>
       /// <param name="cards">牌数组</param>
       /// <returns></returns>
     List<int> DescendSort(List<int> cards);
       /// <summary>
       /// 比较牌的大小，根据牌的值
       /// </summary>
       /// <param name="CompareValue"></param>
       /// <param name="OriginalValue"></param>
       /// <returns></returns>
        bool IsBiger(int CompareValue, int OriginalValue);
       /// <summary>
       /// 将牌转换为点数集合
       /// </summary>
       /// <returns>点数集合</returns>
      List<int> ToPoints(List<int> cards);
       /// <summary>
       /// 游戏结果
       /// </summary>
       /// <param name="cards"></param>
       /// <returns></returns>
      int PointResult(List<int> cards);
       
    }
}

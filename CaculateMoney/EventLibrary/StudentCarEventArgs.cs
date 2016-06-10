using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventLibrary
{
   public class StudentCarEventArgs:EventArgs
    {
       public double Start;//月初学生卡额度
       public double End;//月末学生卡额度
       public double Add;//补助金额
       public Dictionary<string, double> DirectIn = new Dictionary<string, double>();
        public StudentCarEventArgs(double Start, double End,double Add,Dictionary<string,double>DirectIn)
        {
            this.Start = Start;
            this.End = End;
            this.Add = Add;
            this.DirectIn = DirectIn;
        }
    }
}

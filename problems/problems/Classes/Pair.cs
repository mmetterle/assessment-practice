using System;
using System.Collections.Generic;
using System.Text;

namespace problems.Classes
{
    public class Pair
    {
        public int totalNodes { get; set; }
        public int totalSum { get; set; }
        public Pair(int total, int sum)
        {
            this.totalNodes = total;
            this.totalSum = sum;
        }
    }
}

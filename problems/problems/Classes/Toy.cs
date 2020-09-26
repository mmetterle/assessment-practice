using System;
using System.Collections.Generic;
using System.Text;

namespace problems.Classes
{
    public class Toy
    {
        public string name { get; set; }
        public int freq { get; set; }
        public int sentenceCnt { get; set; }

        public Toy(string name, int freq, int sentenceCnt)
        {
            this.name = name;
            this.freq = freq;
            this.sentenceCnt = sentenceCnt;
        }
    }
}

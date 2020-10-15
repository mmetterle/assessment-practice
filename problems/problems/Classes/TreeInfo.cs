using System;
using System.Collections.Generic;
using System.Text;

namespace problems.Classes
{
    public class TreeInfo
    {

        public int height { get; set; }
        public bool balanced { get; set; }

        public TreeInfo(int height, bool balanced)
        {
            this.height = height;
            this.balanced = balanced;
        }

    }
}

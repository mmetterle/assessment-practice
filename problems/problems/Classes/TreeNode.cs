using System;
using System.Collections.Generic;
using System.Text;

namespace problems.Classes
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode parent;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null, TreeNode parent = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
            this.parent = parent;
        }
    }
}

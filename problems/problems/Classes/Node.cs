using System;
using System.Collections.Generic;
using System.Text;

namespace problems.Classes
{
    public class Node
    {
        public int val { get; set; }
        public List<Node> children { get; set; }
        public Node() { }
        public Node(int _val) { val = _val; }
        public Node(int _val, List<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}

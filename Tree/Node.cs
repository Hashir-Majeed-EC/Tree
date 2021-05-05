using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Node
    {
        public Node left;
        public Node right;
        public int val;

        public Node(int val)
        {
            this.val = val;
            left = null;
            right = null;
        }

    }
}

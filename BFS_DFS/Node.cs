using System;
using System.Collections.Generic;
using System.Text;

namespace BFS_DFS
{
    public class Node
    {
        public Node left;
        public Node right;
        public string data;

        public Node(string data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public Node(string data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }

    }
}

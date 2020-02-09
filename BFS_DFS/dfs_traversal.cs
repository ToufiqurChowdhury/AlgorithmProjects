using System;
using System.Collections.Generic;
using System.Text;

namespace BFS_DFS
{
    partial class Program
    {
        static void dfs_traversal(Node node)
        {
            // Base case
            if(node == null)
                return;

            Console.Write(node.data + " ");

            // Recursive call
            dfs_traversal(node.left);

            //Console.Write(node.data + " ");
            
            dfs_traversal(node.right);

            // Console.Write(node.data + " ");
        }
    }
}

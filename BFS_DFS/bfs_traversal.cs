using System;
using System.Collections.Generic;
using System.Text;

namespace BFS_DFS
{
    partial class Program
    {
        static void bfs_traversal(Node node)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);

            while(q.Count > 0)
            {
                node = q.Dequeue();
                Console.Write(node.data + " ");

                if(node.left != null)
                {
                    q.Enqueue(node.left);
                }

                if(node.right != null)
                {
                    q.Enqueue(node.right);
                }
            }
        }




    }
}

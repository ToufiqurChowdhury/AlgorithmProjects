using System;

namespace BFS_DFS
{
    partial class Program
    {

        static Node sample_tree()
        {
            Node root =
                new Node("A",
                    new Node("B",
                        new Node("C"), new Node("D")),
                    new Node("E",
                        new Node("F"), new Node("G",
                                                new Node("H"), null)));

            return root;
        }

        static void Main(string[] args)
        {
            Node tree = sample_tree();

            Console.WriteLine("BFS --> ");
            bfs_traversal(tree);

            //Console.WriteLine("\nDFS --> ");
            //dfs_traversal(tree);

            Console.WriteLine();
        }
    }
}

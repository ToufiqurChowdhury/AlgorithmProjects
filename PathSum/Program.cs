using System;
using System.Collections.Generic;

namespace PathSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int[] nums = { 4, 5, 7, 1, 2 };

            Array.Sort(nums);

        }

        public bool hasPathSum(Node root, int sum)
        {
            if(root == null)
            {
                return false;
            }
            else if(root.left == null && root.right ==null && sum - root.val == 0)
            {
                return true;
            }
            else
            {
                return hasPathSum(root.left, sum - root.val) || hasPathSum(root.right, sum - root.val);
            }
        }
        public class Node
        {
            public Node left;
            public Node right;
            public int val;

            Node(int x) { val = x; }
        }

    }
}

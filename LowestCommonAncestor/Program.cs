using System;

namespace LowestCommonAncestor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lowest Common Ancestor (LCA)!");

            
        }

        public static TreeNode LCA(TreeNode root, TreeNode p, TreeNode q)
        {
            if(p.val < root.val && q.val < root.val)
            {
                LCA(root.left, p, q);
            }else if(p.val >= root.val && q.val >= root.val)
            {
                LCA(root.right, p, q);
            }
            else
            {
                return root;
            }

            return root;
        }

    }

    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;

        TreeNode(int x) { val = x; }
    }

}

}

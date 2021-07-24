using System;
using System.Collections.Generic;

namespace Binary_Tree_Inorder_Traversal
{
   public class TreeNode
   {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
      {
         this.val = val;
         this.left = left;
         this.right = right;
      }
   }


   class Program
   {
      List<int> list = new List<int>();

      public static IList<int> InorderTraversal(TreeNode root)
      {
         helper(root);
         return list;
      }

      static void helper(TreeNode root)
      {
         if (root == null)
         {
            return;
         }

         helper(root.left);
         list.Add(root.val);
         helper(root.right);
      }

      static void Main(string[] args)
      {
         var root = new TreeNode() { };

         InorderTraversal(root);
         Console.WriteLine();
      }
   }
}

using System;

namespace Symmetric_Tree
{
   class Program
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

      public static bool IsSymmetric(TreeNode root)
      {
         return IsMirror(root, root);
      }

      public static bool IsMirror(TreeNode node1, TreeNode node2)
      {
         if (node1 == null && node2 == null)
            return true;

         if (node1 != null && node2 != null && node1.val == node2.val)
            return (IsMirror(node1.left, node2.right) && IsMirror(node1.right, node2.left));

         return false;
      }

      static void Main(string[] args)
      {
         var root = new TreeNode() { val = 1, 
            left = new TreeNode() { val = 2, 
               left = new TreeNode() { val = 3, left = null, right = null }, 
               right = new TreeNode() { val = 4, left = null, right = null } }, 
            right = new TreeNode() { val = 2, 
               left = new TreeNode() { val = 4, left = null, right = null }, 
               right = new TreeNode() { val = 3, left = null, right = null } } };
         bool ans = IsSymmetric(root);

         Console.WriteLine(ans);
      }
   }
}

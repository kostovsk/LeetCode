using System;
using System.Collections;
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

      public IList<int> InorderTraversal(TreeNode root)
      {
         helper(root);
         return list;
      }

      void helper(TreeNode root)
      {
         if (root == null)
         {
            return;
         }

         helper(root.left);
         list.Add(root.val);
         helper(root.right);
      }

      public IList<int> InorderTraversalStack(TreeNode root)
      {
         if (root == null)
            return null;
         
         List<int> slist = new List<int>();
         Stack<TreeNode> bts = new Stack<TreeNode>();
         TreeNode curr = root;

         while (curr != null || bts.Count > 0 )
         {
            while (curr != null)
            {
               bts.Push(curr);
               curr = curr.left;
            }

            curr = bts.Pop();
            slist.Add(curr.val);

            curr = curr.right;
         }

         return slist;
      }

      static void Main(string[] args)
      {
         var root = new TreeNode() { val = 1, left = null, right = new TreeNode() { val = 2, left = new TreeNode() { val = 3, left = null, right = null }, right = null } };

         var trav = new Program();
         
         trav.InorderTraversal(root);

         foreach (var item in trav.list)
         {
            Console.WriteLine(item);
         }

         Console.WriteLine();

         var slist = trav.InorderTraversalStack(root);
         foreach(var item in slist)
         {
            Console.WriteLine(item);
         }
      }
   }
}

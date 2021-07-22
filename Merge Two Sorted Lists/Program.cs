using System;

namespace Merge_Two_Sorted_Lists
{
   class Program
   {
      public class ListNode
      {
         public int val;
         public ListNode next;
         public ListNode(int val = 0, ListNode next = null)
         {
            this.val = val;
            this.next = next;
         }
      }

      public ListNode MergeTwoLists(ListNode l1, ListNode l2)
      {
         if (l1 == null)
         {
            if (l2 == null)
            {
               return null;
            }
            else
            {
               return new ListNode(l2.val, MergeTwoLists(null, l2.next));
            }
         }
         else if (l2 == null)
         {
            return new ListNode(l1.val, MergeTwoLists(l1.next, null));
         }
         else if (l1.val < l2.val)
         {
            return new ListNode(l1.val, MergeTwoLists(l1.next, l2));
         }
         else
         {
            return new ListNode(l2.val, MergeTwoLists(l2.next, l1));
         }
      }

      static void Main(string[] args)
      {
         Console.WriteLine("Hello World!");
      }
   }
}

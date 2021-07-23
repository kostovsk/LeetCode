using System;

namespace Maximum_Subarray
{
   class Program
   {
      public static int maxSubArraySum(int[] a)
      {
         int max = int.MinValue;
         int max_end = 0;

         for (int i = 0; i < a.Length; i++)
         {
            max_end = max_end + a[i];

            if (max < max_end)
               max = max_end;

            if (max_end < 0)
               max_end = 0;
         }

         return max;
      }

      static void Main(string[] args)
      {
         int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
         Console.Write("Maximum contiguous sum is " +
                                 maxSubArraySum(a));
      }
   }
}

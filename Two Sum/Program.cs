using System;

namespace Two_Sum
{
   class Program
   {
      public static int[] TwoSum(int[] nums, int target)
      {
         int[] result = new int[2];

         for (int i = 0; i < nums.Length; i++)
         {
            for (int j = i + 1; j < nums.Length; j++)
            {
               if (nums[i] + nums[j] == target)
               {
                  result[0] = i;
                  result[1] = j;
                  break;
               }

            }
         }

         return result;
      }

      static void Main(string[] args)
      {
         int target = 6;
         int[] nums = new int[] { 2, 4, 3 };

         Console.WriteLine(TwoSum(nums, target));
      }
   }
}

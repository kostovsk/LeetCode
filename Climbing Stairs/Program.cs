using System;

namespace Climbing_Stairs
{
   class Program
   {

      public static int ClimbStairs(int n)
      {
         if (n <= 2)
            return n;

         int[] result = new int[n];

         result[0] = 1;
         result[1] = 2;

         for (int i = 2; i < n; i++)
            result[i] = result[i - 1] + result[i - 2];

         return result[n-1];
      }

      static void Main(string[] args)
      {
         int num = 44;
         Console.WriteLine(ClimbStairs(num));
      }
   }
}

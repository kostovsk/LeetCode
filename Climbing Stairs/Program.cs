using System;

namespace Climbing_Stairs
{
   class Program
   {
      public static int fib(int f)
      {
         if (f <= 1)
            return f;
         else
            return fib(f - 1) + fib(f - 2);
      }

      public static int ClimbStairs(int n)
      {
         int result = 0;

         if (n >= 1 && n <= 45)
            result = fib(n + 1);

         return result;
      }

      static void Main(string[] args)
      {
         int num = 5;
         Console.WriteLine(ClimbStairs(num));
      }
   }
}

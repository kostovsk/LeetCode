using System;

namespace Reverse_Integer
{
   class Program
   {
      public static int Reverse(int x)
      {
         bool check = false;
         long rev_x = 0;
         int result = 0;
         int max = Int32.MaxValue;
         int min = Int32.MinValue;

         if (x < 0)
         {
            x = x * -1;
            check = true;
         }

         while (x > 0)
         {
            rev_x = rev_x * 10 + x % 10;
            x = x / 10;
         }

         if (rev_x < max && rev_x > min)
            if (check)
            {
               result = (int)rev_x * -1;
            }
            else
            {
               result = (int)rev_x;
            }

         return result;
      }

      static void Main(string[] args)
      {
         int answer = Reverse(1534236469);

         Console.WriteLine(answer);
      }
   }
}

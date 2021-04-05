using System;
using System.Collections.Generic;

namespace Kids_With_the_Greatest_Number_of_Candies
{
   class Program
   {
      public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
      {
         List<bool> result = new List<bool>();
         int a = extraCandies;

         //find maxVal from array
         int max = candies[0];
         for (int k = 1; k < candies.Length; k++)
         {
            if (candies[k] > max)
            {
               max = candies[k];
            }
         }

         for (int i = 0; i < candies.Length; i++)
         {
            if (candies[i] + a >= max)
            {
               result.Add(true);
            }
            else
            {
               result.Add(false);
            }

         }
         return result;
      }
      static void Main(string[] args)
      {
         int[] numC = new int[] { 2, 3, 5, 1, 3 };
         var extC = 5;
         var result = KidsWithCandies(numC, extC);

         foreach (var item in result)
         {
            Console.WriteLine(item);
         }
      }
   }
}

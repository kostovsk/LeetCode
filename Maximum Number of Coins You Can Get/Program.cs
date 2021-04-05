using System;

namespace Maximum_Number_of_Coins_You_Can_Get
{
   class Program
   {
      public static int MaxCoins(int[] piles)
      {
         Array.Sort(piles);
         Array.Reverse(piles);

         int len = (piles.Length / 3) * 2;

         int sum = 0;

         for (int i = 1; i < len; i = i + 2)
         {
            sum = sum + piles[i];
         }
         return sum;
      }

      static void Main(string[] args)
      {
         int[] arr1 = new int[] { 2, 4, 1, 2, 7, 8 };
         int[] arr2 = new int[] { 2, 4, 5 };
         int[] arr3 = new int[] { 9, 8, 7, 6, 5, 1, 2, 3, 4 };

         int sum1 = MaxCoins(arr1);
         int sum2 = MaxCoins(arr2);
         int sum3 = MaxCoins(arr3);

         Console.WriteLine(sum1);
         Console.WriteLine(sum2);
         Console.WriteLine(sum3);
      }
   }
}

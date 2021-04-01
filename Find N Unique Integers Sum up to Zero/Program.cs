using System;

namespace Find_N_Unique_Integers_Sum_up_to_Zero
{
   class Program
   {
      public static int[] SumZero(int n)
      {
         Random a = new Random();
         int[] sumZero = new int[n];

         if (n == 1)
         {
            sumZero[n - 1] = 0;
            return sumZero;
         }

         if (n % 2 == 1)
         {
            sumZero[n - 1] = 0;
         }

         for (int i = 0; i < n - 1; i = i + 2)
         {
            int b = a.Next(Int32.MinValue, Int32.MaxValue);
            sumZero[i] = b;
            sumZero[i + 1] = (b * -1);

         }

         return sumZero;
      }
      static void Main(string[] args)
      {
         var result = SumZero(5);
         foreach (var item in result)
         {
            Console.WriteLine(item);
         }
      }
   }
}

using System;
using System.Collections.Generic;

namespace Lucky_Numbers_in_a_Matrix_v1._0
{
   class Program
   {
      public class Solution
      {
         public IList<int> LuckyNumbers(int[][] matrix)
         {
            List<int> myList = new List<int>();
            int maxInt = 0;
            int minInt = 0;
            int indexNumber = -1;

            for (int i = 0; i < matrix.Length; i++)
            {
               for (int j = 0; j < matrix[i].Length; j++)
               {
                  int value = matrix[i][j];
                  if (value > maxInt)
                  {
                     maxInt = value;
                     indexNumber = i;
                  }

               }
            }

            for (int k = 0; k < matrix[indexNumber].Length; k++)
            {
               minInt = matrix[indexNumber][0];
               if (minInt > matrix[indexNumber][k])
               {
                  minInt = matrix[indexNumber][k];
               }
            }

            myList.Add(minInt);

            return myList;
         }
      }

      static void Main(string[] args)
      {
         Console.WriteLine("Hello World!");
         int[][] matrix = new int[][]
         {
                new int[]{3,7,8},
                new int[]{9,11,13},
                new int[]{15,16,17}
         };

         Solution findNumber = new Solution();
         var result = findNumber.LuckyNumbers(matrix);
         Console.WriteLine(result);

      }
   }
}

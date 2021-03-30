using System;
using System.Collections.Generic;

namespace Lucky_Numbers_in_a_Matrix_v1._1
{
   class Program
   {
      public class Solution
      {
         public IList<int> LuckyNumbers(int[][] matrix)
         {

            List<int> result = new List<int>();

            for (int i = 0; i < matrix.Length; i++)
            {
               int minInRow = int.MaxValue;
               int column = 0;
               bool isLucky = true;

               for (int j = 0; j < matrix[i].Length; j++)
               {
                  if (matrix[i][j] < minInRow)
                  {
                     minInRow = matrix[i][j];
                     column = j;
                  }
               }

               for (int k = 0; k < matrix.Length; k++)
               {
                  if (matrix[k][column] > minInRow)
                  {
                     isLucky = false;
                     break;
                  }
               }

               if (isLucky)
               {
                  result.Add(minInRow);
               }
            }

            return result;
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

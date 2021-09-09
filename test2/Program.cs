using System;
using System.Linq;

namespace test2
{
   class Program
   {
      public static string[] FindCommon(string[] names1, string[] names2)
      {
         var combo = names1.Union(names2);
         
         string[] result = combo.Select(p => p).ToArray();

         return result;
      }

      public static int solution(int[] A)
      {
         // write your code in C# 6.0 with .NET 4.5 (Mono)
         int result = 0;
         int len = A.Length - 1;

         for (int i = 0; i < len; i++)
         {
            if (A[i] == A[i + 1])
               result++;
         }

         if (result == len)
            return result - 1;

         int max = 0;
         
         for (int j = 0; j < A.Length; j++)
         {
            int test = 0;
            if(j > 0)
            {
               if (A[j - 1] != A[j])
                  test++;
               else
                  test--;
            }
            if(j < len)
            {
               if (A[j] != A[j + 1])
                  test++;
               else
                  test--;
            }
            max = Math.Max(max, test);
         }

         return result;
      }

      public static int solution2(string S)
      {
         int result = 0;
         int len = S.Length - 1;

         for (int i = 2; i < len;)
         {
            if (S[i] == 'X' || S[i - 1] == 'X' || S[i - 2] == 'X')
            {
               result += 1;
            }
            if (i + 3 > len)
            {
               for (int j = len; j > i; j--)
               {
                  if (S[j] == 'X')
                  {
                     result += 1;
                  }
               }
            }
            i = i + 3;
         }

         return result;
      }

      public static void Main(string[] args)
      {
         //string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
         //string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };

         //Console.WriteLine(FindCommon(names1, names2)); // should print Ava, Emma, Olivia, Sophia

         int[] test1 = new int[] { 1, 1, 0, 1, 1 };
         Console.WriteLine(solution(test1));

         //string input = ".X..X";
         //Console.WriteLine(solution2(input));
      }
   }
}

using System;

namespace Valid_Parentheses
{
   class Program
   {
      public static bool IsValid(string s)
      {
         bool result = false;

         for (int i = s.Length - 1; i > 0; i = i - 2)
         {
            if (s[i].ToString() == ")")
            {
               if (s[i-1].ToString() == "(")
               {
                  s = s.Remove(i - 1, 2);
                  result = true;
               }
            }
            else if (s[i].ToString() == "}")
            {
               if (s[i-1].ToString() == "{")
               {
                  s = s.Remove(i - 1, 2);
                  result = true;
               }
            }
            else if (s[i].ToString() == "]")
            {
               if (s[i-1].ToString() == "[")
               {
                  s = s.Remove(i - 1, 2);
                  result = true;
               }
            }
         }

         return result;
      }

      static void Main(string[] args)
      {
         string s = "()[]{}";

         Console.WriteLine(IsValid(s));
      }
   }
}

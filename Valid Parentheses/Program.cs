using System;

namespace Valid_Parentheses
{
   class Program
   {
      public static bool IsValid(string s)
      {
         bool result = false;

         while(s.Length > 0)
         {
            foreach (char c in s)
            {
               if (c.Equals('('))
               {
                  if (s[s.IndexOf(c) + 1].Equals(')'))
                  {
                     s = s.Remove(s.IndexOf(c), 2);
                     result = true;
                  }
               }
               else if (c.Equals('['))
               {
                  if (s[s.IndexOf(c) + 1].Equals(']'))
                  {
                     s = s.Remove(s.IndexOf(c), 2);
                     result = true;
                  }
               }
               else if (c.Equals('{'))
               {
                  if (s[s.IndexOf(c) + 1].Equals('}'))
                  {
                     s = s.Remove(s.IndexOf(c), 2);
                     result = true;
                  }
               }
            }
         }

         //for (int i = s.Length - 1; i > 0; i--)
         //{
         //   if (s[i].ToString() == ")")
         //   {
         //      if (s[i-1].ToString() == "(")
         //      {
         //         s = s.Remove(i - 1, 2);
         //         i--;
         //         result = true;
         //      }
         //   }
         //   else if (s[i].ToString() == "}")
         //   {
         //      if (s[i-1].ToString() == "{")
         //      {
         //         s = s.Remove(i - 1, 2);
         //         i--;
         //         result = true;
         //      }
         //   }
         //   else if (s[i].ToString() == "]")
         //   {
         //      if (s[i-1].ToString() == "[")
         //      {
         //         s = s.Remove(i - 1, 2);
         //         i--;
         //         result = true;
         //      }
         //   }
         //}

         return result;
      }

      static void Main(string[] args)
      {
         string s = "{()[]}";

         Console.WriteLine(IsValid(s));
      }
   }
}

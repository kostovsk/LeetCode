using System;
using System.Collections.Generic;

namespace Valid_Parentheses
{
   class Program
   {
      public static bool IsValid(string s)
      {
         Stack<char> stack = new Stack<char>();

         for (int i = 0; i < s.Length; i++)
         {
            if (s[i].Equals('('))
            {
               stack.Push(')');
            }
            else if (s[i].Equals('{'))
            {
               stack.Push('}');
            }
            else if (s[i].Equals('['))
            {
               stack.Push(']');
            }

            if (s[i].Equals(')') || s[i].Equals('}') || s[i].Equals(']'))
            {
               if (stack.Count > 0 && s[i] == stack.Peek())
               {
                  stack.Pop();
               }
               else
               {
                  return false;
               }
            }
         }

         if (stack.Count > 0)
         {
            return false;
         }

         return true;
      }

      static void Main(string[] args)
      {
         string s = "[(){}]";

         Console.WriteLine(IsValid(s));
      }
   }
}

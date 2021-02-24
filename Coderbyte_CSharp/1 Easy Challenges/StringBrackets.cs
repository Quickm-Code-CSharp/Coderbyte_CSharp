using System.Collections.Generic;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class StringBrackets
    {
        // For this challenge you will determine how to create evenly matched brackets.

        // The function RemoveBrackets(str) take the str string parameter being passed, 
        // which will contain only the characters "(" and ")", and determine the minimum 
        // number of brackets that need to be removed to create a string of correctly 
        // matched brackets. 

        // For example: if str is "(()))" then your program should return the number 1. 
        // The answer could potentially be 0, and there will always be at least one set 
        // of matching brackets in the string.
        public int RemoveBrackets(string str)
        {
            int count = 0;

            Stack<char> unmatched = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(')
                {
                    unmatched.Push(c);
                }

                // char is ')'
                else
                {
                    // check for matching bracket in stack
                    if (unmatched.Count != 0 && unmatched.Peek() == '(')
                    {
                        unmatched.Pop();
                    }
                    else
                    {
                        unmatched.Push(c);
                    }
                }
            }

            // Stack contains unmatched brackets
            count = unmatched.Count;

            return count;
        }
    }
}

using System;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class StringReverse
    {
        // Have the function FirstReverse(str) take the str parameter being passed and 
        // return the string in reversed order. For example: if the input string is 
        // "Hello World and Coders" then your program should return the string 
        // sredoC dna dlroW olleH.
        public string FirstReverse(string str)
        {
            string result = String.Empty;

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            result = new string(charArray);

            return result;
        }
    }
}

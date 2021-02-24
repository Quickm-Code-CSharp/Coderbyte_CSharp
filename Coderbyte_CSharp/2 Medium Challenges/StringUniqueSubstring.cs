using System;
using System.Collections.Generic;

namespace Coderbyte_CSharp.Medium_Challenges
{
    class StringUniqueSubstring
    {
        // For this challenge you will be searching a string for a particular substring.
        // have the function KUniqueCharacters(str) take the str parameter being passed 
        // and find the longest substring that contains k unique characters, where k will 
        // be the first character from the string. The substring will start from the second 
        // position in the string because the first character will be the integer k. 

        // For example: if str is "2aabbacbaa" there are several substrings that all contain 
        // 2 unique characters, namely: ["aabba", "ac", "cb", "ba"], but your program should 
        // return "aabba" because it is the longest substring. If there are multiple longest 
        // substrings, then return the first substring encountered with the longest length. 
        // k will range from 1 to 6.
        public string KUniqueCharacters(string str)
        {
            string          result          = String.Empty;
            bool            done            = false;
            int             uniqueLength    = (int)char.GetNumericValue(str[0]);
            string          localStr        = str.Substring(1);
            int             substrLength    = localStr.Length;
            //List<string>    substrings      = new List<string>();


            while (!done)
            {
                int uniqueCount = 0;

                List<string> substrings = CreateSubstrings(localStr, substrLength);
                if (substrings.Count == 0)
                {
                    continue;
                }

                foreach(string s in substrings)
                {
                    uniqueCount = ComputeUniqueChars(s);
                    if (uniqueCount == uniqueLength && s.Length > result.Length)
                    {
                        result = s;
                        done = true;
                    }
                }

                substrings.Clear();
                substrLength--;
            }
            return result;
        }

        protected int ComputeUniqueChars(string str)
        {
            int count = 1;
            Dictionary<char, int> charCount = new Dictionary<char, int>(); ;

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }

                else
                {
                    charCount.Add(c, 1);
                }
            }

            count = charCount.Count;

            return count;
        }

        protected List<string> CreateSubstrings(string str, int length)
        {
            List<string>    substrings  = new List<string>();
            int             strLength   = str.Length;

            if (length == strLength)
            {
                substrings.Add(str);
            }

            else if (length < strLength)
            {
                string substr;

                for (int index = 0; index + length <= strLength; index++)
                {
                    substr = str.Substring(index, length);
                    substrings.Add(substr);
                }
            }

            return substrings;
        }

    }
}

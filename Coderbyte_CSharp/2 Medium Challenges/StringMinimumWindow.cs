using System;
using System.Collections.Generic;

namespace Coderbyte_CSharp.Medium_Challenges
{
    class StringMinimumWindow
    {
        // Have the function MinWindowSubstring(strArr) take the array of strings stored
        // in strArr, which will contain only two strings, the first parameter being the 
        // string N and the second parameter being a string K of some characters, and your 
        // goal is to determine the smallest substring of N that contains all the characters 
        // in K. 
        //
        // For example: if strArr is ["aaabaaddae", "aed"] then the smallest substring of N 
        // that contains the characters a, e, and d is "dae" located at the end of the string. 
        // So for this example your program should return the string dae.

        // Another example: if strArr is ["aabdccdbcacd", "aad"] then the smallest substring 
        // of N that contains all of the characters in K is "aabd" which is located at the 
        // beginning of the string. Both parameters will be strings ranging in length from 
        // 1 to 50 characters and all of K's characters will exist somewhere in the string N. 
        // Both strings will only contains lowercase alphabetic characters.

        // Examples
        // Input: {"ahffaksfajeeubsne", "jefaa"}
        // Output: aksfaje

        // Input: {"aaffhkksemckelloe", "fhea"}
        // Output: affhkkse

        public string MinWindowSubstring(string[] strArr, int arrLength)
        {
            string result = string.Empty;

            string text = strArr[0];
            string pattern = strArr[1];

            Dictionary<char, int> countMap = CreateCountMap(pattern);
            List<string> windows = ExtractWindows(text, pattern.Length);

            foreach (string window in windows) 
	{
                if (IsValidWindow(window, countMap))
                {
                    if (String.IsNullOrEmpty(result))
                    {
                        result = window;
                    }
                    else if (window.Length < result.Length)
                    {
                        result = window;
                    }
                }
            }

            return result;
        }

        protected Dictionary<char, int> CreateCountMap(string str)
        {
            Dictionary<char, int> countMap = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (countMap.ContainsKey(c))
                {
                    countMap[c]++;
                }

                else
                {
                    countMap.Add(c, 1);
                }
            }
            return countMap;
        }

        protected List<string> ExtractWindows(string str, int length)
        {
            List<string>    windows     = new List<string>();
            int             strLength   = str.Length;


            for (int start = 0; start < strLength; start++)
            {
                for (int end = start + length; end < strLength + 1; end++)
                {
                    windows.Add(str.Substring(start, end - start));
                }
            }

            return windows;
        }

        protected bool IsValidWindow(string window, Dictionary<char, int> patternMap)
        {
            bool isValid = true;

            Dictionary<char, int> windowMap = CreateCountMap(window);

            foreach(var item in patternMap)
            {
                var key = item.Key;
                var val = item.Value;

                if (!windowMap.ContainsKey(key) || windowMap[key] < val)
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}

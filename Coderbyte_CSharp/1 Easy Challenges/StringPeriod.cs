using System;
using System.Text;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class StringPeriod
    {
        // For this challenge you will need to find the smallest repeating substring.

        // The function StringPeriods(str) take the str parameter being passed and 
        // determine if there is some substring K that can be repeated N > 1 times 
        // to produce the input string exactly as it appears. Your program should 
        // return the longest substring K, and if there is none it should return 
        // the string -1.

        // For example: if str is "abcababcababcab" then your program should return 
        // abcab because that is the longest substring that is repeated 3 times to 
        // create the final string. 

        // Another example: if str is "abababababab" then your program should return 
        // ababab because it is the longest substring. 

        // If the input string contains only a single character, your program should 
        // return the string -1.
        public string StringPeriods(string str)
        {
            string  result     = String.Empty;
            string  sub        = String.Empty;
            int     maxLength  = -1;
            int     strLength  = str.Length;


            if (strLength > 1)
            {
                for (int i = 0; i < strLength / 2; i++)
                {
                    sub = str.Substring(0, i + 1);

                    int len = StringCheck(sub, str);

                    if (len > maxLength)
                    {
                        maxLength = len;
                        result = sub;
                    }
                }
            }

            result = (maxLength != -1) ? result : maxLength.ToString();


            return result;
        }

        protected int StringCheck(string sub, string str)
        {
            int           length = -1;
            int           times  = str.Length / sub.Length;
            StringBuilder sb     = new StringBuilder();

            for (int index = 0; index < times; index++)
            {
                sb.Append(sub);
            }

            string temp = sb.ToString();
            if (temp == str)
            {
                length = sub.Length;
            }


            return length;
        }

    }
}

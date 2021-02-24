using System;
using System.Text;

namespace Coderbyte_CSharp.Medium_Challenges
{
    class StringCompression
    {
        // For this challenge you will determine the Run Length Encoding of a string.
        // The function RunLength(str) take the str parameter being passed and return 
        // a compressed version of the string using the Run-length encoding algorithm. 
        // This algorithm works by taking the occurrence of each repeating character 
        // and outputting that number along with a single character of the repeating 
        // sequence. 

        // For example: "wwwggopp" would return 3w2g1o2p. The string will not contain 
        // any numbers, punctuation, or symbols. 
        public string RunLength(string str)
        {
            string          result  = String.Empty;
            int             length  = str.Length;
            StringBuilder   sb      = new StringBuilder(); 

            for (int index = 0; index < length; index++)
            {
                int count = 0;

                if (IsRepeatingChar(str, index, ref count))
                {
                    sb.Append(count);
                    sb.Append(str[index]);
                    index += count - 1;
                }

                else
                {
                    sb.Append(1);
                    sb.Append(str[index]);
                }
            }

            result = sb.ToString();

            return result;
        }

        protected bool IsRepeatingChar(string str, int index, ref int count)
        {
            bool repeating = false;

            int length = str.Length;
            count = 1;

            if (index != length - 1)
            {
                while ((index < length - 1) && (str[index] == str[index + 1]))
                {
                    count++;
                    index++;
                }
            }

            repeating = (count > 1);

            return repeating;
        }
    }
}

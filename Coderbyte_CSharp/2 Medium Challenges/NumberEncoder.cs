using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp.Medium_Challenges
{
    class NumberEncoder
    {
        // For this challenge you will encode a given string following a specific rule.
        // The function NumberEncoding(str) with str parameter and encode the 
        // message according to the following rule: encode every letter into its 
        // corresponding numbered position in the alphabet. Symbols and spaces will also 
        // be used in the input. 

        // For example: if str is "af5c a#!" then your program should return 1653 1#!. 

        public string NumberEncoding(string str)
        {
            string                  result      = string.Empty;
            StringBuilder           sb          = new StringBuilder();
            Dictionary<char, int>   alphabet    = CreateAlphabetMap();

            foreach (char item in str)
            {
                // is a letter
                if (Char.IsLetter(item))
                {
                    sb.Append(alphabet[item]);
                }

                // not a letter
                else
                {
                    sb.Append(item);
                }
            }

            result = sb.ToString();

            return result;
        }

        protected Dictionary<char, int> CreateAlphabetMap()
        {
            Dictionary<char, int> alpha = new Dictionary<char, int>();

            int value = 1;

            for (char key = 'a'; key <= 'z'; key++, value++)
            {
                alpha.Add(key, value);
            }

            return alpha;
        }
    }
}

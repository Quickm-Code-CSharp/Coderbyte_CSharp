using System;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class StringSymbols
    {
        // Have the function SimpleSymbols(str) take the str parameter being passed and 
        // determine if it is an acceptable sequence by either returning the string true 
        // or false. The str parameter will be composed of + and = symbols with several 
        // characters between them (ie. ++d+===+c++==a) and for the string to be true 
        // each letter must be surrounded by a + symbol. So the string to the left would 
        // be false. The string will not be empty and will have at least one letter.

        public string SimpleSymbols(string str)
        {
            string result = String.Empty;
            bool   found  = false;

            for (int index = 0; index < str.Length && !found; ++index)
            {
                if (Char.IsSymbol(str[index]) || Char.IsLetterOrDigit(str[index]))
                {
                    if ((index == 0) && (index == str.Length - 1))
                    {
                        break;
                    }
                    else if (index != str.Length-1 && 
                             index != 0 &&
                             str[index - 1] == '+' && 
                             str[index + 1] == '+')
                    {
                        found = true;
                    }
                }
            }

            result = found ? "true" : "false";


            return result;
        }
    }
}

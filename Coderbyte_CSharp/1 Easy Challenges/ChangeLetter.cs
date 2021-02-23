using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class ChangeLetter
    {
        // Have the function LetterChanges(str) take the str parameter being passed and 
        // modify it using the following algorithm. Replace every letter in the string 
        // with the letter following it in the alphabet (ie. c becomes d, z becomes a). 
        // Then capitalize every vowel in this new string (a, e, i, o, u) and finally 
        // return this modified string.
        public string LetterChanges(string str)
        {
            string result   = String.Empty;
            char[] chars    = str.ToCharArray();
            //chars[index] = newChar;


            // 1st increment ascii value, wrap z to a
            // 2nd capitalize vowels  
            for (int index = 0; index < chars.Length; index++)
            {
                char c = chars[index];

                if (Char.IsLetter(chars[index]) && chars[index] != 'z')
                {
                    chars[index]++;
                }

                else if (chars[index] == 'z')
                {
                    chars[index] = 'a';
                }

                c = chars[index];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    chars[index] = Char.ToUpper(c);
                }
            }

            result = new string(chars);

            return result;
        }
    }
}

using System;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class StringWords
    {
        public string LongestWord(string sentence)
        {
            string longest = String.Empty;

            char separator = ' ';
            int prevPos = 0, pos = 0;

            if (sentence.IndexOf(separator, pos) == -1)
            {
                longest = sentence;
            }

            else
            {
                string substring = String.Empty;

                while ((pos = sentence.IndexOf(separator, pos)) != -1)
                {
                    // get substring
                    substring = sentence.Substring(prevPos, pos - prevPos);
                    for (int i = 0; i < substring.Length; ++i)
                    {
                        // remove punctuation
                        if (Char.IsPunctuation(substring[i]))
                        {
                            //substring.erase(i--, 1);
                            substring = substring.Remove(i--, 1);
                        }
                    }

                    // check for longest word
                    if (substring.Length > longest.Length)
                    {
                        longest = substring;
                    }

                    prevPos = ++pos;
                }

                for (int i = 0; i < substring.Length; ++i)
                {
                    if (Char.IsPunctuation(substring[i]))
                    {
                        substring = substring.Remove(i--, 1);
                    }
                }
                if (substring.Length > longest.Length)
                {
                    longest = substring;
                }
            }

            return longest;
        }
    }
}

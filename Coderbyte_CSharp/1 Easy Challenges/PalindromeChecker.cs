using System;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class PalindromeChecker
    {
        public  string  Palindrome(string str)
        {
            string result = String.Empty;

            result = (IsPalindrome(str)) ? "true" : "false";

            return result;

        }

        protected bool  IsPalindrome(string str)
        {
            bool    isPalindrome    = false;

            String  local           = new string(' ',str.Length);

            foreach(char c in  str)
            {
                if (!Char.IsWhiteSpace(c))
                {
                    local += c;
                }
            }

            local = local.Trim();

            char[] charArray = local.ToCharArray();
            Array.Reverse(charArray);

            string backwards = new string(charArray);

            isPalindrome = String.Compare(local, backwards, StringComparison.Ordinal) == 0;

            return isPalindrome;
        }
    }
}

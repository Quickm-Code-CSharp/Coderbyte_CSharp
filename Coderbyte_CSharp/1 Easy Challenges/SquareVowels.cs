using System;
using System.Text;

// ReSharper disable CheckNamespace
namespace Coderbyte_CSharp.Easy_Challenges
    // ReSharper restore CheckNamespace
{
    class SquareVowels
    {
        public string VowelSquare(string[] strArr, int length)
        {
            string  result = String.Empty;

            StringBuilder sb = new StringBuilder();
            bool found = false;

            for (int row = 0; row < length && !found; row++)
            {
                int colLength = strArr[row].Length;
                for (int col = 0; col < colLength - 1 && !found; col++)
                {
                    if (IsVowel(strArr[row][col]) && IsVowel(strArr[row][col + 1]) &&
                        IsVowel(strArr[row + 1][col]) && IsVowel(strArr[row + 1][col + 1]))
                    {
                        sb.AppendFormat("{0}-{1}", row, col);
                        result = sb.ToString();
                        found = true;
                    }
                }
            }
            return result;
        }

        protected bool IsVowel(char c)
        {
            bool isValid = false;

            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    isValid = true;
                    break;
                // ReSharper disable once RedundantEmptySwitchSection
                default:
                    break;
            }

            return isValid;
        }
    }
}

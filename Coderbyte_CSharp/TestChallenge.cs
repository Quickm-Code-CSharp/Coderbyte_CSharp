using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Coderbyte_CSharp.Easy_Challenges;
using Coderbyte_CSharp.Medium_Challenges;

namespace Coderbyte_CSharp
{
    class TestChallenge
    {
        #region Support Methods
        protected  void  printArray(int[] arr, int length)
        {

            List<int> data = arr.ToList<int>();

            Console.Write("Array:  [");
            StringBuilder sb = new StringBuilder();

            foreach(int value in data)
            {
                sb.Append(value);
                sb.Append(",");
            }

            // Remove last comma
            sb.Remove(sb.Length - 1, 1);

            Console.Write("{0}]", sb.ToString());
            Console.WriteLine();
        }
        #endregion

        #region Easy Challenges
        public void Test_TimeConvert()
        {
            int totalMinutes = 73;
            TimeConverter tc = new TimeConverter();

            Console.WriteLine("TimeConvert:");
            Console.WriteLine("Input: {0} minutes", totalMinutes);
            Console.WriteLine("Output: {0}", tc.TimeConvert(totalMinutes));
            Console.WriteLine();

        }

        public void Test_AlphabetSoup()
        {
            string text = "jgklsgtiowegtankvlae";
            AlphabetSorter alpha = new AlphabetSorter();

            Console.WriteLine("Alphabet Soup:");
            Console.WriteLine("Input:  {0}", text);
            Console.WriteLine("Output: {0}", alpha.AlphabetSoup(text));
            Console.WriteLine();
        }

        public  void Test_ArithGeoSequence()
        {
            int[]           arr     = new int[] { 2, 4, 8, 16 };
            int             length  = 4;
            MathSequence sequence = new MathSequence(); ;

            Console.WriteLine("ArithGeo Sequence:");
            printArray(arr, length);
            Console.WriteLine("Output: {0}", sequence.ArithGeo(arr, length));
            Console.WriteLine();

        }

        public void Test_Palindrome()
        {
            string text = "jgklsgtiowegtankvlae";
            PalindromeChecker checker = new PalindromeChecker();

            Console.WriteLine("Palindrome:");
            Console.WriteLine("Input: {0}", text);
            Console.WriteLine("Output:  {0}", checker.Palindrome(text));
            Console.WriteLine();


            text = "helleh";
            Console.WriteLine("Input: {0}", text);
            Console.WriteLine("Output:  {0}", checker.Palindrome(text));

            Console.WriteLine();

        }

        public void Test_NumberCheck()
        {
            int num1 = 34;
            int num2 = 56;

            NumberCheck checker = new NumberCheck();

            Console.WriteLine("Number Check:");

            Console.WriteLine("Input: {0}, {1}", num1, num2);
            Console.WriteLine("Output: {0}", checker.CheckNumber(num1, num2));
            Console.WriteLine();

            num1 = 79;
            num2 = 13;
            Console.WriteLine("Input: {0}, {1}", num1, num2);
            Console.WriteLine("Output: {0}", checker.CheckNumber(num1, num2));
            Console.WriteLine();

            num1 = num2;
            Console.WriteLine("Input: {0}, {1}", num1, num2);
            Console.WriteLine("Output: {0}", checker.CheckNumber(num1, num2));

            Console.WriteLine();
        }

        public void  Test_FindIntersection()
        {
            string[] strArr =  new string[2];
            string one = "3, 4, 7, 11, 21";
            string two = "4, 6, 7, 13, 21";

            strArr[0] = one;
            strArr[1] = two;

            StringIntersection si = new StringIntersection();

            Console.WriteLine("FindIntersection: ");
            Console.WriteLine("Input: first: {0} , second: {1}", strArr[0], strArr[1]);
            Console.WriteLine("Output: {0}", si.FindIntersection(strArr));

            Console.WriteLine();
        }
        #endregion

        #region Medium Challenges
        public void test_Consecutive()
        {
            ConsecutiveNumbers numbers = new ConsecutiveNumbers();

            int[] arr = new int[] {4, 6, 8};

            Console.WriteLine("ArithGeo Sequence:");

            printArray(arr, arr.Length);
            Console.WriteLine("Output: {0}", numbers.Consecutive(arr, arr.Length));
            Console.WriteLine();

        }

        public void test_KUniqueCharacters()
        {
            StringUniqueSubstring uniqueFinder = new StringUniqueSubstring();

            string str = "2aabbacbaa";
            StringUniqueSubstring unique = new StringUniqueSubstring();

            Console.WriteLine("K Unique Characters:");

            Console.WriteLine("Input:  {0}", str);
            Console.WriteLine("Output: {0}", unique.KUniqueCharacters(str));

            Console.WriteLine();
        }

        public void test_NumberEncoding()
        {
            NumberEncoder encoder = new NumberEncoder();

            string str = "af5c a#!";
            StringUniqueSubstring unique = new StringUniqueSubstring();

            Console.WriteLine("Number Encoding:");

            Console.WriteLine("Input:  {0}", str);
            Console.WriteLine("Output: {0}", encoder.NumberEncoding(str));
            Console.WriteLine();

            str = "bg&h q@l";
            Console.WriteLine("Input:  {0}", str);
            Console.WriteLine("Output: {0}", encoder.NumberEncoding(str));
            Console.WriteLine();
        }
        #endregion

    }
}

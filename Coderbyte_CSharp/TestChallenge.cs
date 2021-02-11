using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Coderbyte_CSharp.Easy_Challenges;

namespace Coderbyte_CSharp
{
    class TestChallenge
    {
        protected  void  printArray(int[] arr, int length)
        {

            List<int> data = arr.ToList<int>();

            System.Console.Write("Array:  [");
            StringBuilder sb = new StringBuilder();

            foreach(int value in data)
            {
                sb.Append(value);
                sb.Append(",");
            }

            // Remove last comma
            sb.Remove(sb.Length - 1, 1);

            System.Console.Write("{0}]", sb.ToString());
            System.Console.WriteLine();
        }
        public void Test_TimeConvert()
        {
            int totalMinutes = 73;
            TimeConverter tc = new TimeConverter();

            System.Console.WriteLine("TimeConvert:");
            System.Console.WriteLine("Input: {0} minutes", totalMinutes);
            System.Console.WriteLine("Output: {0}", tc.TimeConvert(totalMinutes));
            System.Console.WriteLine();

        }

        public void Test_AlphabetSoup()
        {
            string text = "jgklsgtiowegtankvlae";
            AlphabetSorter alpha = new AlphabetSorter();

            System.Console.WriteLine("Alphabet Soup:");
            System.Console.WriteLine("Input:  {0}", text);
            System.Console.WriteLine("Output: {0}", alpha.AlphabetSoup(text));
            System.Console.WriteLine();
        }

        public  void Test_ArithGeoSequence()
        {
            int[]           arr     = new int[] { 2, 4, 8, 16 };
            int             length  = 4;
            MathSequence sequence = new MathSequence(); ;

            System.Console.WriteLine("ArithGeo Sequence:");
            printArray(arr, length);
            System.Console.WriteLine("Output: {0}", sequence.ArithGeo(arr, length));
            System.Console.WriteLine();

        }

        public void Test_Palindrome()
        {
            string text = "jgklsgtiowegtankvlae";
            PalindromeChecker checker = new PalindromeChecker();

            System.Console.WriteLine("Palindrome:");
            System.Console.WriteLine("Input: {0}", text);
            System.Console.WriteLine("Output:  {0}", checker.Palindrome(text));
            System.Console.WriteLine();


            text = "helleh";
            System.Console.WriteLine("Input: {0}", text);
            System.Console.WriteLine("Output:  {0}", checker.Palindrome(text));

            System.Console.WriteLine();

        }

        public void Test_NumberCheck()
        {
            int num1 = 34;
            int num2 = 56;

            NumberCheck checker = new NumberCheck();

            System.Console.WriteLine("Number Check:");

            System.Console.WriteLine("Input: {0}, {1}", num1, num2);
            System.Console.WriteLine("Output: {0}", checker.CheckNumber(num1, num2));
            System.Console.WriteLine();

            num1 = 79;
            num2 = 13;
            System.Console.WriteLine("Input: {0}, {1}", num1, num2);
            System.Console.WriteLine("Output: {0}", checker.CheckNumber(num1, num2));
            System.Console.WriteLine();

            num1 = num2;
            System.Console.WriteLine("Input: {0}, {1}", num1, num2);
            System.Console.WriteLine("Output: {0}", checker.CheckNumber(num1, num2));

            System.Console.WriteLine();
        }

        public void  Test_FindIntersection()
        {
            string[] strArr =  new string[2];
            string one = "3, 4, 7, 11, 21";
            string two = "4, 6, 7, 13, 21";

            strArr[0] = one;
            strArr[1] = two;

            StringIntersection si = new StringIntersection();

            System.Console.WriteLine("FindIntersection: ");
            System.Console.WriteLine("Input: first: {0} , second: {1}", strArr[0], strArr[1]);
            System.Console.WriteLine("Output: {0}", si.FindIntersection(strArr));

            System.Console.WriteLine();
        }
    }
}

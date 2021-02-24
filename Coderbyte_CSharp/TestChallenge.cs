using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Coderbyte_CSharp.Easy_Challenges;
using Coderbyte_CSharp.Medium_Challenges;
using Coderbyte_CSharp.Hard_Challenges;

namespace Coderbyte_CSharp
{
    class TestChallenge
    {
        #region Support Methods
        protected  void  PrintArray(int[] arr, int length)
        {

            List<int> data = arr.ToList();

            Console.Write("Array:  [");
            StringBuilder sb = new StringBuilder();

            foreach(var value in data)
            {
                sb.Append(value);
                sb.Append(",");
            }

            // Remove last comma
            sb.Remove(sb.Length - 1, 1);

            Console.Write("{0}]", sb);
            Console.WriteLine();
        }

        protected void PrintArray(string[] arr, int length)
        {

            List<string> data = arr.ToList();

            Console.Write("Array:  [");
            StringBuilder sb = new StringBuilder();

            foreach (var value in data)
            {
                sb.Append(value);
                sb.Append(",");
            }

            // Remove last comma
            sb.Remove(sb.Length - 1, 1);

            Console.Write("{0}]", sb);
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
            MathSequence sequence = new MathSequence(); 

            Console.WriteLine("ArithGeo Sequence:");
            PrintArray(arr, length);
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

        public void Test_FindIntersection()
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

        public void Test_FirstFactorial()
        {
            int num = 18;

            Factorial compute = new Factorial();

            Console.WriteLine("First Factorial:");

            Console.WriteLine("Input: {0}", num);
            Console.WriteLine("Output: {0}", compute.FirstFactorial(num));
            Console.WriteLine();
        }

        public void Test_FirstReverse()
        {
            StringReverse reverser = new StringReverse();

            string str = "Hello World and Coders";

            Console.WriteLine("First Reverse:");
            Console.WriteLine("Input: {0}", str);
            Console.WriteLine("Output:  {0}", reverser.FirstReverse(str));
            Console.WriteLine();
        }

        public void Test_LetterChanges()
        {
            ChangeLetter changer = new ChangeLetter();

            string str = "applez";

            Console.WriteLine("Letter Changes:");
            Console.WriteLine("Input: {0}", str);
            Console.WriteLine("Output:  {0}", changer.LetterChanges(str));
            Console.WriteLine();

            str = "coderbyte";

            Console.WriteLine("Input: {0}", str);
            Console.WriteLine("Output:  {0}", changer.LetterChanges(str));
            Console.WriteLine();
        }
        public void Test_LetterCapitalize()
        {
            ChangeLetter changer = new ChangeLetter();

            string str = "applez";

            Console.WriteLine("Letter Capitalize:");
            Console.WriteLine("Input: {0}", str);
            Console.WriteLine("Output:  {0}", changer.LetterCapitalize(str));
            Console.WriteLine();

            str = "coder byte";

            Console.WriteLine("Input: {0}", str);
            Console.WriteLine("Output:  {0}", changer.LetterCapitalize(str));
            Console.WriteLine();
        }

        public void Test_PowerOfTwo()
        {
            ExponentTwo power = new ExponentTwo();

            int num = 16;

            Console.WriteLine("Powers of Two:");
            Console.WriteLine("Input: {0}", num);
            Console.WriteLine("Output:  {0}", power.PowersofTwo(num));
            Console.WriteLine();

            num = 34;

            Console.WriteLine("Input: {0}", num);
            Console.WriteLine("Output:  {0}", power.PowersofTwo(num));
            Console.WriteLine();
        }

        public void Test_ProductDigits()
        {
            MathProduct prod = new MathProduct();
            int num = 90;

            Console.WriteLine("Product Digits:");
            Console.WriteLine("Input: {0}", num);
            Console.WriteLine("Output:  {0}", prod.ProductDigits(num));
            Console.WriteLine();

            num = 6;
            Console.WriteLine("Product Digits:");
            Console.WriteLine("Input: {0}", num);
            Console.WriteLine("Output:  {0}", prod.ProductDigits(num));
            Console.WriteLine();

            num = 23;
            Console.WriteLine("Product Digits:");
            Console.WriteLine("Input: {0}", num);
            Console.WriteLine("Output:  {0}", prod.ProductDigits(num));
            Console.WriteLine();
        }

        public void Test_OtherProducts()
        {
            MathProduct prod = new MathProduct();
            int[] arr = new int[] {1, 2, 3, 4, 5 };
            

            Console.WriteLine("Other Products:");
            PrintArray(arr, arr.Length);
            Console.WriteLine("Output: {0}", prod.OtherProducts(arr, arr.Length));
            Console.WriteLine();

        }

        public void Test_VowelSquare()
        {
            SquareVowels square = new SquareVowels();

            Console.WriteLine("Letter Changes:");

            string[] strArr = new string[] { "abcd", "eikr", "oufj" };
            PrintArray(strArr, strArr.Length);
            Console.WriteLine("Output: {0}", square.VowelSquare(strArr, strArr.Length));
            Console.WriteLine();

            string[] strArr2 = new string[] { "lbzk", "ncdf", "mxio", "pqau" };
            PrintArray(strArr2, strArr2.Length);
            Console.WriteLine("Output: {0}", square.VowelSquare(strArr2, strArr2.Length));
            Console.WriteLine();
        }

        public void Test_LongestWord()
        {
            StringWords   longest = new StringWords();

            string str = "The fox wouldn't lazy in the forest.";

            Console.WriteLine("Longest Word:");
            Console.WriteLine("Input: {0}", str);
            Console.WriteLine("Output:  {0}", longest.LongestWord(str));
            Console.WriteLine();
        }

        public void Test_MovingMedian()
        {
            MedianMovement mover = new MedianMovement();

            Console.WriteLine("Moving Median:");
            int[] arr = new int[] {3, 1, 3, 5, 10, 6, 4, 3, 1};

            PrintArray(arr, arr.Length);
            Console.WriteLine("Output: {0}", mover.MovingMedian(arr, arr.Length));
            Console.WriteLine();

        }


        #endregion

        #region Medium Challenges
        public void Test_Consecutive()
        {
            ConsecutiveNumbers numbers = new ConsecutiveNumbers();

            int[] arr = new int[] {4, 6, 8};

            Console.WriteLine("ArithGeo Sequence:");

            PrintArray(arr, arr.Length);
            Console.WriteLine("Output: {0}", numbers.Consecutive(arr, arr.Length));
            Console.WriteLine();

        }

        public void Test_KUniqueCharacters()
        {
            string str = "2aabbacbaa";
            StringUniqueSubstring unique = new StringUniqueSubstring();

            Console.WriteLine("K Unique Characters:");

            Console.WriteLine("Input:  {0}", str);
            Console.WriteLine("Output: {0}", unique.KUniqueCharacters(str));

            Console.WriteLine();
        }

        public void Test_NumberEncoding()
        {
            NumberEncoder encoder = new NumberEncoder();

            Console.WriteLine("Number Encoding:");

            string str = "af5c a#!";
            Console.WriteLine("Input:  {0}", str);
            Console.WriteLine("Output: {0}", encoder.NumberEncoding(str));
            Console.WriteLine();

            str = "bg&h q@l";
            Console.WriteLine("Input:  {0}", str);
            Console.WriteLine("Output: {0}", encoder.NumberEncoding(str));
            Console.WriteLine();
        }

        public void Test_PrimeMover()
        {
            PrimeNumber prime = new PrimeNumber();
            int num = 3;

            Console.WriteLine("Prime Mover:");

            Console.WriteLine("Input:  {0}", num);
            Console.WriteLine("Output: {0}", prime.PrimeMover(num));
            Console.WriteLine();

            num = 100;
            Console.WriteLine("Input:  {0}", num);
            Console.WriteLine("Output: {0}", prime.PrimeMover(num));
            Console.WriteLine();
        }

        public void Test_MinWindowSubstring()
        {
            StringMinimumWindow minFinder = new StringMinimumWindow();

            string text = "ahffaksfajeeubsne";
            string pattern = "jefaa";

            string[] strArr = new string[]{ text, pattern };

            Console.WriteLine("Minimum Window Substring:");

            Console.WriteLine("Input:  {0}  {1}", text, pattern);
            Console.WriteLine("Output: {0}", minFinder.MinWindowSubstring(strArr, strArr.Length));
            Console.WriteLine();

            text = "aaffhkksemckelloe";
            pattern = "fhea";
            strArr[0] = text;
            strArr[1] = pattern;

            Console.WriteLine("Input:  {0}  {1}", text, pattern);
            Console.WriteLine("Output: {0}", minFinder.MinWindowSubstring(strArr, strArr.Length));
            Console.WriteLine();

        }

        public void Test_RunLength()
        {
            StringCompression   compress    = new StringCompression();
            string              str         = "wwwggopp";

            Console.WriteLine("Run Length:");

            Console.WriteLine("Input:  {0}", str);
            Console.WriteLine("Output: {0}", compress.RunLength(str));
            Console.WriteLine();

            str = "wwwbbbw";
            Console.WriteLine("Input:  {0}", str);
            Console.WriteLine("Output: {0}", compress.RunLength(str));
            Console.WriteLine();


        }

        public void Test_StringReduction()
        {
            StringReducer   reducer     = new StringReducer();
            string          str         = "ac";

            Console.WriteLine("Run Length:");

            Console.WriteLine("Input:  {0}", str);
            Console.WriteLine("Output: {0}", reducer.StringReduction(str));
            Console.WriteLine();

            str = "cab";
            Console.WriteLine("Input:  {0}", str);
            Console.WriteLine("Output: {0}", reducer.StringReduction(str));
            Console.WriteLine();


        }

        public void Test_TreeConstructor()
        {
            TreeGraphs tree = new TreeGraphs();
            string[] strArr = new string[] { "(1,2)", "(2,4)", "(7,2)" };

            Console.WriteLine("Tree Constructor:");
            PrintArray(strArr, strArr.Length);
            Console.WriteLine("Output: {0}", tree.TreeConstructor(strArr, strArr.Length));
            Console.WriteLine();

            string[] strArr2 = new string[] { "(1,2)", "(9,2)", "(2,4)", "(7,2)" };
            PrintArray(strArr2, strArr2.Length);
            Console.WriteLine("Output: {0}", tree.TreeConstructor(strArr2, strArr2.Length));
            Console.WriteLine();

            string[] strArr3 = new string[] { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)" };
            PrintArray(strArr3, strArr3.Length);
            Console.WriteLine("Output: {0}", tree.TreeConstructor(strArr3, strArr3.Length));
            Console.WriteLine();
        }
        #endregion

        #region Hard Challenges
        public void Test_KaprekarsConstant()
        {
            Kaprekar    k               = new Kaprekar();
            int         value           = 3524;

            Console.WriteLine("Kaprekars Constant:");
            Console.WriteLine("Input: {0} ", value);
            Console.WriteLine("Output: {0}", k.KaprekarsConstant(value));
            Console.WriteLine();
        }

        public void Test_Determinant()
        {
            Determinant d       = new Determinant();

            string[]    array   = new string[] { "1", "4", "3", "<>", "2", "3", "0", "<>", "5", "-3", "4" };

            Console.WriteLine("Matrix Determinant:");
            PrintArray(array, array.Length);
            Console.WriteLine("Output: {0}", d.MatrixDeterminant(array, array.Length));
            Console.WriteLine();

        }
        #endregion
    }
}

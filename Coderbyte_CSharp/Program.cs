using System;

namespace Coderbyte_CSharp
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Coderbyte C-Sharp code challenge solutions...");
            Console.WriteLine();

            TestChallenge tc = new TestChallenge();

            // Easy
            Console.WriteLine("Easy Code Challenges:");
            tc.Test_TimeConvert();
            tc.Test_AlphabetSoup();
            tc.Test_ArithGeoSequence();
            tc.Test_Palindrome();
            tc.Test_NumberCheck();
            tc.Test_FindIntersection();
            tc.Test_FirstFactorial();
            tc.Test_FirstReverse();
            tc.Test_LetterChanges();
            tc.Test_LetterCapitalize();
            tc.Test_PowerOfTwo();
            tc.Test_ProductDigits();
            tc.Test_OtherProducts();
            tc.Test_VowelSquare();
            tc.Test_LongestWord();
            tc.Test_MovingMedian();
            tc.Test_QuestionsMarks();
            tc.Test_RemoveBrackets();
            tc.Test_FibonacciChecker();
            tc.Test_SimpleAdding();
            tc.Test_SimpleSymbols();
            tc.Test_StringPeriods();
            tc.Test_UsernameValidation();

            // Medium
            Console.WriteLine("Medium Code Challenges:");
            tc.Test_Consecutive();
            tc.Test_KUniqueCharacters();
            tc.Test_NumberEncoding();
            tc.Test_PrimeMover();
            tc.Test_MinWindowSubstring();
            tc.Test_RunLength();
            tc.Test_StringReduction();
            tc.Test_TreeConstructor();

            // Hard
            Console.WriteLine("Hard Code Challenges:");
            tc.Test_KaprekarsConstant();
            tc.Test_Determinant();
        }
    }
}

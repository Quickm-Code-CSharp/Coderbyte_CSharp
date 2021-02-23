using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Coderbyte C-Sharp code challenge solutions...");
            System.Console.WriteLine();

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

            // Medium
            Console.WriteLine("Medium Code Challenges:");
            tc.Test_Consecutive();
            tc.Test_KUniqueCharacters();
            tc.Test_NumberEncoding();
            tc.Test_PrimeMover();
            tc.Test_MinWindowSubstring();
            tc.Test_RunLength();
            tc.Test_StringReduction();
            //tc.Test_TreeConstructor();

            // Hard
            Console.WriteLine("Hard Code Challenges:");
            tc.Test_KaprekarsConstant();
            tc.Test_Determinant();
        }
    }
}

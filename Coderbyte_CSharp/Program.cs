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
            tc.Test_TimeConvert();
            tc.Test_AlphabetSoup();
            tc.Test_ArithGeoSequence();
            tc.Test_Palindrome();
            tc.Test_NumberCheck();
            tc.Test_FindIntersection();

            // Medium
            tc.test_Consecutive();
            tc.test_KUniqueCharacters();
            tc.test_NumberEncoding();
        }
    }
}

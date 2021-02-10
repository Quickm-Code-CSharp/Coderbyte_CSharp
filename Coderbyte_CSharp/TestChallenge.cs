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
        public void Test_TimeConvert()
        {
            int totalMinutes = 73;
            TimeConverter tc = new TimeConverter();

            System.Console.WriteLine("TimeConvert:");
            System.Console.WriteLine("Input: {0} minutes converts to {1}", totalMinutes, tc.TimeConvert(totalMinutes));
            System.Console.WriteLine();

        }

        public void Test_AlphabetSoup()
        {
            string text = "jgklsgtiowegtankvlae";
            AlphabetSorter alpha = new AlphabetSorter();

            System.Console.WriteLine("Alphabet Soup:");
            System.Console.WriteLine("Input: {0} converts to Output:  {1}", text, alpha.AlphabetSoup(text));
            System.Console.WriteLine();
        }

    }
}

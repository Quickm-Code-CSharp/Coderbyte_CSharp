﻿using System;
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
            System.Console.WriteLine("Input: {0}", text);
            System.Console.WriteLine("Output:  {0}", alpha.AlphabetSoup(text));
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

    }
}
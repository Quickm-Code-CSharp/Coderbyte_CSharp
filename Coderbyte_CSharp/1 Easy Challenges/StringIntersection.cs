using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class StringIntersection
    {
        // Have the function FindIntersection(strArr) read the array of strings stored 
        // in strArr which will contain 2 elements: the first element will represent a 
        // list of comma - separated numbers sorted in ascending order, the second 
        // element will represent a second list of comma - separated numbers(also sorted).
        // Your goal is to return a comma - separated string containing the numbers that 
        // occur in elements of strArr in sorted order.If there is no intersection, 
        // return the string false.

        // For example : if strArr contains["1, 3, 4, 7, 13", "1, 2, 4, 13, 15"] the 
        // output should return "1,4,13" because those numbers appear in both strings.
        // The array given will not be empty, and each string inside the array will be 
        // of numbers sorted in ascending order and may contain negative numbers.

        public string FindIntersection(string[] strArr)
        {
            string result = String.Empty;
            char delim = ',';

            int[] first  = TokenizeInt(strArr[0], delim);
            int[] second = TokenizeInt(strArr[1], delim);

            List<int> matches = new List<int>();
            
            // find matches between an arrays
            foreach(int value1 in first)
            {
                foreach(int value2 in second)
                {
                    if (value1 == value2)
                    {
                        matches.Add(value1);
                    }
                }
            }

            // Convert list to output string
            StringBuilder sb = new StringBuilder();

            int count = matches.Count;
            foreach( int value in matches)
            {
                sb.Append(value);
                if (value != matches[count-1])
                {
                    sb.Append(",");
                }
            }

            result = sb.ToString();

            return result;
        }

        protected int[] TokenizeInt(string str, char delim)
        {
            string[]    strValues   = str.Split(delim);
            int[]       nums        = new int[strValues.Length];

            for(int index = 0; index < strValues.Length; index++)
            {
                try
                {
                    nums[index] = Int32.Parse(strValues[index]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Unable to parse {0}", strValues[index]);
                    Console.Error.Write(e.Message);
                }
            }

            return nums;
        }
    }
}




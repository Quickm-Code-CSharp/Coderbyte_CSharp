using System;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class MathSequence
    {
        // The function ArithGeo(arr) takes an array of numbers stored in arr and return 
        // the string "Arithmetic" if the sequence follows an arithmetic pattern or return 
        // "Geometric" if it follows a geometric pattern.If the sequence doesn't follow 
        // either pattern return -1. An arithmetic sequence is one where the difference 
        // between each of the numbers is consistent, where as in a geometric sequence, 
        // each term after the first is multiplied by some constant or common ratio. 

        // Arithmetic example: [2, 4, 6, 8] and Geometric example: [2, 6, 18, 54]. 
        // Negative numbers may be entered as parameters, 0 will not be entered, and 
        // no array will contain all the same elements.

        public string ArithGeo(int[] arr, int length)
        {
            string result = String.Empty;

            if (IsArithematicSequence(arr, length))
            {
                result = "Arithmetic";
            }

            else if (IsGeometricSequence(arr, length))
            {
                result = "Geometric";
            }

            else
            {
                result = "-1";
            }

            return result;

        }

        protected bool IsArithematicSequence(int[] arr, int length)
        {
            bool result = false;
            bool isSequence = true;

            if (length >= 2)
            {
                int diff = arr[1] - arr[0];

                // Check is the difference is true for all elements
                // If true than the array is arithmetic
                for (int index = 0; index < length - 1 && isSequence; index++)
                {
                    isSequence = false;
                    if (arr[index] + diff == arr[index + 1])
                    {
                        isSequence = true;
                    }
                }
            }

            result = isSequence;

            return result;
        }
        protected bool IsGeometricSequence(int[] arr, int length)
        {
            bool result = false;
            bool isSequence = true;

            if (length >= 2)
            {
                int diff = arr[1] / arr[0];

                // Iterate through array
                for (int index = 0; index < length - 1 && isSequence; index++)
                {
                    isSequence = false;

                    // Check for geometric pattern
                    if (arr[index] * diff == arr[index + 1])
                    {
                        isSequence = true;
                    }
                }
            }

            result = isSequence;

            return result;
        }
    }
}

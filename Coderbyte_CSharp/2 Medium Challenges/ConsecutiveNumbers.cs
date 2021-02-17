using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp.Medium_Challenges
{
    class ConsecutiveNumbers
    {
        // The function Consecutive(arr) has an integer array paameter.  The function 
        // returns the minimum number of integers needed to make the contents of arr 
        // consecutive from the lowest number to the highest number. 

        // For example: If arr contains [4, 8, 6] then the output should be 2 because 
        // two numbers need to be added to the array (5 and 7) to make it a consecutive 
        // array of numbers from 4 to 8. Negative numbers may be entered as parameters 
        // and no array will have less than 2 elements. 
        public int Consecutive(int[] arr, int length)
        {
            int     missingCount    = 0;
            int[]   numbers         = arr;

            Array.Sort(arr);

            //sort(numbers.begin(), numbers.end());

            for (int index = 0; index < length - 1; index++)
            {
                int addCount = 0;
                while (numbers[index + 1] != numbers[index] + 1 + addCount)
                {
                    addCount++;
                }

                missingCount += addCount;
            }


            return missingCount;
        }
    }
}

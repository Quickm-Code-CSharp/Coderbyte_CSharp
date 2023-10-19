using System.Collections.Generic;
using System.Linq;

namespace Coderbyte_CSharp.Hard_Challenges
{
    class Kaprekar
    {
        // Have the function KaprekarsConstant(num) take the num parameter being passed 
        // which will be a 4-digit number with at least two distinct digits. Your program 
        // should perform the following routine on the number: Arrange the digits in 
        // descending order and in ascending order (adding zeroes to fit it to a 4-digit 
        // number), and subtract the smaller number from the bigger number. Then repeat 
        // the previous step. Performing this routine will always cause you to reach a 
        // fixed number: 6174. Then performing the routine on 6174 will always give you 
        // 6174 (7641 - 1467 = 6174). Your program should return the number of times 
        // this routine must be performed until 6174 is reached. 

        // For example: if num is 3524 your program should return 3 because of the 
        // following steps: (1) 5432 - 2345 = 3087, (2) 8730 - 0378 = 8352, 
        // (3) 8532 - 2358 = 6174.

        public int KaprekarsConstant(int num)
        {
            int count       = 0;
            int remainder   = num;

            while (remainder != 6174)
            {
                remainder = DescendInt(remainder) - AscendInt(remainder);
                count++;
            }

            return count;
        }

        protected int AscendInt(int num)
        {
            int result = 0;

            result = AdjustInt(num, false);
            return result;
        }

        protected int DescendInt(int num)
        {
            int result = 0;

            result = AdjustInt(num, true);
            return result;
        }

	    private int AdjustInt(int num, bool descend)
        {
            int     result  = 0;
            int[]   arr     = ConvertToIntArray(num);

            List<int> valueList = arr.ToList();
            valueList.Sort();

            if (descend)
            {
                valueList.Reverse();
            }

            result = int.Parse(string.Join("", valueList));
            return result;
        }

        private int[] ConvertToIntArray(int value)
        {
            var numbers = new Stack<int>();

            for (; value > 0; value /= 10)
            {
                numbers.Push(value % 10);
            }

            return numbers.ToArray();
        }


    }
}

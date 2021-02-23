using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class MathProduct
    {
        // Challenge
        // function ProductDigits(num) has a num parameter, which is a positive integer.  
        // Determine the least amount of digits you need to multiply to produce the 
        // value .

        // For example : if num is 24 then you can multiply 8 by 3 which produces 24, 
        // so your program should return 2 because there is a total of only 2 digits 
        // that are needed.

        // Another example : if num is 90, you can multiply 10 * 9, so in this case 
        // your program should output 3 because you cannot reach 90 without using a 
        // total of 3 digits in your multiplication.

        //Sample Test Cases
        //  Input : 6
        //	Output : 2
        //	Input : 23
        //	Output : 3
        public int ProductDigits(int num)
        {
            int result = num.ToString().Length + 1; 

            int factor;
            int value = 0;
            for (int index = 1; index <= Math.Sqrt(num); index++)
            {
                // Is index a factor of num
                if (num % index == 0)
                {
                    factor = num / index;
                    value = index.ToString().Length + factor.ToString().Length ;
                    result = Math.Min(result, value);
                }
            }


            return result;
        }

    }
}

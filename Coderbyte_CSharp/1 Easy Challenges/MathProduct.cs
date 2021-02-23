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

        // Have the function OtherProducts(arr) take the array of numbers stored in arr 
        // and return a new list of the products of all the other numbers in the array 
        // for each element. 

        // For example: if arr is [1, 2, 3, 4, 5] then the new array, 
        // where each location in the new array is the product of all other elements, 
        // is [120, 60, 40, 30, 24]. The following calculations were performed to get 
        // this answer: [(2*3*4*5), (1*3*4*5), (1*2*4*5), (1*2*3*5), (1*2*3*4)]. You 
        // should generate this new array and then return the numbers as a string 
        // joined by a hyphen: 120-60-40-30-24. The array will contain at most 10 
        // elements and at least 1 element of only positive integers.
        public string OtherProducts(int[] arr, int length)
        {
            string      result          = String.Empty;
            List<int>   productValues   = new List<int>(length);
            int         product = 1;

            for (int index = 0; index < length; index++)
            {
                product = ComputeProduct(arr, index);
                productValues.Add(product);
            }

            StringBuilder sb = new StringBuilder();

            foreach (int item in productValues)
            {
                sb.Append(item);
                sb.Append("-");
            }

            result = sb.ToString();
            result = result.Remove(result.Length - 1);

            return result;
        }

        protected int ComputeProduct(int[] arr, int index)
        {
            int result = 1;
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                if (i == index) { continue; }
                result *= arr[i];
            }

            return result;
        }
    }
}

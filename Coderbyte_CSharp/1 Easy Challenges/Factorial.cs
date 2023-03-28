namespace Coderbyte_CSharp.Easy_Challenges
{
    class Factorial
    {
        // Have the function FirstFactorial(num) take the num parameter being passed and 
        // return the factorial of it. For example: if num = 4, then your program should 
        // return (4 * 3 * 2 * 1) = 24. For the test cases, the range will be between 1 
        // and 18 and the input will always be an integer.
        public ulong FirstFactorial(int num)
        {
            //ulong factorial = (ulong)num;

            //for (int index = num - 1; index > 1; index--)
            //{
            //    factorial *= (ulong)index;
            //}

            //return factorial;

            ulong result = 0;

            if (num == 0)
            {
                result = 1;
            }

            else
            {
                result = (ulong)num * FirstFactorial(num - 1);
            }

            return result;
        }
    }
}

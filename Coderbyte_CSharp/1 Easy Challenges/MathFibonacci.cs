using System;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class MathFibonacci
    {
        public string FibonacciChecker(int num)
        {
            string result      = String.Empty;
            bool   isFibonacci = false;

            isFibonacci = IsValidFibonacci(1, 1, num);

            result = (isFibonacci) ? "yes" : "no";

            return result;
        }

        protected bool IsValidFibonacci(int x, int y, int num)
        {
            bool isFibonacci = false;

            if (num == 0 || num == 1)
            {
                isFibonacci = true;
            }

            else if (x + y == num)
            {
                isFibonacci = true;
            }

            else if (x + y < num)
            {
                isFibonacci = IsValidFibonacci(x + y, x, num);
            }

            else
            {
                isFibonacci = false;
            }

            return isFibonacci;
        }
    }
}

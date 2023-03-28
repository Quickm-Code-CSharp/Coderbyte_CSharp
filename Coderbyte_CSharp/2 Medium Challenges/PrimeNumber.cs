using System.Collections.Generic;

namespace Coderbyte_CSharp.Medium_Challenges
{
    class  PrimeNumber
    {
        public int PrimeMover(int num)
        {
            int         primeValue = 1;

            bool        found = false;
            List<int>   primes = PrefillPrimeVector();
            int index = primes.Count;

            if (primes.Count >= num)
            {
                primeValue = primes[num - 1];
                found = true;
            }

            while (primes.Count < num)
            {
                bool isPrime = false;

                index++;
                isPrime = IsPrimeNumber(index, primes);
                if (isPrime)
                {
                    primes.Add(index);
                    if (primes.Count == num)
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                primeValue = primes[num - 1];
            }
            return primeValue;
        }

        protected List<int> PrefillPrimeVector()
        {
            List<int> primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19 };

            return primes;
        }

        protected bool IsPrimeNumber(int num, List<int> primes)
        {
            bool result = true;

            foreach (int index in primes)
            {
                if (num % index == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class MathSummation
    {
        public int SimpleAdding(int num)
        {
            int result = 0;

            for (int index = 1; index <= num; index++)
            {
                result += index;
            }

            return result;
        }
    }
}

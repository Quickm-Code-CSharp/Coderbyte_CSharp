using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class ExponentTwo
    {
        public string PowersofTwo(int num)
        {
            string  result = String.Empty;
            bool    same = false;

            same = Math.Ceiling(Math.Log(num,2)) == Math.Floor(Math.Log(num, 2));

            result = (same) ? "true" : "false";
            return result;
        }
    }
}

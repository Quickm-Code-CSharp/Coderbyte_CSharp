using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class TimeConverter
    {
        public String   TimeConvert(int num)
        {
            string          result  = string.Empty;
            StringBuilder   sb      = new StringBuilder();

            int hours   = num / 60;
            int minutes = num % 60;

            sb.Append(hours);
            sb.Append(":");
            sb.Append(minutes);

            result = sb.ToString();

            return result;
        }
    }
}

using System;
using System.Text;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class TimeConverter
    {
        // Have the function TimeConvert(num) take the num parameter being passed and 
        // return the number of hours and minutes the parameter converts to (ie. if 
        // num = 63 then the output should be 1:3). Separate the number of hours 
        // and minutes with a colon.

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

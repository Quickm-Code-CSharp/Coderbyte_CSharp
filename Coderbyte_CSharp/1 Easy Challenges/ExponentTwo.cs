using System;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class ExponentTwo
    {
        public string PowersofTwo(int num)
        {
            string  result = String.Empty;
            bool    same = false;

            same = Same(num, 2);

            result = (same) ? "true" : "false";
            return result;
        }

        private static bool Same(int num, int baseValue)
        {
            bool same;
            double tolerance = Double.Epsilon;
            same = Math.Abs(Math.Ceiling(Math.Log(num, baseValue)) - Math.Floor(Math.Log(num, baseValue))) < tolerance;
            return same;
        }
    }
}

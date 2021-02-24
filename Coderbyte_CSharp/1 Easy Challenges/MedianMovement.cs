using System;
using System.Collections.Generic;
using System.Text;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class MedianMovement
    {
        public string MovingMedian(int[] arr, int length)
        {
            string        result     = String.Empty;
            List<int>     nums       = new List<int>();
            int           windowSize = arr[0];
            int           median     = 0;
            StringBuilder sb         = new StringBuilder();

            for (int i = 1; i < length; i++)
            {
                nums.Add(arr[i]);
                if (nums.Count > windowSize)
                {
                    nums.RemoveRange(0,1);
                }

                median = CalculateMedian(nums);
                sb.AppendFormat("{0},", median);
            }

            result = sb.ToString();
            result = result.TrimEnd(',');

            return result;
        }

        protected int CalculateMedian(List<int> values)
        {
            int        median = 0;
            List<int>  local  = new List<int>(values);
            int        half   = values.Count / 2;

            local.Sort();

            median = (local.Count % 2 == 0) ? (local[half - 1] + local[half]) / 2
                                             : local[half];

            return median;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowProblem
{
    class SmallestSubarrayWithAGivenSum
    {
        public static int SmallestSubarrayWithAGivenSumMethod(int k, int[] arr)
        {
            int windowStart = 0;
            int minLength = Int32.MaxValue;
            double windowSum = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];

                if (windowSum >= k)
                {
                    minLength = Math.Min(minLength, windowEnd - windowStart + 1);
                    windowSum = windowSum - arr[windowStart];
                    windowStart += 1;
                }
            }

            return minLength == Int32.MaxValue ? 0 : minLength;
        }
    }
}

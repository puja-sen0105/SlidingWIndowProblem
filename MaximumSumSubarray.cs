using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowProblem
{
    class MaximumSumSubarray
    {
        public static int MaximumSumWithSingleIteration(int k, int[] arr)
        {
            int windowStart = 0;
            int windowSum = 0;
            int maxSum = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];
                if (windowEnd >= k - 1)
                {
                    maxSum = Math.Max(maxSum, windowSum);
                    windowSum = windowSum - arr[windowStart];
                    windowStart += 1;
                }
            }

            return maxSum;
        }

        public static int MaximumSumWithDoubleIteration(int k, int[] arr)
        {
            
            int windowSum = 0;
            int maxSum = 0;

            for(int i = 0; i <= arr.Length - k; i++)
            {
                windowSum = 0;
                for (int j = i; j < i + k; j++)
                {
                    windowSum += arr[j];
                }
                maxSum = Math.Max(maxSum, windowSum);
            }

            return maxSum;
        }
    }
}

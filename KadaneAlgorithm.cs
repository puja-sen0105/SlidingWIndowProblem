using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowProblem
{
    class KadaneAlgorithm
    {
        public static int MaximumSum(int[] arr)
        {
            //int maxStart = 0;
            int sum = 0;
            int maxSum = 0;

            for (int maxEnd = 0; maxEnd < arr.Length; maxEnd++)
            {
                sum = sum + arr[maxEnd];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }

                if (sum < 0)
                {
                    sum = 0;
                }
            }

            return maxSum;
        }

        public static int[] MaximumSumIndexes(int[] arr)
        {
            //int maxStart = 0;
            int sum = 0;
            int maxSum = arr[0];
            int startIndex = 0;
            int endIndex = 0;

            for (int maxEnd = 0; maxEnd < arr.Length; maxEnd++)
            {
                sum = sum + arr[maxEnd];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    endIndex = maxEnd;
                }

                if (sum < 0)
                {
                    sum = 0;
                    startIndex = maxEnd + 1;
                }
            }

            return new int[] { startIndex, endIndex };
        }
    }
}

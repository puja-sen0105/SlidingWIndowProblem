using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowProblem
{
    class SingleIteration
    {
        public static double[] AverageSum(int k, int[] arr)
        {
            int windowStart = 0;
            double windowSum = 0;
            double[] result = new double[arr.Length - k + 1]; // Number of subgroups

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];
                if (windowEnd >= k - 1)
                {
                    result[windowStart] = windowSum / k;
                    windowSum = windowSum - arr[windowStart];
                    windowStart += 1;
                }
            }

            return result;
        }
    }

    class DoubleIteration
    {
        public static double[] AverageSum(int k, int[] arr)
        {
            double[] result = new double[arr.Length - k + 1]; // Number of subgroups

            for (int i = 0; i <= arr.Length - k; i++)
            {
                double sum = 0;
                for (int j = i; j < i + k; j++)
                {
                    sum += arr[j];
                }
                result[i] = sum / k;
            }
            return result;
        }
    }
}

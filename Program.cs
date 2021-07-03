using System;

namespace SlidingWindowProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] result2 = AvgOfSubArraySingleIteration.AverageSum(5, new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 });
            double[] result1 = AvgOfSubArrayDoubleIteration.AverageSum(5, new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 });
            int maxElement = MaximumSumSubarray.MaximumSumWithSingleIteration(3, new int[] { 2, 1, 5, 1, 3, 2 });
            int maxElement1 = MaximumSumSubarray.MaximumSumWithSingleIteration(2, new int[] { 2, 3, 4, 1, 5 });
            int maxElement2 = MaximumSumSubarray.MaximumSumWithDoubleIteration(3, new int[] { 2, 1, 5, 1, 3, 2 });
            int maxElement3 = MaximumSumSubarray.MaximumSumWithDoubleIteration(2, new int[] { 2, 3, 4, 1, 5 });
            int result = SmallestSubarrayWithAGivenSum.SmallestSubarrayWithAGivenSumMethod(7, new int[] { 2, 1, 5, 2, 3, 2 });       
            result = SmallestSubarrayWithAGivenSum.SmallestSubarrayWithAGivenSumMethod(7, new int[] { 2, 1, 5, 2, 8 });
            result = SmallestSubarrayWithAGivenSum.SmallestSubarrayWithAGivenSumMethod(8, new int[] { 3, 4, 1, 1, 6 });
            Console.WriteLine("Hello Coding!");
            Console.ReadLine();
        }     
    }
}

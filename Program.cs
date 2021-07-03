using System;

namespace SlidingWindowProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] result = AvgOfSubArraySingleIteration.AverageSum(5, new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 });
            double[] result1 = AvgOfSubArrayDoubleIteration.AverageSum(5, new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 });
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }     
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowProblem
{
    class FruitsIntoBaskets
    {
        public static int FruitsIntoBasketsMethod(char[] arr, int numberOfBaskets)
        {
            int maxstart = 0;
            int maxLength = 0;
            Dictionary<char, int> charFrequencyMap = new Dictionary<char, int>();

            for (int maxEnd = 0; maxEnd < arr.Length; maxEnd++)
            {
                char rightChar = arr[maxEnd];
                charFrequencyMap.Put(rightChar, charFrequencyMap.GetOrDefault(rightChar, 0) + 1);

                while (charFrequencyMap.Count > numberOfBaskets)
                {
                    char leftChar = arr[maxstart];
                    charFrequencyMap.Put(leftChar, charFrequencyMap.GetOrDefault(rightChar, 0) - 1);

                    if (charFrequencyMap[leftChar] == 0)
                    {
                        charFrequencyMap.Remove(leftChar);
                    }

                    maxstart += 1;
                }

                maxLength = Math.Max(maxLength, maxEnd - maxstart + 1);

            }

            return maxLength;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowProblem
{
    public static class DictionaryExtension
    {
        public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value) where TValue : new()
        {
            TValue ret;
            if (dictionary.ContainsKey(key))
            {
                ret = dictionary[key];
            }
            else
            {
                ret = value;
            }
            return ret;
        }

        public static void Put<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value) where TValue : new()
        {         
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
            }
            else
            {
                dictionary.Add(key, value);
            }          
        }
    }

    class LongestSubstringWithKDistinctCharacters
    {
        //        Input: String="araaci", K=2
        //        Output: 4
        //        Explanation: The longest substring with no more than '2' distinct characters is "araa".

        //        Input: String="araaci", K=1
        //        Output: 2
        //        Explanation: The longest substring with no more than '1' distinct characters is "aa".

        //        Input: String="cbbebi", K=3
        //        Output: 5
        //        Explanation: The longest substrings with no more than '3' distinct characters are "cbbeb" & "bbebi".

        public static int LongestSubstringWithKDistinctCharactersMethod( string str, int k)
        {
            int windowStart = 0;
            int maxLength = 0;
            Dictionary<char, int> charFrequencyMap = new Dictionary<char, int>();

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];
                charFrequencyMap.Put(rightChar, charFrequencyMap.GetOrDefault(rightChar, 0) + 1);
                while (charFrequencyMap.Count > k)
                {
                    char leftChar = str[windowStart];
                    charFrequencyMap.Put(leftChar, charFrequencyMap[leftChar] - 1);
                    if (charFrequencyMap[leftChar] == 0)
                    {
                        charFrequencyMap.Remove(leftChar);
                    }
                    windowStart++; 
                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }

            return maxLength;
        }
    }
}

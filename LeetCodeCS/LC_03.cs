using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    //Given a string s, find the length of the longest substring without duplicate characters.
    internal class LC_03
    {
        int LengthOfLongestSubstring(string s)
        {
            int lengthOfSubstring = 0;
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int start = 0;
            for(int i=0; i< s.Length; i++)
            {
                if (charIndexMap.ContainsKey(s[i]))
                {
                    start = Math.Max(charIndexMap[s[i]] + 1, start);
                }
                charIndexMap[s[i]] = i;
                lengthOfSubstring = Math.Max(lengthOfSubstring, i - start + 1);
            }
            return lengthOfSubstring;

        }
    }
}
